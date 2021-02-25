using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    public class TabsInfo
    {

        [JsonProperty("selectedTab")]
        public int SelectedTab { get; set; }

        [JsonProperty("tabs")]
        public IList<UserTab> Tabs { get; set; }
    }


}
