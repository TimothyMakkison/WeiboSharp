using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class FluffyGeo
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("croped")]
        public bool Croped { get; set; }
    }
}