using Newtonsoft.Json;
using System;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class FluffyLarge
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("geo")]
        public FluffyGeo Geo { get; set; }
    }
}