using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ContainerUserInfoCardGroup
    {
        [JsonProperty("card_type")]
        public int CardType { get; set; }

        [JsonProperty("display_arrow")]
        public int DisplayArrow { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_content")]
        public string ItemContent { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("actionlog")]
        public ContainerUserInfoActionlog Actionlog { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("itemid")]
        public string Itemid { get; set; }
    }
}