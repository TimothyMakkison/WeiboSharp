using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class Visible
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("list_id")]
        public long ListId { get; set; }
    }
}