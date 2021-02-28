namespace WeiboSharp.Classes.ResponseWrappers
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("profile_image_url")]
        public Uri ProfileImageUrl { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("statuses_count")]
        public long StatusesCount { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("verified_type")]
        public long VerifiedType { get; set; }

        [JsonProperty("verified_type_ext")]
        public long VerifiedTypeExt { get; set; }

        [JsonProperty("verified_reason")]
        public string VerifiedReason { get; set; }

        [JsonProperty("close_blue_v")]
        public bool CloseBlueV { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("mbtype")]
        public long Mbtype { get; set; }

        [JsonProperty("urank")]
        public long Urank { get; set; }

        [JsonProperty("mbrank")]
        public long Mbrank { get; set; }

        [JsonProperty("follow_me")]
        public bool FollowMe { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("follow_count")]
        public long FollowCount { get; set; }

        [JsonProperty("cover_image_phone")]
        public Uri CoverImagePhone { get; set; }

        [JsonProperty("avatar_hd")]
        public Uri AvatarHd { get; set; }

        [JsonProperty("like")]
        public bool Like { get; set; }

        [JsonProperty("like_me")]
        public bool LikeMe { get; set; }

        [JsonProperty("toolbar_menus", NullValueHandling = NullValueHandling.Ignore)]
        public List<ToolbarMenu> ToolbarMenus { get; set; }

        [JsonProperty("badge", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Badge { get; set; }
    }


}