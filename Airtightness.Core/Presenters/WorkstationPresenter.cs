using Airtightness.Core.Enums;
using Airtightness.Core.Interfaces;
using System;
using System.Drawing;

using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Airtightness.Core.DTOs;

namespace Airtightness.Core.Presenters
{
    public class WorkstationPresenter
    {
        // ===== 字段 =====
        private readonly IInstrument _instrument;
        private readonly IMesService _mesService;
        private readonly string _stationName;

        private WorkstationState _currentState;
        private CancellationTokenSource _testCts;

        private int _totalCount;
        private int _okCount;
        private int _ngCount;

        // ===== 事件 =====
        // 状态（业务状态，比如 Ready / Testing / Error）
        public event Action<WorkstationState, string> StateChanged;
        // 业务日志
        public event Action<string> LogMessageGenerated;
        // 通信日志
        public event Action<LogType, string> CommunicationLogGenerated;
        // 生产统计
        public event Action<int, int, int> StatisticsUpdated;
        // 实时数据
        public event Action<float, float, float> RealtimeDataUpdated;

        // **新加：通信状态变化（专门给 lblCommStatus 用）**
        public event Action<string,string> CommStatusChanged;

        // ===== 构造函数 =====
        public WorkstationPresenter(string stationName, IInstrument instrument, IMesService mesService)
        {
            _stationName = stationName;
            _instrument = instrument;
            _mesService = mesService;

            _instrument.CommunicationLog += OnInstrumentCommunicationLog;
        }

        // ===== 公共属性（可选）=====
        public WorkstationState CurrentState => _currentState;

        // ===== 初始化连接 =====
        public async Task<bool> InitializeAsync(string connectionString)
        {
            SetState(WorkstationState.Connecting, "正在连接设备...");
            try
            {
                await _instrument.ConnectAsync(connectionString);
                SetState(WorkstationState.Idle, "设备连接成功，等待开始测试");

                // 通知通信状态：已连接（绿色）
                CommStatusChanged?.Invoke("设备已连接","LimeGreen");
                return true;
            }
            catch (Exception ex)
            {
                SetState(WorkstationState.Error, $"设备连接失败: {ex.Message}");

                // 通知通信状态：已断开（红色）
                CommStatusChanged?.Invoke("设备已断开", "Red");
                return false;
            }
        }

        // ===== 断开连接 =====
        public void Disconnect()
        {
            _instrument.Disconnect();
            SetState(WorkstationState.Offline, "设备已断开");

            // 通知通信状态：已断开（红色）
            CommStatusChanged?.Invoke("设备已断开", "Red");
        }

        // ===== 开始测试 =====
        public async Task StartTestAsync()
        {
            if (_currentState != WorkstationState.Ready)
            {
                Log($"当前状态不是 Ready，无法开始测试（当前：{_currentState}）");
                return;
            }

            SetState(WorkstationState.Testing, "正在测试中...");
            _testCts = new CancellationTokenSource();

            try
            {
                await _instrument.StartTestAsync();
                bool finished = false;

                while (!_testCts.Token.IsCancellationRequested && !finished)
                {
                    int statusCode = await _instrument.ReadStatusAsync();
                    float pressure = await _instrument.ReadPressureAsync();
                    float leakValue = new Random().Next(0, 5); // TODO: 替换成真实数据
                    float temp = 25f + (float)new Random().NextDouble();

                    RealtimeDataUpdated?.Invoke(leakValue, pressure, temp);

                    if (statusCode == 2)
                    {
                        finished = true;
                        _okCount++;
                        _totalCount++;
                        SetState(WorkstationState.TestPassed, "测试合格(OK)");
                    }
                    else if (statusCode == 3)
                    {
                        finished = true;
                        _ngCount++;
                        _totalCount++;
                        SetState(WorkstationState.TestFailed, "测试不合格(NG)");
                    }

                    StatisticsUpdated?.Invoke(_totalCount, _okCount, _ngCount);
                    await Task.Delay(500);
                }
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

        // ===== 停止测试 =====
        public void StopTest()
        {
            _testCts?.Cancel();
            _instrument.StopTestAsync();
            SetState(WorkstationState.Idle, "测试被中止");
        }

        // ===== 内部方法 =====
        private void SetState(WorkstationState state, string message)
        {
            _currentState = state;
            StateChanged?.Invoke(state, message);
            Log(message);
        }

        private void Log(string message)
        {
            string logMsg = $"[{DateTime.Now:HH:mm:ss}] {_stationName}: {message}";
            LogMessageGenerated?.Invoke(logMsg);
        }

        private void OnInstrumentCommunicationLog(LogType type, string msg)
        {
            CommunicationLogGenerated?.Invoke(type, $"[{_stationName}] {msg}");
        }
    }
}
