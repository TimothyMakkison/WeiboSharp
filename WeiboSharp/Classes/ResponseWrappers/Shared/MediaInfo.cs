using Newtonsoft.Json;
using System;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class MediaInfo
    {
        [JsonProperty("stream_url")]
        public Uri StreamUrl { get; set; }

        [JsonProperty("stream_url_hd")]
        public Uri StreamUrlHd { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }
    }
}