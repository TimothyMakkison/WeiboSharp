using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaRankedRecipientsResponse : InstaRecipientsResponse, IInstaRecipientsResponse
    {
        [JsonProperty("ranked_recipients")] public RankedRecipientResponse[] RankedRecipients { get; set; }
    }
}