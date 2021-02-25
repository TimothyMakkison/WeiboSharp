using Newtonsoft.Json;

namespace WeiboSharp.Classes
{
    public class TwoFactorLoginSMS
    {
        [JsonProperty("two_factor_required")]
        public bool TwoFactorRequired { get; set; }

        [JsonProperty("two_factor_info")]
        public InstaTwoFactorLogin TwoFactorInfo { get; set; }
    }
}
