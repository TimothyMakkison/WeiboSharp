using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaStoryMediaResponse
    {
        [JsonProperty("media")] public InstaStoryItemResponse Media { get; set; }
    }
}