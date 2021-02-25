using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    public class UserResponse
    {

        [JsonProperty("avatar_guide")]
        public IList<object> AvatarGuide { get; set; }

        [JsonProperty("isStarStyle")]
        public int IsStarStyle { get; set; }

        [JsonProperty("userInfo")]
        public UserDataUserInfo UserInfo { get; set; }

        [JsonProperty("fans_scheme")]
        public string FansScheme { get; set; }

        [JsonProperty("follow_scheme")]
        public string FollowScheme { get; set; }

        [JsonProperty("tabsInfo")]
        public TabsInfo TabsInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("showAppTips")]
        public int ShowAppTips { get; set; }
    }


}
