using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class BadStatusErrorsResponse : BaseStatusResponse
    {
        [JsonProperty("message")] public MessageErrorsResponse Message { get; set; }
    }
}