// 文件位置: Airtightness.Core/Enums/WorkstationState.cs
namespace Airtightness.Core.Enums
{
    /// <summary>
    /// 定义了工位在整个测试生命周期中可能处于的所有明确状态。
    /// 在业务逻辑中，我们将使用这些枚举值来控制流程和更新UI显示。
    /// 例如: switch(currentState) { case WorkstationState.Testing: ... }
    /// </summary>
    public enum WorkstationState
    {
        /// <summary>
        /// 离线或初始状态
        /// </summary>
        Offline,

        /// <summary>
        /// 正在连接设备
        /// </summary>
        Connecting,

        /// <summary>
        /// 连接成功，空闲状态，等待操作
        /// </summary>
        Idle,

        /// <summary>
        /// 等待扫描产品条码
        /// </summary>
        WaitingForBarcode,

        /// <summary>
        /// 正在通过API与MES系统校验条码
        /// </summary>
        CheckingSn,

        /// <summary>
        /// 校验通过，准备就绪，可以开始测试
        /// </summary>
        Ready,

        /// <summary>
        /// 正在执行气密性测试
        /// </summary>
        Testing,

        /// <summary>
        /// 测试流程完成，结果为通过 (OK)
        /// </summary>
        TestPassed,

        /// <summary>
        /// 测试流程完成，结果为不通过 (NG)
        /// </summary>
        TestFailed,

        /// <summary>
        /// 正在将测试结果上传到MES系统
        /// </summary>
        UploadingResults,

        /// <summary>
        /// 发生了一个未知的或严重错误
        /// </summary>
        Error
    }
}