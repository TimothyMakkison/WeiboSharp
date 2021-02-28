namespace WeiboSharp.Classes.ResponseWrappers
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class ContainerUserResponse
    {
        [JsonProperty("avatar_guide")]
        public List<object> AvatarGuide { get; set; }

        [JsonProperty("isStarStyle")]
        public long IsStarStyle { get; set; }

        [JsonProperty("userInfo")]
        public User UserInfo { get; set; }

        [JsonProperty("fans_scheme")]
        public Uri FansScheme { get; set; }

        [JsonProperty("follow_scheme")]
        public Uri FollowScheme { get; set; }

        [JsonProperty("tabsInfo")]
        public TabsInfo TabsInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("showAppTips")]
        public long ShowAppTips { get; set; }
    }

    public partial class TabsInfo
    {
        [JsonProperty("selectedTab")]
        public long SelectedTab { get; set; }

        [JsonProperty("tabs")]
        public List<Tab> Tabs { get; set; }
    }

    public partial class Tab
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tabKey")]
        public string TabKey { get; set; }

        [JsonProperty("must_show")]
        public long MustShow { get; set; }

        [JsonProperty("hidden")]
        public long Hidden { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tab_type")]
        public string TabType { get; set; }

        [JsonProperty("containerid")]
        public string Containerid { get; set; }

        [JsonProperty("apipath", NullValueHandling = NullValueHandling.Ignore)]
        public string Apipath { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

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

    public partial class ToolbarMenuParams
    {
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Uid { get; set; }

        [JsonProperty("extparams", NullValueHandling = NullValueHandling.Ignore)]
        public Extparams Extparams { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Scheme { get; set; }
    }

    public partial class Extparams
    {
        [JsonProperty("followcardid")]
        public object Followcardid { get; set; }
    }

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