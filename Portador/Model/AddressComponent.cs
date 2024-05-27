using Newtonsoft.Json;

namespace Portador.Model
{
    public class AddressComponent
    {
        [JsonProperty("long_name")]
        public string longName {  get; set; }

        [JsonProperty("short_name")]
        public string shortName { get; set; }
        [JsonProperty("types")]
        public List<string> types { get; set; }
    }
}
