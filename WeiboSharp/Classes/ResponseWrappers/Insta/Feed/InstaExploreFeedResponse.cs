using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaExploreFeedResponse : BaseLoadableResponse
    {
        [JsonIgnore] public InstaExploreItemsResponse Items { get; set; } = new InstaExploreItemsResponse();
        
        [JsonProperty("max_id")] public string MaxId { get; set; }
    }
}