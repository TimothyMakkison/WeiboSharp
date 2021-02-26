using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class Large
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("geo")]
        public Geo Geo { get; set; }
    }


}
