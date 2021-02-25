using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ContainerUserInfoParams
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }
    }
}