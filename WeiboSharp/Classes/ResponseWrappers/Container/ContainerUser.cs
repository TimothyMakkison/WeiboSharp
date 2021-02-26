using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Extparams
    {
        [JsonProperty("followcardid")]
        public object Followcardid { get; set; }
    }

    public class Params
    {
        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("extparams")]
        public Extparams Extparams { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }
    }

    public class UserInfo2
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

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }

        [JsonProperty("verified_reason")]
        public string VerifiedReason { get; set; }

        [JsonProperty("close_blue_v")]
        public bool CloseBlueV { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("urank")]
        public int Urank { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("follow_count")]
        public int FollowCount { get; set; }

        [JsonProperty("cover_image_phone")]
        public string CoverImagePhone { get; set; }

        [JsonProperty("like")]
        public bool Like { get; set; }

        [JsonProperty("like_me")]
        public bool LikeMe { get; set; }

        [JsonProperty("toolbar_menus")]
        public List<ToolbarMenu> ToolbarMenus { get; set; }
    }

    public class ToolbarMenu
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }
    }

    public class Tab
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tabKey")]
        public string TabKey { get; set; }

        [JsonProperty("must_show")]
        public int MustShow { get; set; }

        [JsonProperty("hidden")]
        public int Hidden { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tab_type")]
        public string TabType { get; set; }

        [JsonProperty("containerid")]
        public string Containerid { get; set; }

        [JsonProperty("apipath")]
        public string Apipath { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class TabsInfo
    {
        [JsonProperty("selectedTab")]
        public int SelectedTab { get; set; }

        [JsonProperty("tabs")]
        public List<Tab> Tabs { get; set; }
    }

    public class Data
    {
        [JsonProperty("avatar_guide")]
        public List<object> AvatarGuide { get; set; }

        [JsonProperty("isStarStyle")]
        public int IsStarStyle { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

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

    public class Root
    {
        [JsonProperty("ok")]
        public int Ok { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }


}
