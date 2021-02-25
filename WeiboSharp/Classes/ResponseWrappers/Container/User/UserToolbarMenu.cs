using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    public class UserToolbarMenu
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; }

        [JsonProperty("params")]
        public UserParams Params { get; set; }

        [JsonProperty("userInfo")]
        public UserToolBarUserInfo UserInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }
    }


}
