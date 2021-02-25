using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaUserInfoContainerResponse : BaseStatusResponse
    {
        [JsonProperty("user")] public InstaUserInfoResponse User { get; set; }
    }
}