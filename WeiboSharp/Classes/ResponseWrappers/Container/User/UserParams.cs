using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    public class UserParams
    {

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("extparams")]
        public UserExtparams Extparams { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }
    }


}
