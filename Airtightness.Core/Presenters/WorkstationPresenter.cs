// 文件位置: Airtightness.Core/Presenters/WorkstationPresenter.cs

using Airtightness.Core.Enums;
using Airtightness.Core.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Airtightness.Core.Presenters
{
    /// <summary>
    /// 工作站的“主持人”或“大脑”，负责协调UI(View)和后台服务(Model)。
    /// 它包含了单个工位的所有业务逻辑、状态管理和测试流程。
    /// 它是完全独立于UI的，不引用任何System.Windows.Forms相关的命名空间。
    /// </summary>
    public class WorkstationPresenter
    {
        #region 字段 (Fields) - Presenter所控制的“零件”和自身状态

        // --- 依赖的外部服务 (通过接口引用，实现解耦) ---
        private readonly IInstrument _instrument;
        private readonly IMesService _mesService;
        private readonly string _stationName;

        // --- 内部状态管理 ---
        private WorkstationState _currentState;
        private CancellationTokenSource _testCts; // 用于取消正在进行的测试轮询

        // --- 生产统计数据 ---
        private int _totalCount = 0;
        private int _okCount = 0;
        private int _ngCount = 0;

        #endregion

        #region 事件 (Events) - Presenter向UI汇报状态

        /// <summary>
        /// 当工作站状态发生改变时触发
        /// </summary>
        public event Action<WorkstationState, string> StateChanged;

        /// <summary>
        /// 当需要向UI记录日志时触发
        /// </summary>
        public event Action<string> LogMessageGenerated;

        /// <summary>
        /// 当需要向全局通信日志汇报时触发
        /// </summary>
        public event Action<LogType, string> CommunicationLogGenerated;

        /// <summary>
        /// 当生产统计数据更新时触发
        /// </summary>
        public event Action<int, int, int> StatisticsUpdated;

        /// <summary>
        /// 当有实时数据更新时触发
        /// </summary>
        public event Action<float, float, float> RealtimeDataUpdated;

        #endregion

        #region 构造函数 (Constructor) - 依赖注入

        /// <summary>
        /// 构造函数，通过“依赖注入”的方式传入所需的服务。
        /// Presenter不关心传入的是ModbusTcp还是ModbusRtu的实例，它只面向IInstrument接口编程。
        /// </summary>
        public WorkstationPresenter(string stationName, IInstrument instrument, IMesService mesService)
        {
            _stationName = stationName;
            _instrument = instrument;
            _mesService = mesService;

            // 订阅最底层的硬件通信日志事件
            _instrument.CommunicationLog += OnInstrumentCommunicationLog;
        }

        #endregion

        #region 公共方法 (Public Methods) - UI向Presenter下达指令

        /// <summary>
        /// 初始化工作站，连接设备
        /// </summary>
        public async Task InitializeAsync()
        {
            SetState(WorkstationState.Connecting, "正在连接设备...");
            try
            {
                // 注意：这里的连接字符串在真实项目中应来自配置文件
                await _instrument.ConnectAsync("127.0.0.1:502"); // 假设使用Modbus TCP模拟器
                SetState(WorkstationState.Idle, "设备连接成功，等待操作");
            }
            catch (Exception ex)
            {
                SetState(WorkstationState.Error, $"设备连接失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 处理UI层发起的“开始测试”请求
        /// </summary>
        public async Task HandleStartRequestAsync(string barcode)
        {
            if (_currentState != WorkstationState.Ready && _currentState != WorkstationState.Idle)
            {
                Log("当前状态无法开始测试。");
                return;
            }

            try
            {
                // 1. 校验SN
                SetState(WorkstationState.CheckingSn, $"正在校验条码: {barcode}...");
                var snCheckResponse = await _mesService.CheckSnAsync(barcode, _stationName);
                if (!snCheckResponse.Result)
                {
                    SetState(WorkstationState.Error, $"条码校验失败: {snCheckResponse.Message}");
                    return;
                }
                SetState(WorkstationState.Ready, "条码校验通过，准备测试");

                // 2. 开始测试
                SetState(WorkstationState.Testing, "测试进行中...");
                _testCts = new CancellationTokenSource();
                // 启动一个后台任务来轮询设备数据
                var pollingTask = Task.Run(() => ReadDataLoopAsync(_testCts.Token));

                await _instrument.StartTestAsync();

                // 等待轮询任务结束 (它会在设备返回OK/NG后自行结束)
                var testResult = await pollingTask;

                // 3. 根据测试结果更新状态
                _totalCount++;
                if (testResult == WorkstationState.TestPassed)
                {
                    _okCount++;
                    SetState(WorkstationState.TestPassed, "测试结果: OK");
                }
                else
                {
                    _ngCount++;
                    SetState(WorkstationState.TestFailed, "测试结果: NG");
                }

                // 4. 上传结果到MES
                StatisticsUpdated?.Invoke(_totalCount, _okCount, _ngCount);
                SetState(WorkstationState.UploadingResults, "正在上传结果到MES...");
                // (此处省略了构建上传数据模型的代码)
                await _mesService.UploadTestResultAsync(new Core.DTOs.TestDataUploadRequest { SN = barcode /* ... 其他数据 */ });

                // 5. 回到空闲状态
                SetState(WorkstationState.Idle, "流程结束，等待操作");
            }
            catch (Exception ex)
            {
                SetState(WorkstationState.Error, $"测试流程发生严重错误: {ex.Message}");
            }
        }

        /// <summary>
        /// 处理UI层发起的“停止测试”请求
        /// </summary>
        public void HandleStopRequest()
        {
            _testCts?.Cancel(); // 取消后台轮询任务
            _instrument.StopTestAsync(); // 命令设备停止
            SetState(WorkstationState.Idle, "测试已手动停止");
        }

        /// <summary>
        /// 处理UI层发起的“清零产量”请求
        /// </summary>
        public void HandleClearStatsRequest()
        {
            _totalCount = 0;
            _okCount = 0;
            _ngCount = 0;
            StatisticsUpdated?.Invoke(_totalCount, _okCount, _ngCount);
            Log("产量数据已清零。");
        }

        #endregion

        #region 私有方法 (Private Methods) - 内部逻辑

        /// <summary>
        /// 在后台线程中循环读取设备数据
        /// </summary>
        private async Task<WorkstationState> ReadDataLoopAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var status = await _instrument.ReadStatusAsync();
                    // 假设 2=OK, 3=NG 是测试结束的标志
                    if (status == 2) return WorkstationState.TestPassed;
                    if (status == 3) return WorkstationState.TestFailed;

                    var pressure = await _instrument.ReadPressureAsync();
                    // 触发事件，将实时数据汇报给UI
                    RealtimeDataUpdated?.Invoke(pressure, 0, 0); // 假设只关心压力值

                    await Task.Delay(500, token); // 每500毫秒轮询一次
                }
                catch (TaskCanceledException)
                {
                    // 任务被取消是正常操作，直接退出
                    break;
                }
                catch (Exception ex)
                {
                    Log($"轮询数据时发生错误: {ex.Message}");
                    // 轮询出错，也应终止测试
                    return WorkstationState.Error;
                }
            }
            return WorkstationState.Idle; // 默认返回
        }

        /// <summary>
        /// 统一的状态变更方法
        /// </summary>
        private void SetState(WorkstationState newState, string logMessage)
        {
            _currentState = newState;
            Log(logMessage); // 记录日志
            StateChanged?.Invoke(newState, logMessage); // 触发状态变更事件，通知UI
        }

        /// <summary>
        /// 统一的日志记录方法
        /// </summary>
        private void Log(string message)
        {
            LogMessageGenerated?.Invoke($"[{_stationName}] {message}");
        }

        /// <summary>
        /// 当底层的硬件驱动产生通信日志时，此方法被调用
        /// </summary>
        private void OnInstrumentCommunicationLog(LogType type, string message)
        {
            // Presenter 在这里扮演“二传手”的角色，把底层日志加上自己的名字，再传给上层UI
            CommunicationLogGenerated?.Invoke(type, $"[{_stationName}] {message}");
        }

        #endregion
    }
}