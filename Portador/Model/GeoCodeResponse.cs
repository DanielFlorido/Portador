using Newtonsoft.Json;

namespace Portador.Model
{
    public class GeoCodeResponse
    {
        [JsonProperty("result")]
        public List<Result> Result { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
