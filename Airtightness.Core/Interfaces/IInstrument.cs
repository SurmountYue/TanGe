// 文件位置: Airtightness.Core/Interfaces/IInstrument.cs
using System;
using System.Threading.Tasks;
using Airtightness.Core.Enums;
namespace Airtightness.Core.Interfaces
{
    /// <summary>
    /// 定义了所有仪器/下位机必须遵守的通用功能契约。
    /// 业务逻辑层将通过此接口与硬件交互，而无需关心具体是什么品牌、什么协议的设备。
    /// 这就是“面向接口编程”的核心思想，是实现解耦的关键。
    /// </summary>
    public interface IInstrument
    {
        /// <summary>
        /// 异步连接到设备。
        /// 使用Task表示这是一个可能需要等待的异步操作，防止UI线程阻塞。
        /// </summary>
        /// <param name="connectionString">连接参数，对于TCP可以是"IP:Port"，对于串口可以是"COM1"</param>
        Task ConnectAsync(string connectionString);

        /// <summary>
        /// 断开与设备的连接。
        /// 通常是同步操作，因为它应该很快完成。
        /// </summary>
        void Disconnect();

        /// <summary>
        /// 异步命令设备开始测试。
        /// </summary>
        Task StartTestAsync();

        /// <summary>
        /// 异步命令设备停止测试。
        /// </summary>
        Task StopTestAsync();

        /// <summary>
        /// 异步读取设备当前的状态码。
        /// 状态码由我们和下位机工程师共同约定（例如：0=空闲, 1=测试中, 2=OK, 3=NG）。
        /// </summary>
        /// <returns>返回一个代表设备状态的整数。</returns>
        Task<int> ReadStatusAsync();

        /// <summary>
        /// 异步读取设备测得的压力值。
        /// </summary>
        /// <returns>返回一个代表压力值的浮点数。</returns>
        Task<float> ReadPressureAsync();

        /// <summary>
        /// 当设备通信产生日志时触发
        /// 这样上层业务逻辑可以监听硬件层的通信详情，用于调试和监控
        /// </summary>
        event Action<LogType, string> CommunicationLog; // ✅ 添加这个事件
    }
}