using System;
using System.IO.Ports;
using System.Threading;
using NModbus.IO;

namespace Airtightness.Hardware
{
    /// <summary>
    /// 把 System.IO.Ports.SerialPort 封装成 NModbus 可用的 IStreamResource
    /// </summary>
    public class SerialPortAdapter : IStreamResource
    {
        private readonly SerialPort _serialPort;

        public SerialPortAdapter(SerialPort serialPort)
        {
            _serialPort = serialPort ?? throw new ArgumentNullException(nameof(serialPort));
        }

        public int InfiniteTimeout => Timeout.Infinite;

        public int ReadTimeout
        {
            get => _serialPort.ReadTimeout;
            set => _serialPort.ReadTimeout = value;
        }

        public int WriteTimeout
        {
            get => _serialPort.WriteTimeout;
            set => _serialPort.WriteTimeout = value;
        }

        public void DiscardInBuffer()
        {
            _serialPort.DiscardInBuffer();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return _serialPort.Read(buffer, offset, count);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            _serialPort.Write(buffer, offset, count);
        }

        public void Dispose()
        {
            _serialPort?.Dispose();
        }
    }
}
