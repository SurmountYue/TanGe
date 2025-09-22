using Airtightness.Core.Enums;
using Airtightness.Core.Interfaces;

using NModbus;  // 确保安装 NModbus4 包
using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Airtightness.Hardware
{
    /// <summary>
    /// 这是 IInstrument 接口的一个具体实现，
    /// 专门用于通过 Modbus TCP 协议与设备通信。
    /// 它相当于 IInstrument 定义下的“Modbus 驱动发动机”
    /// </summary>
    public class ModbusInstrument : IInstrument
    {
        private TcpClient _client;
        private IModbusMaster _master;

        private const byte SLAVE_ID = 1;
        private const ushort START_STOP_COIL = 0;
        private const ushort STATUS_REGISTER = 0;
        private const ushort PRESSURE_REGISTER_START = 100;
        /// <summary>
        /// 实现 IInstrument 定义的通信日志事件
        /// 外部（Presenter）可以订阅这个事件来获取发送/接收的原始信息
        /// </summary>
        public event Action<LogType, string> CommunicationLog;

        public async Task ConnectAsync(string connectionString)
        {
            try
            {
                var parts = connectionString.Split(':');
                if (parts.Length != 2)
                    throw new ArgumentException("连接字符串格式错误，应为 'IP:Port'");

                string ip = parts[0];
                if (!int.TryParse(parts[1], out int port))
                {
                    throw new ArgumentException($"连接字符串中的端口号 '{parts[1]}' 不是一个有效的数字。");
                }

                await Task.Run(() =>
                {
                    _client = new TcpClient();
                    _client.Connect(ip, port);

                    var factory = new ModbusFactory();
                    _master = factory.CreateMaster(_client);
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"连接 Modbus 设备失败: {ex.Message}", ex);
            }
        }

        public void Disconnect()
        {
            _master?.Dispose();
            _client?.Close();
        }

        public async Task StartTestAsync()
        {
            await Task.Run(() =>
            {
                _master.WriteSingleCoil(SLAVE_ID, START_STOP_COIL, true);
            });
        }

        public async Task StopTestAsync()
        {
            await Task.Run(() =>
            {
                _master.WriteSingleCoil(SLAVE_ID, START_STOP_COIL, false);
            });
        }

        public async Task<int> ReadStatusAsync()
        {
            return await Task.Run(() =>
            {
                ushort[] result = _master.ReadInputRegisters(SLAVE_ID, STATUS_REGISTER, 1);
                return (int)result[0];
            });
        }

        public async Task<float> ReadPressureAsync()
        {
            return await Task.Run(() =>
            {
                ushort[] registers = _master.ReadHoldingRegisters(SLAVE_ID, PRESSURE_REGISTER_START, 2);
                if (registers.Length < 2)
                    throw new InvalidOperationException("读取压力值失败，寄存器数量不足。");

                uint intValue = ((uint)registers[0] << 16) | registers[1];
                byte[] bytes = BitConverter.GetBytes(intValue);
                return BitConverter.ToSingle(bytes, 0);
            });
        }
    }
}
