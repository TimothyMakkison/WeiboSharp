using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ShowBadge
    {
        [JsonProperty("dzwbqlx_2016")]
        public int Dzwbqlx2016 { get; set; }

        [JsonProperty("follow_whitelist_video")]
        public int FollowWhitelistVideo { get; set; }

        [JsonProperty("panda")]
        public int Panda { get; set; }

        [JsonProperty("user_name_certificate")]
        public int UserNameCertificate { get; set; }

        [JsonProperty("suishoupai_2018")]
        public int Suishoupai2018 { get; set; }

        [JsonProperty("wenchuan_10th")]
        public int Wenchuan10th { get; set; }

        [JsonProperty("super_star_2018")]
        public int SuperStar2018 { get; set; }

        [JsonProperty("dailv_2018")]
        public int Dailv2018 { get; set; }

        [JsonProperty("qixi_2018")]
        public int Qixi2018 { get; set; }

        [JsonProperty("memorial_2018")]
        public int Memorial2018 { get; set; }

        [JsonProperty("hongbaofei_2019")]
        public int Hongbaofei2019 { get; set; }

        [JsonProperty("hongrenjie_2019")]
        public int Hongrenjie2019 { get; set; }

        [JsonProperty("china_2019")]
        public int China2019 { get; set; }

        [JsonProperty("hongkong_2019")]
        public int Hongkong2019 { get; set; }

        [JsonProperty("rrgyj_2019")]
        public int Rrgyj2019 { get; set; }

        [JsonProperty("gongjiri_2019")]
        public int Gongjiri2019 { get; set; }

        [JsonProperty("china_2020")]
        public int China2020 { get; set; }
    }

    public class Params
    {
        [JsonProperty("uid")]
        public long Uid { get; set; }
    }

    public class Button
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sub_type")]
        public int SubType { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }
    }

    public class PostContentResponse
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

        [JsonProperty("reward_exhibition_type")]
        public int RewardExhibitionType { get; set; }

        [JsonProperty("hide_flag")]
        public int HideFlag { get; set; }

        [JsonProperty("mlevel")]
        public int Mlevel { get; set; }

        [JsonProperty("darwin_tags")]
        public List<object> DarwinTags { get; set; }

        [JsonProperty("mblogtype")]
        public int Mblogtype { get; set; }

        [JsonProperty("more_info_type")]
        public int MoreInfoType { get; set; }

        [JsonProperty("cardid")]
        public string Cardid { get; set; }

        [JsonProperty("number_display_strategy")]
        public NumberDisplayStrategy NumberDisplayStrategy { get; set; }

        [JsonProperty("content_auth")]
        public int ContentAuth { get; set; }

        [JsonProperty("hide_hot_flow")]
        public int HideHotFlow { get; set; }

        [JsonProperty("pic_num")]
        public int PicNum { get; set; }

        [JsonProperty("alchemy_params")]
        public AlchemyParams AlchemyParams { get; set; }

        [JsonProperty("pics")]
        public List<Pic> Pics { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }

        [JsonProperty("buttons")]
        public List<Button> Buttons { get; set; }

        [JsonProperty("status_title")]
        public string StatusTitle { get; set; }

        [JsonProperty("ok")]
        public int Ok { get; set; }
    }

    public class Root
    {
        [JsonProperty("ok")]
        public int Ok { get; set; }

        [JsonProperty("data")]
        public PostContentResponse Data { get; set; }
    }


}
