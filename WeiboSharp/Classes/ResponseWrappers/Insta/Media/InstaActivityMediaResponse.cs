using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaActivityMediaResponse
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("image")] public string Image { get; set; }
    }
}
