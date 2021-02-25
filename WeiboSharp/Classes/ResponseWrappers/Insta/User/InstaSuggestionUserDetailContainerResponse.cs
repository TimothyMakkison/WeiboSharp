using WeiboSharp.Classes.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaSuggestionUserDetailContainerResponse : InstaDefault
    {
        [JsonProperty("items")]
        public InstaSuggestionItemListResponse Items { get; set; } = new InstaSuggestionItemListResponse();
    }
}
