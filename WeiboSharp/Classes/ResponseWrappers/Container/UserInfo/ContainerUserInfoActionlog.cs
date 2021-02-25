using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ContainerUserInfoActionlog
    {
        [JsonProperty("act_code")]
        public string ActCode { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("fid")]
        public string Fid { get; set; }

        [JsonProperty("cardid")]
        public string Cardid { get; set; }

        [JsonProperty("uicode")]
        public string Uicode { get; set; }
    }
}