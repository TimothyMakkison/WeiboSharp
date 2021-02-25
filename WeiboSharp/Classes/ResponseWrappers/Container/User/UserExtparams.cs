using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers.Container
{
    public class UserExtparams
    {

        [JsonProperty("followcardid")]
        public object Followcardid { get; set; }
    }


}
