using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaWebLinkResponse
    {
        [JsonProperty("text")] public string Text { get; set; }

        [JsonProperty("link_context")] public InstaWebLinkContextResponse LinkContext { get; set; }
    }
}