using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class AlchemyParams
    {
        [JsonProperty("ug_red_envelope")]
        public bool UgRedEnvelope { get; set; }
    }
}