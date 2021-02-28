using Newtonsoft.Json;
using System;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class PurplePagePic
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public long? Source { get; set; }

        [JsonProperty("is_self_cover", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsSelfCover { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }
    }
}