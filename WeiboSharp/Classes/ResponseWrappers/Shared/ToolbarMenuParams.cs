namespace WeiboSharp.Classes.ResponseWrappers
{
    using Newtonsoft.Json;

    public partial class ToolbarMenuParams
    {
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Uid { get; set; }

        [JsonProperty("extparams", NullValueHandling = NullValueHandling.Ignore)]
        public Extparams Extparams { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Scheme { get; set; }
    }


}