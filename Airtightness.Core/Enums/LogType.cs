// 文件位置: Airtightness.Core/Enums/LogType.cs
using System.ComponentModel;

namespace Airtightness.Core.Enums
{
    /// <summary>
    /// 定义通信日志的类型，用于区分发送、接收、错误等不同日志消息
    /// </summary>
    public enum LogType
    {
        /// <summary>发送请求到设备</summary>
        [Description("发送")]
        Send = 0,

        /// <summary>接收设备响应</summary>
        [Description("接收")]
        Receive = 1,

        /// <summary>通信错误</summary>
        [Description("错误")]
        Error = 2,

        /// <summary>调试信息</summary>
        [Description("调试")]
        Debug = 3
    }
}
