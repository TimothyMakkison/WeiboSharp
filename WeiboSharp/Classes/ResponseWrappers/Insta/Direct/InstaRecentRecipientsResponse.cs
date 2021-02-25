using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaRecentRecipientsResponse : InstaRecipientsResponse, IInstaRecipientsResponse
    {
        [JsonProperty("recent_recipients")] public RankedRecipientResponse[] RankedRecipients { get; set; }
    }
}