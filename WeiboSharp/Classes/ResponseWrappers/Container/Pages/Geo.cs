using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class Geo
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("croped")]
        public bool Croped { get; set; }
    }
}