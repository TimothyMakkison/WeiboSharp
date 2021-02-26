using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class Pic
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }
    }


}
