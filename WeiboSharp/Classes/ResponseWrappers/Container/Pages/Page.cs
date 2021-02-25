using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class CardlistInfo
    {
        [JsonProperty("containerid")]
        public string Containerid { get; set; }

        [JsonProperty("v_p")]
        public int VP { get; set; }

        [JsonProperty("show_style")]
        public int ShowStyle { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("since_id")]
        public long SinceId { get; set; }
    }

    public class Visible
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }
    }

    public class Badge
    {
        [JsonProperty("zongyiji")]
        public int Zongyiji { get; set; }

        [JsonProperty("follow_whitelist_video")]
        public int FollowWhitelistVideo { get; set; }

        [JsonProperty("user_name_certificate")]
        public int UserNameCertificate { get; set; }

        [JsonProperty("wenchuan_10th")]
        public int Wenchuan10th { get; set; }

        [JsonProperty("national_day_2018")]
        public int NationalDay2018 { get; set; }

        [JsonProperty("wbzy_2018")]
        public int Wbzy2018 { get; set; }

        [JsonProperty("memorial_2018")]
        public int Memorial2018 { get; set; }

        [JsonProperty("hongbaofei_2019")]
        public int Hongbaofei2019 { get; set; }

        [JsonProperty("wusi_2019")]
        public int Wusi2019 { get; set; }

        [JsonProperty("earth_2019")]
        public int Earth2019 { get; set; }

        [JsonProperty("hongrenjie_2019")]
        public int Hongrenjie2019 { get; set; }

        [JsonProperty("china_2019")]
        public int China2019 { get; set; }

        [JsonProperty("rrgyj_2019")]
        public int Rrgyj2019 { get; set; }

        [JsonProperty("weishi_2019")]
        public int Weishi2019 { get; set; }

        [JsonProperty("wbzy_2019")]
        public int Wbzy2019 { get; set; }

        [JsonProperty("gongjiri_2019")]
        public int Gongjiri2019 { get; set; }

        [JsonProperty("macao_2019")]
        public int Macao2019 { get; set; }

        [JsonProperty("china_2019_2")]
        public int China20192 { get; set; }

        [JsonProperty("hongbao_2020")]
        public int Hongbao2020 { get; set; }

        [JsonProperty("feiyan_2020")]
        public int Feiyan2020 { get; set; }

        [JsonProperty("kangyi_2020")]
        public int Kangyi2020 { get; set; }

        [JsonProperty("movie_2020")]
        public int Movie2020 { get; set; }

        [JsonProperty("china_2020")]
        public int China2020 { get; set; }

        [JsonProperty("weibozhiyexianxia_2021")]
        public int Weibozhiyexianxia2021 { get; set; }

        [JsonProperty("enterprise")]
        public int Enterprise { get; set; }

        [JsonProperty("gongyi_level")]
        public int GongyiLevel { get; set; }

        [JsonProperty("dailv")]
        public int Dailv { get; set; }

        [JsonProperty("self_media")]
        public int SelfMedia { get; set; }

        [JsonProperty("dzwbqlx_2016")]
        public int Dzwbqlx2016 { get; set; }

        [JsonProperty("travel_2017")]
        public int Travel2017 { get; set; }

        [JsonProperty("qixi_2018")]
        public int Qixi2018 { get; set; }

        [JsonProperty("meilizhongguo_2018")]
        public int Meilizhongguo2018 { get; set; }

        [JsonProperty("denglong_2019")]
        public int Denglong2019 { get; set; }

        [JsonProperty("suishoupai_2019")]
        public int Suishoupai2019 { get; set; }

        [JsonProperty("hongkong_2019")]
        public int Hongkong2019 { get; set; }

        [JsonProperty("shouhuan_2019")]
        public int Shouhuan2019 { get; set; }

        [JsonProperty("starlight_2019")]
        public int Starlight2019 { get; set; }

        [JsonProperty("pc_new")]
        public int PcNew { get; set; }

        [JsonProperty("school_2020")]
        public int School2020 { get; set; }

        [JsonProperty("hongrenjie_2020")]
        public int Hongrenjie2020 { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("verified_type")]
        public int VerifiedType { get; set; }

        [JsonProperty("verified_type_ext")]
        public int VerifiedTypeExt { get; set; }

        [JsonProperty("verified_reason")]
        public string VerifiedReason { get; set; }

        [JsonProperty("close_blue_v")]
        public bool CloseBlueV { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("mbtype")]
        public int Mbtype { get; set; }

        [JsonProperty("urank")]
        public int Urank { get; set; }

        [JsonProperty("mbrank")]
        public int Mbrank { get; set; }

        [JsonProperty("follow_me")]
        public bool FollowMe { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("follow_count")]
        public int FollowCount { get; set; }

        [JsonProperty("cover_image_phone")]
        public string CoverImagePhone { get; set; }

        [JsonProperty("avatar_hd")]
        public string AvatarHd { get; set; }

        [JsonProperty("like")]
        public bool Like { get; set; }

        [JsonProperty("like_me")]
        public bool LikeMe { get; set; }

        [JsonProperty("badge")]
        public Badge Badge { get; set; }
    }

    public class NumberDisplayStrategy
    {
        [JsonProperty("apply_scenario_flag")]
        public int ApplyScenarioFlag { get; set; }

        [JsonProperty("display_text_min_number")]
        public int DisplayTextMinNumber { get; set; }

        [JsonProperty("display_text")]
        public string DisplayText { get; set; }
    }

    public class AlchemyParams
    {
        [JsonProperty("ug_red_envelope")]
        public bool UgRedEnvelope { get; set; }
    }

    public class EditConfig
    {
        [JsonProperty("edited")]
        public bool Edited { get; set; }
    }

    public class PagePic
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("source")]
        public int? Source { get; set; }

        [JsonProperty("is_self_cover")]
        public int? IsSelfCover { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }
    }

    public class MediaInfo
    {
        [JsonProperty("stream_url")]
        public string StreamUrl { get; set; }

        [JsonProperty("stream_url_hd")]
        public string StreamUrlHd { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }
    }

    public class Urls
    {
        [JsonProperty("mp4_720p_mp4")]
        public string Mp4720pMp4 { get; set; }

        [JsonProperty("mp4_hd_mp4")]
        public string Mp4HdMp4 { get; set; }

        [JsonProperty("mp4_ld_mp4")]
        public string Mp4LdMp4 { get; set; }
    }

    public class PageInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object_type")]
        public int ObjectType { get; set; }

        [JsonProperty("page_pic")]
        public PagePic PagePic { get; set; }

        [JsonProperty("page_url")]
        public string PageUrl { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("content1")]
        public string Content1 { get; set; }

        [JsonProperty("url_ori")]
        public string UrlOri { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content2")]
        public string Content2 { get; set; }

        [JsonProperty("video_orientation")]
        public string VideoOrientation { get; set; }

        [JsonProperty("play_count")]
        public string PlayCount { get; set; }

        [JsonProperty("media_info")]
        public MediaInfo MediaInfo { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }
    }

    public class Geo
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("croped")]
        public bool Croped { get; set; }
    }

    public class Large
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("geo")]
        public Geo Geo { get; set; }
    }

    public class Pic
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }
    }

    public class RetweetedStatus
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
        public int Version { get; set; }

        [JsonProperty("show_additional_indication")]
        public int ShowAdditionalIndication { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textLength")]
        public int TextLength { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("pic_ids")]
        public List<string> PicIds { get; set; }

        [JsonProperty("pic_types")]
        public string PicTypes { get; set; }

        [JsonProperty("thumbnail_pic")]
        public string ThumbnailPic { get; set; }

        [JsonProperty("bmiddle_pic")]
        public string BmiddlePic { get; set; }

        [JsonProperty("original_pic")]
        public string OriginalPic { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("mblog_vip_type")]
        public int MblogVipType { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("picStatus")]
        public string PicStatus { get; set; }

        [JsonProperty("reposts_count")]
        public int RepostsCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("attitudes_count")]
        public int AttitudesCount { get; set; }

        [JsonProperty("pending_approval_count")]
        public int PendingApprovalCount { get; set; }

        [JsonProperty("isLongText")]
        public bool IsLongText { get; set; }

        [JsonProperty("hide_multi_attitude")]
        public int HideMultiAttitude { get; set; }

        [JsonProperty("reward_exhibition_type")]
        public int RewardExhibitionType { get; set; }

        [JsonProperty("hide_flag")]
        public int HideFlag { get; set; }

        [JsonProperty("mlevel")]
        public int Mlevel { get; set; }

        [JsonProperty("expire_time")]
        public int ExpireTime { get; set; }

        [JsonProperty("ad_state")]
        public int AdState { get; set; }

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("mblogtype")]
        public int Mblogtype { get; set; }

        [JsonProperty("mark")]
        public string Mark { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("more_info_type")]
        public int MoreInfoType { get; set; }

        [JsonProperty("content_auth")]
        public int ContentAuth { get; set; }

        [JsonProperty("pic_num")]
        public int PicNum { get; set; }

        [JsonProperty("edit_config")]
        public EditConfig EditConfig { get; set; }

        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("pics")]
        public List<Pic> Pics { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }
    }

    public class Mblog
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
        public int Version { get; set; }

        [JsonProperty("show_additional_indication")]
        public int ShowAdditionalIndication { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textLength")]
        public int TextLength { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("pic_ids")]
        public List<string> PicIds { get; set; }

        [JsonProperty("pic_types")]
        public string PicTypes { get; set; }

        [JsonProperty("thumbnail_pic")]
        public string ThumbnailPic { get; set; }

        [JsonProperty("bmiddle_pic")]
        public string BmiddlePic { get; set; }

        [JsonProperty("original_pic")]
        public string OriginalPic { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("mblog_vip_type")]
        public int MblogVipType { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("picStatus")]
        public string PicStatus { get; set; }

        [JsonProperty("reposts_count")]
        public object RepostsCount { get; set; }

        [JsonProperty("comments_count")]
        public object CommentsCount { get; set; }

        [JsonProperty("attitudes_count")]
        public int AttitudesCount { get; set; }

        [JsonProperty("pending_approval_count")]
        public int PendingApprovalCount { get; set; }

        [JsonProperty("isLongText")]
        public bool IsLongText { get; set; }

        [JsonProperty("reward_exhibition_type")]
        public int RewardExhibitionType { get; set; }

        [JsonProperty("hide_flag")]
        public int HideFlag { get; set; }

        [JsonProperty("mlevel")]
        public int Mlevel { get; set; }

        [JsonProperty("expire_time")]
        public int ExpireTime { get; set; }

        [JsonProperty("ad_state")]
        public int AdState { get; set; }

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("mblogtype")]
        public int Mblogtype { get; set; }

        [JsonProperty("mark")]
        public string Mark { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("more_info_type")]
        public int MoreInfoType { get; set; }

        [JsonProperty("cardid")]
        public string Cardid { get; set; }

        [JsonProperty("extern_safe")]
        public int ExternSafe { get; set; }

        [JsonProperty("number_display_strategy")]
        public NumberDisplayStrategy NumberDisplayStrategy { get; set; }

        [JsonProperty("enable_comment_guide")]
        public bool EnableCommentGuide { get; set; }

        [JsonProperty("content_auth")]
        public int ContentAuth { get; set; }

        [JsonProperty("hide_hot_flow")]
        public int HideHotFlow { get; set; }

        [JsonProperty("pic_num")]
        public int PicNum { get; set; }

        [JsonProperty("alchemy_params")]
        public AlchemyParams AlchemyParams { get; set; }

        [JsonProperty("mblog_menu_new_style")]
        public int MblogMenuNewStyle { get; set; }

        [JsonProperty("edit_config")]
        public EditConfig EditConfig { get; set; }

        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("pics")]
        public List<Pic> Pics { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }

        [JsonProperty("retweeted_status")]
        public RetweetedStatus RetweetedStatus { get; set; }

        [JsonProperty("repost_type")]
        public int? RepostType { get; set; }

        [JsonProperty("raw_text")]
        public string RawText { get; set; }

        [JsonProperty("exempt_block_url")]
        public bool? ExemptBlockUrl { get; set; }
    }

    public class Card
    {
        [JsonProperty("card_type")]
        public int CardType { get; set; }

        [JsonProperty("itemid")]
        public string Itemid { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("mblog")]
        public Mblog Mblog { get; set; }
    }

    public class PageData
    {
        [JsonProperty("cardlistInfo")]
        public CardlistInfo CardlistInfo { get; set; }

        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("showAppTips")]
        public int ShowAppTips { get; set; }
    }
}
