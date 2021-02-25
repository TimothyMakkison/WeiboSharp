using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    public class UserTab
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


}
