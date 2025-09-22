// 文件位置: Airtightness.Core/DTOs/MesModels.cs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Airtightness.Core.DTOs
{
    // -------------------------------------------------------------------
    // 请求模型 (Request Models) - 这是我们的程序发送给MES的数据格式
    // -------------------------------------------------------------------

    /// <summary>
    /// 用于“SN校验”API请求的“快递盒”。
    /// 它将被序列化为 {"SN":"XXXX", "WorkStation":"工位1"} 这样的JSON字符串。
    /// </summary>
    public class SnCheckRequest
    {
        [JsonProperty("SN")]
        public string SN { get; set; }

        [JsonProperty("WorkStation")]
        public string WorkStation { get; set; }
    }

    /// <summary>
    /// 用于“上传测试结果”API请求的“快递盒”。
    /// </summary>
    public class TestDataUploadRequest
    {
        [JsonProperty("SN")]
        public string SN { get; set; }

        [JsonProperty("WorkStation")]
        public string WorkStation { get; set; }

        [JsonProperty("TestResult")]
        public string TestResult { get; set; }

        [JsonProperty("TestTime")]
        public DateTime TestTime { get; set; }

        // 注意这里是一个列表，对应JSON中的 [...] 数组
        [JsonProperty("TestData")]
        public List<TestDataItem> TestData { get; set; }
    }

    /// <summary>
    /// TestDataUploadRequest中包含的单个测试项目的格式。
    /// </summary>
    public class TestDataItem
    {
        [JsonProperty("TestItem")]
        public string TestItem { get; set; }

        [JsonProperty("TestValue")]
        public string TestValue { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }
    }


    // -------------------------------------------------------------------
    // 响应模型 (Response Model) - 这是MES返回给我们的数据格式
    // -------------------------------------------------------------------

    /// <summary>
    /// 用于接收所有MES API通用响应的“回执单”。
    /// MES返回的JSON {"Result":true, "Message":"...", "Data":null} 将被反序列化到这个类的对象中。
    /// </summary>
    public class ApiResponse
    {
        [JsonProperty("Result")]
        public bool Result { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Data")]
        public object Data { get; set; }
    }
}