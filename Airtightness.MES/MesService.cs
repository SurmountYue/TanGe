// 文件位置: Airtightness.MES/MesService.cs
using Airtightness.Core.DTOs;
using Airtightness.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Airtightness.MES
{
    /// <summary>
    /// 这是 IMesService 接口的一个具体实现，专门用于通过 Web API (HTTP) 与 MES 系统通信。
    /// 它就像是按照 IMesService “图纸”制造出来的“网络通信模块”。
    /// </summary>
    public class MesService : IMesService
    {
        // 最佳实践：HttpClient 在整个应用程序中应该是静态且共享的，以避免套接字耗尽。
        private static readonly HttpClient client = new HttpClient();
        public event Action<string> DebugLog;

        // MES 服务器的基础地址。在真实项目中，这个地址应该来自配置文件而不是硬编码。
        // 我们暂时使用之前在 Postman 中创建的模拟服务器地址。
        private readonly string _baseUrl;

        // 运行时传入 URL
        public MesService(string baseUrl)
        {
            _baseUrl = baseUrl?.TrimEnd('/') ?? string.Empty;
            client.Timeout = TimeSpan.FromSeconds(10);
        }
        public MesService()
        {
            // 可以设置默认的请求头，例如API密钥（如果需要）
            // client.DefaultRequestHeaders.Add("ApiKey", "YOUR_API_KEY");
            // 设置一个超时时间，避免程序因网络问题无限期等待
            client.Timeout = TimeSpan.FromSeconds(10);
        }

        public async Task<ApiResponse> CheckSnAsync(string sn, string workstation)
        {
            // 1. 准备请求的完整URL和请求体(payload)
            string requestUri = $"{_baseUrl}/WebAPI/Base/CheckSN";
            var requestPayload = new SnCheckRequest { SN = sn, WorkStation = workstation };
            // ✅ 新增调试日志
            Console.WriteLine($"[MES] 校验SN URL: {requestUri}");
            Console.WriteLine($"[MES] 校验SN Payload: {JsonConvert.SerializeObject(requestPayload)}");
            DebugLog?.Invoke($"[MES] 校验SN URL: {requestUri}");
            DebugLog?.Invoke($"[MES] 校验SN Payload: {JsonConvert.SerializeObject(requestPayload)}");
            // 2. 将C#对象序列化为JSON字符串
            string jsonPayload = JsonConvert.SerializeObject(requestPayload);
            var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            try
            {
                // 3. 异步发送POST请求
                HttpResponseMessage response = await client.PostAsync(requestUri, httpContent);

                // 4. 检查响应状态码，如果不是成功(2xx)，则抛出异常
                response.EnsureSuccessStatusCode();

                // 5. 异步读取响应内容
                string responseBody = await response.Content.ReadAsStringAsync();
                // ✅ 新增返回日志
                Console.WriteLine($"[MES] 校验SN 返回: {responseBody}");
                DebugLog?.Invoke($"[MES] 校验SN 返回: {responseBody}");


                // 6. 将JSON响应字符串反序列化为C#的ApiResponse对象
                return JsonConvert.DeserializeObject<ApiResponse>(responseBody);
            }
            catch (Exception ex)
            {
                // 如果发生任何网络错误或HTTP错误，捕获异常并返回一个表示失败的ApiResponse对象
                // 在实际项目中，这里应该记录详细的错误日志
                return new ApiResponse { Result = false, Message = $"调用MES校验SN接口失败: {ex.Message}" };
            }
        }

        public async Task<ApiResponse> UploadTestResultAsync(TestDataUploadRequest testResult)
        {
            string requestUri = $"{_baseUrl}/WebAPI/Test/ReciveTestData";
            // ✅ 新增调试日志
            Console.WriteLine($"[MES] 上传结果 URL: {requestUri}");
            Console.WriteLine($"[MES] 上传结果 Payload: {JsonConvert.SerializeObject(testResult)}");
            DebugLog?.Invoke($"[MES] 上传结果 URL: {requestUri}");
            DebugLog?.Invoke($"[MES] 上传结果 Payload: {JsonConvert.SerializeObject(testResult)}");
            string jsonPayload = JsonConvert.SerializeObject(testResult);
            var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync(requestUri, httpContent);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // ✅ 新增返回日志
                Console.WriteLine($"[MES] 上传结果 返回: {responseBody}");
                DebugLog?.Invoke($"[MES] 上传结果 返回: {responseBody}");
                return JsonConvert.DeserializeObject<ApiResponse>(responseBody);
            }
            catch (Exception ex)
            {
                return new ApiResponse { Result = false, Message = $"调用MES上传结果接口失败: {ex.Message}" };
            }
        }
    }
}