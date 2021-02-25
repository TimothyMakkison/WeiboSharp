using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaPermalinkResponse : BaseStatusResponse
    {
        [JsonProperty("permalink")] public string Permalink { get; set; }
    }
}