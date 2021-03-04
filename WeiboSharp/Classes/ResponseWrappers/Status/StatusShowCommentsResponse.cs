using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class StatusShowCommentsResponse
    {
        [JsonProperty("data")]
        public List<FluffyDatum> Data { get; set; }

        [JsonProperty("total_number")]
        public long TotalNumber { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }
    }

    public partial class FluffyDatum
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("user")]
        public TentacledUser User { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("like_counts")]
        public long LikeCounts { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("reply_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplyId { get; set; }

        [JsonProperty("reply_text", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplyText { get; set; }
    }

    public partial class TentacledUser
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("profile_image_url")]
        public Uri ProfileImageUrl { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("verified_type")]
        public long VerifiedType { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("mbtype")]
        public long Mbtype { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("follow_me")]
        public bool FollowMe { get; set; }

        [JsonProperty("verified_type_ext", NullValueHandling = NullValueHandling.Ignore)]
        public long? VerifiedTypeExt { get; set; }
    }
}