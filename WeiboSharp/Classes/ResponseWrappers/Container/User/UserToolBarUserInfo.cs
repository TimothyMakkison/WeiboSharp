using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    //TODO Check this may be shared
    public class UserToolBarUserInfo
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("verified_type")]
        public int VerifiedType { get; set; }

        [JsonProperty("verified_type_ext")]
        public int VerifiedTypeExt { get; set; }

        [JsonProperty("verified_reason")]
        public string VerifiedReason { get; set; }

        [JsonProperty("close_blue_v")]
        public bool CloseBlueV { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("mbtype")]
        public int Mbtype { get; set; }

        [JsonProperty("urank")]
        public int Urank { get; set; }

        [JsonProperty("mbrank")]
        public int Mbrank { get; set; }

        [JsonProperty("follow_me")]
        public bool FollowMe { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("follow_count")]
        public int FollowCount { get; set; }

        [JsonProperty("cover_image_phone")]
        public string CoverImagePhone { get; set; }

        [JsonProperty("avatar_hd")]
        public string AvatarHd { get; set; }

        [JsonProperty("like")]
        public bool Like { get; set; }

        [JsonProperty("like_me")]
        public bool LikeMe { get; set; }

        [JsonProperty("toolbar_menus")]
        public IList<UserToolbarMenu> ToolbarMenus { get; set; }
    }


}
