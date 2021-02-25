using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ContainerUserInfoCardlistMenu
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("params")]
        public ContainerUserInfoParams Params { get; set; }
    }
}