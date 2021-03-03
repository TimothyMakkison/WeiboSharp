using Newtonsoft.Json;
using System;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class DataPic
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("geo")]
        public PurpleGeo Geo { get; set; }

        [JsonProperty("large")]
        public PurpleLarge Large { get; set; }
    }
}