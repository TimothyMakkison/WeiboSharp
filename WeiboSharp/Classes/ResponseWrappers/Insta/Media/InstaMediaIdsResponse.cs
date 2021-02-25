/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */
using WeiboSharp.Classes.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class InstaMediaIdsResponse : InstaDefault
    {
        [JsonProperty("media_ids")] public InstaMediaIdList MediaIds = new InstaMediaIdList();        
    }
}
