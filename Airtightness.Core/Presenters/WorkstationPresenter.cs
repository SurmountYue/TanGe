using Airtightness.Core.Enums;
using Airtightness.Core.Interfaces;
using Airtightness.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Airtightness.Core.Presenters
{
    /// <summary>
    /// 【核心业务主持人】—— 单个工位的业务逻辑控制类
    /// 
    /// - 职责：
    ///   1. 负责协调 UI(View) 与 硬件(IInstrument) 及 MES(IMesService) 之间的交互。
    ///   2. 实现完整的气密性测试流程（扫码 → MES校验 → 测试 → 判定 → 上传MES）。
    ///   3. 维护工位的当前状态（状态机），并向 UI 实时报告。
    ///   4. 统计生产数据、采集实时数据、处理异常。
    /// 
    /// - 特点：
    ///   * 完全独立于 UI，不引用任何 WinForms 控件类。
    ///   * 通过事件机制与上层通信（解耦、易单元测试）。
    ///   * 提供异步方法，避免阻塞 UI 线程。
    /// </summary>
    public class WorkstationPresenter
    {
        #region ======== 字段（私有变量） ========

        /// <summary>硬件控制层接口（下位机通讯）</summary>
        private readonly IInstrument _instrument;

        /// <summary>MES系统接口</summary>
        private readonly IMesService _mesService;

        /// <summary>工位名称（如“工位1”）</summary>
        private readonly string _stationName;

        /// <summary>当前工位的状态机状态</summary>
        private WorkstationState _currentState;

        /// <summary>用于取消测试循环的令牌（手动停止或异常时使用）</summary>
        private CancellationTokenSource _testCts;

        /// <summary>总测试数</summary>
        private int _totalCount;
        /// <summary>合格数</summary>
        private int _okCount;
        /// <summary>不合格数</summary>
        private int _ngCount;

        #endregion

        #region ======== 事件（Presenter对UI的回调） ========

        /// <summary>
        /// 当工位状态变化时触发
        /// 参数：
        ///   WorkstationState - 新状态枚举值
        ///   string - 状态说明文字（UI直接显示）
        /// </summary>
        public event Action<WorkstationState, string> StateChanged;

        /// <summary>
        /// 当需要添加系统日志（工位层面的业务日志）时触发
        /// </summary>
        public event Action<string> LogMessageGenerated;

        /// <summary>
        /// 当需要添加通信日志（底层硬件收发包日志）时触发
        /// </summary>
        public event Action<LogType, string> CommunicationLogGenerated;

        /// <summary>
        /// 当生产统计数据更新时触发（总数、OK数、NG数）
        /// </summary>
        public event Action<int, int, int> StatisticsUpdated;

        /// <summary>
        /// 当实时数据更新时触发（泄漏值、进气压力、温度等）
        /// </summary>
        public event Action<float, float, float> RealtimeDataUpdated;

        #endregion

        #region ======== 构造函数 ========

        /// <summary>
        /// 构造一个工位业务控制器
        /// </summary>
        /// <param name="stationName">工位名称</param>
        /// <param name="instrument">注入的硬件实现（IInstrument）</param>
        /// <param name="mesService">注入的MES服务实现（IMesService）</param>
        public WorkstationPresenter(string stationName, IInstrument instrument, IMesService mesService)
        {
            _stationName = stationName;
            _instrument = instrument;
            _mesService = mesService;

            // 订阅硬件的底层通信日志事件，让UI能显示原始收发数据
            _instrument.CommunicationLog += OnInstrumentCommunicationLog;
        }

        #endregion

        #region ======== 核心流程方法 ========

        /// <summary>
        /// 初始化工位：连接设备
        /// </summary>
        /// <param name="connectionString">连接参数，例如 "127.0.0.1:502" 或 "COM3"</param>
        public async Task InitializeAsync(string connectionString)
        {
            SetState(WorkstationState.Connecting, "正在连接设备...");
            try
            {
                await _instrument.ConnectAsync(connectionString);
                SetState(WorkstationState.Idle, "设备连接成功，等待开始测试");
            }
            catch (Exception ex)
            {
                SetState(WorkstationState.Error, $"设备连接失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 进入等待条码扫描状态
        /// </summary>
        public void RequestBarcodeScan()
        {
            if (_currentState != WorkstationState.Idle)
                return;

            SetState(WorkstationState.WaitingForBarcode, "请扫描产品条码...");
        }

        /// <summary>
        /// 处理扫码完成（进入MES校验）
        /// </summary>
        /// <param name="barcode">扫描到的产品SN条码</param>
        public async Task HandleBarcodeAsync(string barcode)
        {
            if (_currentState != WorkstationState.WaitingForBarcode)
                return;

            SetState(WorkstationState.CheckingSn, $"正在向MES校验SN: {barcode}");

            // 调用MES接口校验条码
            var response = await _mesService.CheckSnAsync(barcode, _stationName);

            if (response.Result)
            {
                SetState(WorkstationState.Ready, "条码校验通过，准备测试");
            }
            else
            {
                Log($"SN校验失败: {response.Message}");
                SetState(WorkstationState.Idle, "等待扫描...");
            }
        }

        /// <summary>
        /// 启动测试流程（Ready → Testing）
        /// </summary>
        public async Task StartTestAsync()
        {
            if (_currentState != WorkstationState.Ready)
                return;

            SetState(WorkstationState.Testing, "正在测试中...");
            _testCts = new CancellationTokenSource();

            try
            {
                // 发送开始测试命令
                await _instrument.StartTestAsync();

                bool finished = false;

                // 测试轮询（直到结果产生）
                while (!_testCts.Token.IsCancellationRequested && !finished)
                {
                    int statusCode = await _instrument.ReadStatusAsync();
                    float pressure = await _instrument.ReadPressureAsync();
                    float leakValue = new Random().Next(0, 5); // TODO: 真实数据
                    float temp = 25f + (float)new Random().NextDouble(); // TODO: 真实数据

                    // 把实时数据推送给UI
                    RealtimeDataUpdated?.Invoke(leakValue, pressure, temp);

                    // 假设下位机状态码 2 = OK, 3 = NG
                    if (statusCode == 2)
                    {
                        finished = true;
                        _okCount++;
                        _totalCount++;
                        SetState(WorkstationState.TestPassed, "测试合格 (OK)");
                    }
                    else if (statusCode == 3)
                    {
                        finished = true;
                        _ngCount++;
                        _totalCount++;
                        SetState(WorkstationState.TestFailed, "测试不合格 (NG)");
                    }

                    // 更新生产统计数据
                    StatisticsUpdated?.Invoke(_totalCount, _okCount, _ngCount);

                    await Task.Delay(500); // 每0.5秒轮询一次
                }

                // 测试完成后自动上传 MES
                await UploadResultAsync();
            }
            catch (Exception ex)
            {
                SetState(WorkstationState.Error, $"测试过程出错: {ex.Message}");
            }
            finally
            {
                _testCts = null;
            }
        }

        /// <summary>
        /// 手动停止测试
        /// </summary>
        public void StopTest()
        {
            _testCts?.Cancel();
            _instrument.StopTestAsync();
            SetState(WorkstationState.Idle, "测试被中止");
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {
            _instrument.Disconnect();
            SetState(WorkstationState.Offline, "已断开连接");
        }

        #endregion

        #region ======== 内部工具方法 ========

        /// <summary>
        /// 上传测试结果到MES
        /// </summary>
        private async Task UploadResultAsync()
        {
            SetState(WorkstationState.UploadingResults, "正在上传结果到MES...");
            try
            {
                var request = new TestDataUploadRequest
                {
                    SN = "FAKE123456", // TODO: 替换为真实条码
                    WorkStation = _stationName,
                    TestResult = _currentState == WorkstationState.TestPassed ? "OK" : "NG",
                    TestTime = DateTime.Now,
                    TestData = new List<TestDataItem>
                    {
                        new TestDataItem { TestItem = "Leak", TestValue = "1.23", Unit = "Pa" },
                        new TestDataItem { TestItem = "Pressure", TestValue = "101.5", Unit = "kPa" }
                    }
                };

                var resp = await _mesService.UploadTestResultAsync(request);
                if (resp.Result)
                {
                    Log("MES上传成功");
                    SetState(WorkstationState.Idle, "等待下一个测试");
                }
                else
                {
                    Log($"MES上传失败: {resp.Message}");
                    SetState(WorkstationState.Error, "MES上传失败");
                }
            }
            catch (Exception ex)
            {
                SetState(WorkstationState.Error, $"上传MES出错: {ex.Message}");
            }
        }

        /// <summary>
        /// 设置当前状态，并通知UI
        /// </summary>
        private void SetState(WorkstationState state, string message)
        {
            _currentState = state;
            StateChanged?.Invoke(state, message);
            Log(message);
        }

        /// <summary>
        /// 添加一条业务日志（UI显示）
        /// </summary>
        private void Log(string message)
        {
            string logMsg = $"[{DateTime.Now:HH:mm:ss}] {_stationName}: {message}";
            LogMessageGenerated?.Invoke(logMsg);
        }

        /// <summary>
        /// 当硬件触发通信日志时触发
        /// </summary>
        private void OnInstrumentCommunicationLog(LogType type, string msg)
        {
            CommunicationLogGenerated?.Invoke(type, $"[{_stationName}] {msg}");
        }

        #endregion
    }
}
