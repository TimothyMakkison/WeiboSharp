using System.Collections.Generic;
using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaMediaListResponse : BaseLoadableResponse
    {
        [JsonProperty("items")]
        public List<InstaMediaItemResponse> Medias { get; set; } = new List<InstaMediaItemResponse>();

        public List<InstaStoryResponse> Stories { get; set; } = new List<InstaStoryResponse>();
    }
}