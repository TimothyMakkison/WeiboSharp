using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class DeleteResponse : BaseStatusResponse
    {
        [JsonProperty("did_delete")] public bool IsDeleted { get; set; }
    }
}