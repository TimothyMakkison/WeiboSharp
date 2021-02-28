namespace WeiboSharp.Classes.ResponseWrappers
{
    using Newtonsoft.Json;
    using System;

    public partial class ToolbarMenu
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; }

        [JsonProperty("params")]
        public ToolbarMenuParams Params { get; set; }

        [JsonProperty("userInfo", NullValueHandling = NullValueHandling.Ignore)]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Scheme { get; set; }
    }


}