using Newtonsoft.Json;
using System;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class Urls
    {
        [JsonProperty("mp4_720p_mp4")]
        public Uri Mp4720PMp4 { get; set; }

        [JsonProperty("mp4_hd_mp4")]
        public Uri Mp4HdMp4 { get; set; }

        [JsonProperty("mp4_ld_mp4")]
        public Uri Mp4LdMp4 { get; set; }
    }
}