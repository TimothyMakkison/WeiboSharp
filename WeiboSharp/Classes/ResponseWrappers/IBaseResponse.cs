using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public interface IBaseResponse<T>
    {
        [JsonProperty("ok")]
        int Ok { get; set; }

        [JsonProperty("msg")]
        string Message { get; set; }

        [JsonProperty("data")]
        T Data { get; set; }
    }
}