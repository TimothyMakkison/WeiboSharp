using System.Collections.Generic;
using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaSendDirectMessageResponse : BaseStatusResponse
    {
        public List<InstaDirectInboxThreadResponse> Threads { get; set; } = new List<InstaDirectInboxThreadResponse>();
    }
}