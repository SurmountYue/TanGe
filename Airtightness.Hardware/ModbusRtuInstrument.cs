// 文件位置: Airtightness.Hardware/ModbusRtuInstrument.cs
using Airtightness.Core.Enums;
using Airtightness.Core.Interfaces;
using NModbus;
using System;
using System.IO.Ports; // 引入串口所需的命名空间
using System.Threading.Tasks;

namespace Airtightness.Hardware
{
    /// <summary>
    /// IInstrument接口的另一个具体实现，专门用于通过串口 (Modbus RTU) 与设备通信。
    /// </summary>
    public class ModbusRtuInstrument : IInstrument
    {
        private SerialPort _serialPort;
        private IModbusMaster _master;

        // --- Modbus寄存器地址约定 (与TCP版本完全相同) ---
        private const byte SLAVE_ID = 1;
        private const ushort START_STOP_COIL = 0;
        private const ushort STATUS_REGISTER = 0;
        private const ushort PRESSURE_REGISTER_START = 100;

        /// <summary>
        ///* 对于RTU，我们期望的 connectionString 格式为 "COM3"，或者更详细的 "COM3:9600:8:N:1"
        ///* 为了简单起见，我们这里只处理简单格式，并使用默认的串口参数。
        /// </summary>
        /// <summary>
        /// 实现 IInstrument 定义的通信日志事件
        /// 外部（Presenter）可以订阅这个事件来获取发送/接收的原始信息
        /// </summary>
        public event Action<LogType, string> CommunicationLog;
        public async Task ConnectAsync(string connectionString)
        {
            try
            {
                // 假设 connectionString 就是串口号, 例如 "COM3"
                string portName = connectionString;

                await Task.Run(() =>
                {
                    _serialPort = new SerialPort(portName);

                    // 设置标准的串口参数 (波特率, 数据位, 校验位, 停止位)
                    // 在真实项目中，这些参数也应该来自配置文件
                    _serialPort.BaudRate = 9600;
                    _serialPort.DataBits = 8;
                    _serialPort.Parity = Parity.None;
                    _serialPort.StopBits = StopBits.One;

                    // 打开串口
                    _serialPort.Open();
                    // 2. 创建一个 SerialPortAdapter 实例，将 _serialPort 包装起来

                    // 用 NModbus 提供的 SerialPortAdapter 包装 SerialPort
                    var adapter = new SerialPortAdapter(_serialPort);
                    // 使用ModbusFactory来创建RTU Master对象
                    var factory = new ModbusFactory();
                    // 注意这里的区别：CreateRtuMaster，并传入 serialPort 对象
                    _master = factory.CreateRtuMaster(adapter);
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"连接Modbus RTU设备失败: {ex.Message}", ex);
            }
        }

        public void Disconnect()
        {
            _master?.Dispose();
            _serialPort?.Close(); // 关闭串口
        }

        // =======================================================================
        // ==  请注意：从这里开始，下面的所有方法都与TCP版本一模一样！   ==
        // ==  这就是NModbus库和我们IInstrument接口抽象的强大之处。        ==
        // ==  上层逻辑完全不需要关心底层用的是TCP还是RTU。             ==
        // =======================================================================

        public async Task StartTestAsync()
        {
            await Task.Run(() => _master.WriteSingleCoil(SLAVE_ID, START_STOP_COIL, true));
        }

        public async Task StopTestAsync()
        {
            await Task.Run(() => _master.WriteSingleCoil(SLAVE_ID, START_STOP_COIL, false));
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