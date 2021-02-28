namespace WeiboSharp.Classes.ResponseWrappers
{
    using Newtonsoft.Json;
    using System;

    public partial class UserInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("idstr")]
        public string Idstr { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("profile_image_url")]
        public Uri ProfileImageUrl { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("verified_type")]
        public long VerifiedType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("avatar_large")]
        public Uri AvatarLarge { get; set; }

        [JsonProperty("avatar_hd")]
        public Uri AvatarHd { get; set; }

        [JsonProperty("verified_type_ext")]
        public long VerifiedTypeExt { get; set; }

        [JsonProperty("follow_me")]
        public bool FollowMe { get; set; }

        [JsonProperty("mbtype")]
        public long Mbtype { get; set; }

        [JsonProperty("mbrank")]
        public long Mbrank { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("story_read_state")]
        public long StoryReadState { get; set; }

        [JsonProperty("allow_msg")]
        public long AllowMsg { get; set; }

        [JsonProperty("special_follow")]
        public bool SpecialFollow { get; set; }
    }


}