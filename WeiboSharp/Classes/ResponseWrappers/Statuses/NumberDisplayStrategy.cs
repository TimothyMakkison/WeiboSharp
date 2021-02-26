using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class NumberDisplayStrategy
    {
        [JsonProperty("apply_scenario_flag")]
        public int ApplyScenarioFlag { get; set; }

        [JsonProperty("display_text_min_number")]
        public int DisplayTextMinNumber { get; set; }

        [JsonProperty("display_text")]
        public string DisplayText { get; set; }
    }


}
