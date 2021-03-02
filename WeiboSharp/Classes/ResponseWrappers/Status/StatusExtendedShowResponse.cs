using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    /// <summary>
    /// Status Extend
    ///
    /// GET
    /// </summary>
    public partial class StatusExtendedShowResponse
    {
        [JsonProperty("visible")]
        public Visible Visible { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("idstr")]
        public string Idstr { get; set; }

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

        [JsonProperty("source_allowclick")]
        public long SourceAllowclick { get; set; }

        [JsonProperty("source_type")]
        public long SourceType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("appid")]
        public long Appid { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("in_reply_to_status_id")]
        public string InReplyToStatusId { get; set; }

        [JsonProperty("in_reply_to_user_id")]
        public string InReplyToUserId { get; set; }

        [JsonProperty("in_reply_to_screen_name")]
        public string InReplyToScreenName { get; set; }

        [JsonProperty("pic_ids")]
        public List<object> PicIds { get; set; }

        [JsonProperty("pic_types")]
        public string PicTypes { get; set; }

        [JsonProperty("geo")]
        public object Geo { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("mblog_vip_type")]
        public long MblogVipType { get; set; }

        [JsonProperty("user")]
        public StatusExtendUser User { get; set; }

        [JsonProperty("annotations")]
        public List<Annotation> Annotations { get; set; }

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

        [JsonProperty("reward_scheme")]
        public string RewardScheme { get; set; }

        [JsonProperty("hide_flag")]
        public long HideFlag { get; set; }

        [JsonProperty("mlevel")]
        public long Mlevel { get; set; }

        [JsonProperty("biz_ids")]
        public List<long> BizIds { get; set; }

        [JsonProperty("biz_feature")]
        public long BizFeature { get; set; }

        [JsonProperty("url_objects")]
        public List<UrlObject> UrlObjects { get; set; }

        [JsonProperty("hasActionTypeCard")]
        public long HasActionTypeCard { get; set; }

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("hot_weibo_tags")]
        public List<object> HotWeiboTags { get; set; }

        [JsonProperty("text_tag_tips")]
        public List<object> TextTagTips { get; set; }

        [JsonProperty("mblogtype")]
        public long Mblogtype { get; set; }

        [JsonProperty("userType")]
        public long UserType { get; set; }

        [JsonProperty("more_info_type")]
        public long MoreInfoType { get; set; }

        [JsonProperty("number_display_strategy")]
        public NumberDisplayStrategy NumberDisplayStrategy { get; set; }

        [JsonProperty("positive_recom_flag")]
        public long PositiveRecomFlag { get; set; }

        [JsonProperty("content_auth")]
        public long ContentAuth { get; set; }

        [JsonProperty("gif_ids")]
        public string GifIds { get; set; }

        [JsonProperty("is_show_bulletin")]
        public long IsShowBulletin { get; set; }

        [JsonProperty("safe_tags")]
        public long SafeTags { get; set; }

        [JsonProperty("comment_manage_info")]
        public CommentManageInfo CommentManageInfo { get; set; }

        [JsonProperty("pic_num")]
        public long PicNum { get; set; }

        [JsonProperty("fid")]
        public long Fid { get; set; }

        [JsonProperty("alchemy_params")]
        public AlchemyParams AlchemyParams { get; set; }

        [JsonProperty("status_title")]
        public string StatusTitle { get; set; }
    }

    public partial class Annotation
    {
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Uid { get; set; }

        [JsonProperty("with_video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithVideo { get; set; }

        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("mapi_request", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MapiRequest { get; set; }
    }

    public partial class CommentManageInfo
    {
        [JsonProperty("comment_permission_type")]
        public long CommentPermissionType { get; set; }

        [JsonProperty("approval_comment_type")]
        public long ApprovalCommentType { get; set; }
    }

    public partial class UrlObject
    {
        [JsonProperty("url_ori")]
        public Uri UrlOri { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("object")]
        public UrlObjectObject Object { get; set; }

        [JsonProperty("like_count")]
        public long LikeCount { get; set; }

        [JsonProperty("play_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayCount { get; set; }

        [JsonProperty("isActionType")]
        public bool IsActionType { get; set; }

        [JsonProperty("follower_count")]
        public long FollowerCount { get; set; }

        [JsonProperty("asso_like_count")]
        public long AssoLikeCount { get; set; }

        [JsonProperty("card_info_un_integrity")]
        public bool CardInfoUnIntegrity { get; set; }

        [JsonProperty("super_topic_status_count")]
        public long SuperTopicStatusCount { get; set; }

        [JsonProperty("super_topic_photo_count")]
        public long SuperTopicPhotoCount { get; set; }

        [JsonProperty("search_topic_count")]
        public long SearchTopicCount { get; set; }

        [JsonProperty("search_topic_read_count")]
        public long SearchTopicReadCount { get; set; }

        [JsonProperty("is_follow_object_author")]
        public bool IsFollowObjectAuthor { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("url_short")]
        public Uri UrlShort { get; set; }

        [JsonProperty("url_long")]
        public Uri UrlLong { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("last_modified")]
        public long LastModified { get; set; }

        [JsonProperty("transcode")]
        public long Transcode { get; set; }

        [JsonProperty("ext_status")]
        public long ExtStatus { get; set; }

        [JsonProperty("trusted_state")]
        public long TrustedState { get; set; }
    }

    public partial class UrlObjectObject
    {
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("containerid")]
        public string Containerid { get; set; }

        [JsonProperty("object_domain_id")]
        public long ObjectDomainId { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("safe_status")]
        public long SafeStatus { get; set; }

        [JsonProperty("show_status")]
        public long ShowStatus { get; set; }

        [JsonProperty("act_status")]
        public string ActStatus { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("uuid")]
        public long Uuid { get; set; }

        [JsonProperty("uuidstr")]
        public string Uuidstr { get; set; }

        [JsonProperty("activate_status")]
        public long ActivateStatus { get; set; }

        [JsonProperty("object")]
        public ObjectObject Object { get; set; }

        [JsonProperty("is_longtext")]
        public bool IsLongtext { get; set; }
    }

    public partial class ObjectObject
    {
        [JsonProperty("fid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Fid { get; set; }

        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        [JsonProperty("video_cover", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoCover { get; set; }

        [JsonProperty("copyright", NullValueHandling = NullValueHandling.Ignore)]
        public long? Copyright { get; set; }

        [JsonProperty("target_url")]
        public Uri TargetUrl { get; set; }

        [JsonProperty("input_tags", NullValueHandling = NullValueHandling.Ignore)]
        public InputTags InputTags { get; set; }

        [JsonProperty("video_orientation", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoOrientation { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("screenshots", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Uri> Screenshots { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public Urls Urls { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("file_monitor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileMonitorType { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream Stream { get; set; }

        [JsonProperty("client", NullValueHandling = NullValueHandling.Ignore)]
        public string Client { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Links Links { get; set; }

        [JsonProperty("definition", NullValueHandling = NullValueHandling.Ignore)]
        public string Definition { get; set; }

        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Category> Categories { get; set; }

        [JsonProperty("cover_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CoverImage { get; set; }

        [JsonProperty("author_mid", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorMid { get; set; }

        [JsonProperty("cover_screenshot_meta", NullValueHandling = NullValueHandling.Ignore)]
        public CoverScreenshotMeta CoverScreenshotMeta { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("embed_code", NullValueHandling = NullValueHandling.Ignore)]
        public Uri EmbedCode { get; set; }

        [JsonProperty("image")]
        public PurplePagePic Image { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        [JsonProperty("monitor_state", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonitorState { get; set; }

        [JsonProperty("infringement_status", NullValueHandling = NullValueHandling.Ignore)]
        public long? InfringementStatus { get; set; }

        [JsonProperty("titles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Title> Titles { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        [JsonProperty("video_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoType { get; set; }

        [JsonProperty("object_type_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectTypeDetail { get; set; }

        [JsonProperty("original_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OriginalUrl { get; set; }

        [JsonProperty("original_file_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalFileMd5 { get; set; }

        [JsonProperty("compressed_file_meta", NullValueHandling = NullValueHandling.Ignore)]
        public CompressedFileMeta CompressedFileMeta { get; set; }

        [JsonProperty("appid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Appid { get; set; }

        [JsonProperty("domesticOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DomesticOnly { get; set; }

        [JsonProperty("file_create_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileCreateType { get; set; }

        [JsonProperty("tag_verify_state", NullValueHandling = NullValueHandling.Ignore)]
        public long? TagVerifyState { get; set; }

        [JsonProperty("custom_data", NullValueHandling = NullValueHandling.Ignore)]
        public CustomData CustomData { get; set; }

        [JsonProperty("biz")]
        public Biz Biz { get; set; }

        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExtInfo ExtInfo { get; set; }

        [JsonProperty("biz_flag", NullValueHandling = NullValueHandling.Ignore)]
        public BizFlag BizFlag { get; set; }

        [JsonProperty("article_browser", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArticleBrowser { get; set; }

        [JsonProperty("article_recommend", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ArticleRecommend { get; set; }

        [JsonProperty("article_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArticleType { get; set; }

        [JsonProperty("collection", NullValueHandling = NullValueHandling.Ignore)]
        public Collection Collection { get; set; }

        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreateAt { get; set; }

        [JsonProperty("dynamic_img_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DynamicImgList { get; set; }

        [JsonProperty("full_image", NullValueHandling = NullValueHandling.Ignore)]
        public FullImage FullImage { get; set; }

        [JsonProperty("is_new_style", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNewStyle { get; set; }

        [JsonProperty("is_taoke", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsTaoke { get; set; }

        [JsonProperty("is_vclub", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsVclub { get; set; }

        [JsonProperty("is_word", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsWord { get; set; }

        [JsonProperty("ispay", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ispay { get; set; }

        [JsonProperty("mid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Mid { get; set; }

        [JsonProperty("oid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Oid { get; set; }

        [JsonProperty("ourl", NullValueHandling = NullValueHandling.Ignore)]
        public string Ourl { get; set; }

        [JsonProperty("show_dynamic_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowDynamicCard { get; set; }

        [JsonProperty("sub_article_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubArticleType { get; set; }

        [JsonProperty("target_oid", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetOid { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }
    }

    public partial class Author
    {
        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("avatar_large")]
        public Uri AvatarLarge { get; set; }

        [JsonProperty("followers_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FollowersCount { get; set; }

        [JsonProperty("verified_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? VerifiedType { get; set; }

        [JsonProperty("verified_type_ext", NullValueHandling = NullValueHandling.Ignore)]
        public long? VerifiedTypeExt { get; set; }

        [JsonProperty("verified_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifiedReason { get; set; }

        [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        [JsonProperty("verified_level", NullValueHandling = NullValueHandling.Ignore)]
        public long? VerifiedLevel { get; set; }
    }

    public partial class Biz
    {
        [JsonProperty("biz_id")]
        public long BizId { get; set; }

        [JsonProperty("containerid")]
        public string Containerid { get; set; }
    }

    public partial class BizFlag
    {
        [JsonProperty("contribution")]
        public long Contribution { get; set; }

        [JsonProperty("short_video")]
        public long ShortVideo { get; set; }

        [JsonProperty("st_video")]
        public long StVideo { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("category")]
        public string CategoryCategory { get; set; }
    }

    public partial class Collection
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public long Source { get; set; }
    }

    public partial class CompressedFileMeta
    {
        [JsonProperty("video_media_info")]
        public VideoMediaInfo VideoMediaInfo { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }
    }

    public partial class VideoMediaInfo
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class CoverScreenshotMeta
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("pids")]
        public List<string> Pids { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class CustomData
    {
        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public partial class ExtInfo
    {
        [JsonProperty("video_orientation")]
        public string VideoOrientation { get; set; }
    }

    public partial class FullImage
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }

    public partial class InputTags
    {
        [JsonProperty("creation_time")]
        public DateTimeOffset CreationTime { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Stream
    {
        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("hd_url")]
        public Uri HdUrl { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("tag")]
        public string TagTag { get; set; }
    }

    public partial class Title
    {
        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("title")]
        public string TitleTitle { get; set; }
    }

    public partial class StatusExtendUser
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("idstr")]
        public long Idstr { get; set; }

        [JsonProperty("class")]
        public long Class { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("province")]
        public long Province { get; set; }

        [JsonProperty("city")]
        public long City { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("profile_image_url")]
        public Uri ProfileImageUrl { get; set; }

        [JsonProperty("cover_image")]
        public Uri CoverImage { get; set; }

        [JsonProperty("cover_image_phone")]
        public Uri CoverImagePhone { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("weihao")]
        public string Weihao { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("friends_count")]
        public long FriendsCount { get; set; }

        [JsonProperty("pagefriends_count")]
        public long PagefriendsCount { get; set; }

        [JsonProperty("statuses_count")]
        public long StatusesCount { get; set; }

        [JsonProperty("video_status_count")]
        public long VideoStatusCount { get; set; }

        [JsonProperty("video_play_count")]
        public long VideoPlayCount { get; set; }

        [JsonProperty("favourites_count")]
        public long FavouritesCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("allow_all_act_msg")]
        public bool AllowAllActMsg { get; set; }

        [JsonProperty("geo_enabled")]
        public bool GeoEnabled { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("verified_type")]
        public long VerifiedType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("insecurity")]
        public Insecurity Insecurity { get; set; }

        [JsonProperty("ptype")]
        public long Ptype { get; set; }

        [JsonProperty("allow_all_comment")]
        public bool AllowAllComment { get; set; }

        [JsonProperty("avatar_large")]
        public Uri AvatarLarge { get; set; }

        [JsonProperty("avatar_hd")]
        public Uri AvatarHd { get; set; }

        [JsonProperty("verified_reason")]
        public string VerifiedReason { get; set; }

        [JsonProperty("verified_trade")]
        public long VerifiedTrade { get; set; }

        [JsonProperty("verified_reason_url")]
        public string VerifiedReasonUrl { get; set; }

        [JsonProperty("verified_source")]
        public string VerifiedSource { get; set; }

        [JsonProperty("verified_source_url")]
        public string VerifiedSourceUrl { get; set; }

        [JsonProperty("verified_state")]
        public long VerifiedState { get; set; }

        [JsonProperty("verified_level")]
        public long VerifiedLevel { get; set; }

        [JsonProperty("verified_type_ext")]
        public long VerifiedTypeExt { get; set; }

        [JsonProperty("has_service_tel")]
        public bool HasServiceTel { get; set; }

        [JsonProperty("verified_reason_modified")]
        public string VerifiedReasonModified { get; set; }

        [JsonProperty("verified_contact_name")]
        public string VerifiedContactName { get; set; }

        [JsonProperty("verified_contact_email")]
        public string VerifiedContactEmail { get; set; }

        [JsonProperty("verified_contact_mobile")]
        public string VerifiedContactMobile { get; set; }

        [JsonProperty("follow_me")]
        public bool FollowMe { get; set; }

        [JsonProperty("like")]
        public bool Like { get; set; }

        [JsonProperty("like_me")]
        public bool LikeMe { get; set; }

        [JsonProperty("online_status")]
        public long OnlineStatus { get; set; }

        [JsonProperty("bi_followers_count")]
        public long BiFollowersCount { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("star")]
        public long Star { get; set; }

        [JsonProperty("mbtype")]
        public long Mbtype { get; set; }

        [JsonProperty("mbrank")]
        public long Mbrank { get; set; }

        [JsonProperty("block_word")]
        public long BlockWord { get; set; }

        [JsonProperty("block_app")]
        public long BlockApp { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("ulevel")]
        public long Ulevel { get; set; }

        [JsonProperty("user_limit")]
        public long UserLimit { get; set; }

        [JsonProperty("badge")]
        public Dictionary<string, long> Badge { get; set; }

        [JsonProperty("badge_top")]
        public string BadgeTop { get; set; }

        [JsonProperty("has_ability_tag")]
        public long HasAbilityTag { get; set; }

        [JsonProperty("extend")]
        public Extend Extend { get; set; }

        [JsonProperty("credit_score")]
        public long CreditScore { get; set; }

        [JsonProperty("user_ability")]
        public long UserAbility { get; set; }

        [JsonProperty("urank")]
        public long Urank { get; set; }

        [JsonProperty("story_read_state")]
        public long StoryReadState { get; set; }

        [JsonProperty("verified_detail")]
        public VerifiedDetail VerifiedDetail { get; set; }

        [JsonProperty("vclub_member")]
        public long VclubMember { get; set; }

        [JsonProperty("is_teenager")]
        public long IsTeenager { get; set; }

        [JsonProperty("is_guardian")]
        public long IsGuardian { get; set; }

        [JsonProperty("is_teenager_list")]
        public long IsTeenagerList { get; set; }

        [JsonProperty("pc_new")]
        public long PcNew { get; set; }

        [JsonProperty("special_follow")]
        public bool SpecialFollow { get; set; }

        [JsonProperty("planet_video")]
        public long PlanetVideo { get; set; }

        [JsonProperty("video_mark")]
        public long VideoMark { get; set; }

        [JsonProperty("live_status")]
        public long LiveStatus { get; set; }

        [JsonProperty("user_ability_extend")]
        public long UserAbilityExtend { get; set; }

        [JsonProperty("tab_manage")]
        public string TabManage { get; set; }
    }

    public partial class Extend
    {
        [JsonProperty("privacy")]
        public Privacy Privacy { get; set; }

        [JsonProperty("mbprivilege")]
        public string Mbprivilege { get; set; }
    }

    public partial class Privacy
    {
        [JsonProperty("mobile")]
        public long Mobile { get; set; }
    }

    public partial class Insecurity
    {
        [JsonProperty("sexual_content")]
        public bool SexualContent { get; set; }
    }

    public partial class VerifiedDetail
    {
        [JsonProperty("custom")]
        public long Custom { get; set; }

        [JsonProperty("data")]
        public List<VerifiedDetailDatum> Data { get; set; }
    }

    public partial class VerifiedDetailDatum
    {
        [JsonProperty("key")]
        public long Key { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }
    }
}