using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        [JsonProperty("ok")]
        public int Ok { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}