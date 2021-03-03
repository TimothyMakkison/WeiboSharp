using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class ContainerPageResponse
    {
        [JsonProperty("cardlistInfo")]
        public FluffyCardlistInfo CardlistInfo { get; set; }

        [JsonProperty("cards")]
        public List<FluffyCard> Cards { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("showAppTips")]
        public long ShowAppTips { get; set; }
    }

    public partial class FluffyCardlistInfo
    {
        [JsonProperty("containerid")]
        public string Containerid { get; set; }

        [JsonProperty("v_p")]
        public long VP { get; set; }

        [JsonProperty("show_style")]
        public long ShowStyle { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("since_id")]
        public long SinceId { get; set; }
    }

    public partial class FluffyCard
    {
        [JsonProperty("card_type")]
        public long CardType { get; set; }

        [JsonProperty("itemid")]
        public string Itemid { get; set; }

        [JsonProperty("scheme")]
        public Uri Scheme { get; set; }

        [JsonProperty("mblog")]
        public Mblog Mblog { get; set; }
    }

    public partial class Mblog
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

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        [JsonProperty("show_additional_indication")]
        public long ShowAdditionalIndication { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? TextLength { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("pic_ids")]
        public List<string> PicIds { get; set; }

        [JsonProperty("pic_types")]
        public string PicTypes { get; set; }

        [JsonProperty("thumbnail_pic", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ThumbnailPic { get; set; }

        [JsonProperty("bmiddle_pic", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BmiddlePic { get; set; }

        [JsonProperty("original_pic", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OriginalPic { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("mblog_vip_type")]
        public long MblogVipType { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("picStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string PicStatus { get; set; }

        [JsonProperty("reposts_count")]
        public string RepostsCount { get; set; }

        [JsonProperty("comments_count")]
        public string CommentsCount { get; set; }

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

        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        [JsonProperty("ad_state", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdState { get; set; }

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("mblogtype")]
        public long Mblogtype { get; set; }

        [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
        public string Mark { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("more_info_type")]
        public long MoreInfoType { get; set; }

        [JsonProperty("cardid")]
        public string Cardid { get; set; }

        [JsonProperty("extern_safe")]
        public long ExternSafe { get; set; }

        [JsonProperty("number_display_strategy")]
        public NumberDisplayStrategy NumberDisplayStrategy { get; set; }

        [JsonProperty("enable_comment_guide")]
        public bool EnableCommentGuide { get; set; }

        [JsonProperty("content_auth")]
        public long ContentAuth { get; set; }

        [JsonProperty("hide_hot_flow")]
        public long HideHotFlow { get; set; }

        [JsonProperty("pic_num")]
        public long PicNum { get; set; }

        [JsonProperty("alchemy_params")]
        public AlchemyParams AlchemyParams { get; set; }

        [JsonProperty("mblog_menu_new_style")]
        public long MblogMenuNewStyle { get; set; }

        [JsonProperty("edit_config")]
        public EditConfig EditConfig { get; set; }

        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public MblogPageInfo PageInfo { get; set; }

        [JsonProperty("pics", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPic> Pics { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }

        [JsonProperty("retweeted_status", NullValueHandling = NullValueHandling.Ignore)]
        public RetweetedStatus RetweetedStatus { get; set; }

        [JsonProperty("repost_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? RepostType { get; set; }

        [JsonProperty("raw_text", NullValueHandling = NullValueHandling.Ignore)]
        public string RawText { get; set; }

        [JsonProperty("exempt_block_url", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExemptBlockUrl { get; set; }
    }

    public partial class EditConfig
    {
        [JsonProperty("edited")]
        public bool Edited { get; set; }
    }

    public partial class MblogPageInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object_type")]
        public long ObjectType { get; set; }

        [JsonProperty("page_pic")]
        public PurplePagePic PagePic { get; set; }

        [JsonProperty("page_url")]
        public Uri PageUrl { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("content1")]
        public string Content1 { get; set; }

        [JsonProperty("url_ori", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlOri { get; set; }

        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("content2", NullValueHandling = NullValueHandling.Ignore)]
        public string Content2 { get; set; }

        [JsonProperty("video_orientation", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoOrientation { get; set; }

        [JsonProperty("play_count", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayCount { get; set; }

        [JsonProperty("media_info", NullValueHandling = NullValueHandling.Ignore)]
        public MediaInfo MediaInfo { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public Urls Urls { get; set; }
    }

    public partial class RetweetedStatus
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

        [JsonProperty("version")]
        public long Version { get; set; }

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

        [JsonProperty("hide_multi_attitude")]
        public long HideMultiAttitude { get; set; }

        [JsonProperty("reward_exhibition_type")]
        public long RewardExhibitionType { get; set; }

        [JsonProperty("hide_flag")]
        public long HideFlag { get; set; }

        [JsonProperty("mlevel")]
        public long Mlevel { get; set; }

        [JsonProperty("expire_time")]
        public long ExpireTime { get; set; }

        [JsonProperty("ad_state")]
        public long AdState { get; set; }

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("mblogtype")]
        public long Mblogtype { get; set; }

        [JsonProperty("mark")]
        public string Mark { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("more_info_type")]
        public long MoreInfoType { get; set; }

        [JsonProperty("content_auth")]
        public long ContentAuth { get; set; }

        [JsonProperty("pic_num")]
        public long PicNum { get; set; }

        [JsonProperty("edit_config")]
        public EditConfig EditConfig { get; set; }

        [JsonProperty("page_info")]
        public RetweetedStatusPageInfo PageInfo { get; set; }

        [JsonProperty("pics")]
        public List<RetweetedStatusPic> Pics { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }
    }

    public partial class RetweetedStatusPageInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object_type")]
        public long ObjectType { get; set; }

        [JsonProperty("page_pic")]
        public FluffyPagePic PagePic { get; set; }

        [JsonProperty("page_url")]
        public Uri PageUrl { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("content1")]
        public string Content1 { get; set; }
    }

    public partial class FluffyPagePic
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class RetweetedStatusPic
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("geo")]
        public PurpleGeo Geo { get; set; }

        [JsonProperty("large")]
        public FluffyLarge Large { get; set; }
    }
}