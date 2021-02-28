using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class StatusShowResponse
    {
        [JsonProperty("visible")]
        public Visible Visible { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mid")]
        public string Mid { get; set; }

        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

        [JsonProperty("show_additional_indication")]
        public long ShowAdditionalIndication { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textLength")]
        public long TextLength { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("pic_ids")]
        public List<string> PicIds { get; set; }

        [JsonProperty("pic_types")]
        public string PicTypes { get; set; }

        [JsonProperty("thumbnail_pic")]
        public Uri ThumbnailPic { get; set; }

        [JsonProperty("bmiddle_pic")]
        public Uri BmiddlePic { get; set; }

        [JsonProperty("original_pic")]
        public Uri OriginalPic { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("mblog_vip_type")]
        public long MblogVipType { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("picStatus")]
        public string PicStatus { get; set; }

        [JsonProperty("reposts_count")]
        public long RepostsCount { get; set; }

        [JsonProperty("comments_count")]
        public long CommentsCount { get; set; }

        [JsonProperty("attitudes_count")]
        public long AttitudesCount { get; set; }

        [JsonProperty("pending_approval_count")]
        public long PendingApprovalCount { get; set; }

        [JsonProperty("isLongText")]
        public bool IsLongText { get; set; }

        [JsonProperty("reward_exhibition_type")]
        public long RewardExhibitionType { get; set; }

        [JsonProperty("hide_flag")]
        public long HideFlag { get; set; }

        [JsonProperty("mlevel")]
        public long Mlevel { get; set; }

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("mblogtype")]
        public long Mblogtype { get; set; }

        [JsonProperty("more_info_type")]
        public long MoreInfoType { get; set; }

        [JsonProperty("cardid")]
        public string Cardid { get; set; }

        [JsonProperty("number_display_strategy")]
        public NumberDisplayStrategy NumberDisplayStrategy { get; set; }

        [JsonProperty("content_auth")]
        public long ContentAuth { get; set; }

        [JsonProperty("hide_hot_flow")]
        public long HideHotFlow { get; set; }

        [JsonProperty("pic_num")]
        public long PicNum { get; set; }

        [JsonProperty("alchemy_params")]
        public AlchemyParams AlchemyParams { get; set; }

        [JsonProperty("pics")]
        public List<DataPic> Pics { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }

        [JsonProperty("buttons")]
        public List<Button> Buttons { get; set; }

        [JsonProperty("status_title")]
        public string StatusTitle { get; set; }

        [JsonProperty("ok")]
        public long Ok { get; set; }
    }

    public partial class Visible
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("list_id")]
        public long ListId { get; set; }
    }

    public partial class Button
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sub_type")]
        public long SubType { get; set; }

        [JsonProperty("params")]
        public ButtonParams Params { get; set; }
    }

    public partial class ButtonParams
    {
        [JsonProperty("uid")]
        public long Uid { get; set; }
    }

    public partial class DataPic
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("geo")]
        public FluffyGeo Geo { get; set; }

        [JsonProperty("large")]
        public FluffyLarge Large { get; set; }
    }
}