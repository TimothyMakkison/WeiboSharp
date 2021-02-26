using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Visible
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }
    }
}