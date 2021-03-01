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

        [JsonProperty("edit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? EditCount { get; set; }

        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

        [JsonProperty("edit_at", NullValueHandling = NullValueHandling.Ignore)]
        public string EditAt { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

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

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("mblogtype")]
        public long Mblogtype { get; set; }

        [JsonProperty("more_info_type")]
        public long MoreInfoType { get; set; }

        [JsonProperty("number_display_strategy")]
        public NumberDisplayStrategy NumberDisplayStrategy { get; set; }

        [JsonProperty("content_auth")]
        public long ContentAuth { get; set; }

        [JsonProperty("pic_num")]
        public long PicNum { get; set; }

        [JsonProperty("alchemy_params")]
        public AlchemyParams AlchemyParams { get; set; }

        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public DataPageInfo PageInfo { get; set; }

        [JsonProperty("pics", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPic> Pics { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }

        [JsonProperty("buttons")]
        public List<Button> Buttons { get; set; }

        [JsonProperty("status_title")]
        public string StatusTitle { get; set; }

        [JsonProperty("ok")]
        public long Ok { get; set; }

        [JsonProperty("pic_focus_point", NullValueHandling = NullValueHandling.Ignore)]
        public List<PicFocusPoint> PicFocusPoint { get; set; }

        [JsonProperty("pic_rectangle_object", NullValueHandling = NullValueHandling.Ignore)]
        public List<PicRectangleObject> PicRectangleObject { get; set; }

        [JsonProperty("pic_flag", NullValueHandling = NullValueHandling.Ignore)]
        public long? PicFlag { get; set; }

        [JsonProperty("ad_state", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdState { get; set; }

        [JsonProperty("cardid", NullValueHandling = NullValueHandling.Ignore)]
        public string Cardid { get; set; }

        [JsonProperty("hide_hot_flow", NullValueHandling = NullValueHandling.Ignore)]
        public long? HideHotFlow { get; set; }

        [JsonProperty("reward_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardScheme { get; set; }

        [JsonProperty("safe_tags", NullValueHandling = NullValueHandling.Ignore)]
        public long? SafeTags { get; set; }

        [JsonProperty("fid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Fid { get; set; }
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

    public partial class DataPageInfo
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

    public partial class PicFocusPoint
    {
        [JsonProperty("focus_point")]
        public FocusPoint FocusPoint { get; set; }

        [JsonProperty("pic_id")]
        public string PicId { get; set; }
    }

    public partial class FocusPoint
    {
        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }
    }

    public partial class PicRectangleObject
    {
        [JsonProperty("rectangle_objects")]
        public List<FocusPoint> RectangleObjects { get; set; }

        [JsonProperty("pic_id")]
        public string PicId { get; set; }
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
        public PurpleGeo Geo { get; set; }

        [JsonProperty("large")]
        public PurpleLarge Large { get; set; }
    }
}