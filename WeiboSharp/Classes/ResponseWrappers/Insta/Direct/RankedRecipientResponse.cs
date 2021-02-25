using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class RankedRecipientResponse
    {
        [JsonProperty("thread")] public RankedRecipientThreadResponse Thread { get; set; }

        [JsonProperty("user")] public InstaUserShortResponse User { get; set; }
    }
}