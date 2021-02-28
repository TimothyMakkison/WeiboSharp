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
}