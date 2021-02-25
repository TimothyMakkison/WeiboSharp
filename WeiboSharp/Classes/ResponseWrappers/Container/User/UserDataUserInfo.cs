using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    public class UserDataUserInfo
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idstr")]
        public string Idstr { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("verified_type")]
        public int VerifiedType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("avatar_large")]
        public string AvatarLarge { get; set; }

        [JsonProperty("avatar_hd")]
        public string AvatarHd { get; set; }

        [JsonProperty("verified_type_ext")]
        public int VerifiedTypeExt { get; set; }

        [JsonProperty("follow_me")]
        public bool FollowMe { get; set; }

        [JsonProperty("mbtype")]
        public int Mbtype { get; set; }

        [JsonProperty("mbrank")]
        public int Mbrank { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("story_read_state")]
        public int StoryReadState { get; set; }

        [JsonProperty("allow_msg")]
        public int AllowMsg { get; set; }

        [JsonProperty("special_follow")]
        public bool SpecialFollow { get; set; }
    }


}
