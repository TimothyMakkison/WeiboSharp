using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ContainerUserInfoCardlistInfo
    {
        [JsonProperty("show_style")]
        public int ShowStyle { get; set; }

        [JsonProperty("can_shared")]
        public int CanShared { get; set; }

        [JsonProperty("cardlist_menus")]
        public List<ContainerUserInfoCardlistMenu> CardlistMenus { get; set; }

        [JsonProperty("v_p")]
        public string VP { get; set; }

        [JsonProperty("cardlist_title")]
        public string CardlistTitle { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("containerid")]
        public string Containerid { get; set; }

        [JsonProperty("page")]
        public object Page { get; set; }
    }
}