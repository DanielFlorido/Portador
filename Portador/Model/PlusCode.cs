using Newtonsoft.Json;

namespace Portador.Model
{
    public class PlusCode
    {
        [JsonProperty("compound_code")]
        public string compoundCode { get; set; }
        [JsonProperty("global_code")]
        public string globalCode { get; set; }
    }
}
