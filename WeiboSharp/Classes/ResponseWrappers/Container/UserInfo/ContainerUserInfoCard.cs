using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class ContainerUserInfoCard
    {
        [JsonProperty("card_type")]
        public int CardType { get; set; }

        [JsonProperty("card_group")]
        public List<ContainerUserInfoCardGroup> CardGroup { get; set; }
    }
}