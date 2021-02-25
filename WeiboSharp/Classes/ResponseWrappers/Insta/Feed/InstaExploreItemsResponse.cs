using System.Collections.Generic;
using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaExploreItemsResponse : BaseLoadableResponse
    {
        [JsonIgnore] public InstaStoryTrayResponse StoryTray { get; set; } = new InstaStoryTrayResponse();

        [JsonIgnore] public List<InstaMediaItemResponse> Medias { get; set; } = new List<InstaMediaItemResponse>();

        [JsonIgnore] public InstaChannelResponse Channel { get; set; }
    }
}