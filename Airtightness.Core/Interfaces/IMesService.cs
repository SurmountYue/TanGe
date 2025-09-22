// 文件位置: Airtightness.Core/Interfaces/IMesService.cs
using Airtightness.Core.DTOs;
using System.Threading.Tasks;

namespace Airtightness.Core.Interfaces
{
    /// <summary>
    /// 定义了与MES（制造执行系统）交互必须遵守的通用功能契约。
    /// 我们的核心业务逻辑将通过此接口与外部系统对话，
    /// 而无需关心具体的通信方式是Web API, 还是未来可能更换的其他技术。
    /// </summary>
    public interface IMesService
    {
        /// <summary>
        /// 异步校验产品序列号 (SN)。
        /// </summary>
        /// <param name="sn">从扫码枪或手动输入的产品序列号</param>
        /// <param name="workstation">发起校验的当前工位名称</param>
        /// <returns>
        /// 返回一个Task，其结果是一个ApiResponse对象。
        /// ApiResponse对象中包含了MES返回的成功/失败信息。
        /// </returns>
        Task<ApiResponse> CheckSnAsync(string sn, string workstation);

        /// <summary>
        /// 异步上传测试结果。
        /// </summary>
        /// <param name="testResult">
        /// 这是一个包含了本次测试所有相关信息的DTO（数据传输对象）。
        /// 将所有数据打包成一个对象进行传输，是一种良好、清晰的编程实践。
        /// </param>
        /// <returns>返回一个ApiResponse对象，告知上传是否成功。</returns>
        Task<ApiResponse> UploadTestResultAsync(TestDataUploadRequest testResult);
    }
}