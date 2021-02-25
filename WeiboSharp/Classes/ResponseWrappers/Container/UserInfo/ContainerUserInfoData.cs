using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ContainerUserInfoData
    {
        [JsonProperty("cards")]
        public List<ContainerUserInfoCard> Cards { get; set; }

        [JsonProperty("cardlistInfo")]
        public ContainerUserInfoCardlistInfo CardlistInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("showAppTips")]
        public int ShowAppTips { get; set; }
    }
}