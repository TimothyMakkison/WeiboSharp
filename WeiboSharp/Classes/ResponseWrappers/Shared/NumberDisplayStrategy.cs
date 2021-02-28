using Newtonsoft.Json;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public partial class NumberDisplayStrategy
    {
        [JsonProperty("apply_scenario_flag")]
        public long ApplyScenarioFlag { get; set; }

        [JsonProperty("display_text_min_number")]
        public long DisplayTextMinNumber { get; set; }

        [JsonProperty("display_text")]
        public string DisplayText { get; set; }
    }
}