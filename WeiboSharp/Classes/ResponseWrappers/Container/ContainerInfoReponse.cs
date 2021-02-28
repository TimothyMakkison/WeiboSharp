using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class Actionlog
    {
        [JsonProperty("act_code")]
        public string ActCode { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("fid")]
        public string Fid { get; set; }

        [JsonProperty("cardid")]
        public string Cardid { get; set; }

        [JsonProperty("uicode")]
        public string Uicode { get; set; }
    }

    public class CardGroup
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
        public Actionlog Actionlog { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("itemid")]
        public string Itemid { get; set; }
    }

    public class Card
    {
        [JsonProperty("card_type")]
        public int CardType { get; set; }

        [JsonProperty("card_group")]
        public List<CardGroup> CardGroup { get; set; }
    }

    public class CardlistMenuParams
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }
    }

    public class CardlistMenu
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("params")]
        public CardlistMenuParams Params { get; set; }
    }

    public class CardlistInfo
    {
        [JsonProperty("show_style")]
        public int ShowStyle { get; set; }

        [JsonProperty("can_shared")]
        public int CanShared { get; set; }

        [JsonProperty("cardlist_menus")]
        public List<CardlistMenu> CardlistMenus { get; set; }

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

    public class ContainerInfoResponse
    {
        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }

        [JsonProperty("cardlistInfo")]
        public CardlistInfo CardlistInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("showAppTips")]
        public int ShowAppTips { get; set; }
    }
}