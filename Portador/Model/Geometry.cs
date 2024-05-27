using Newtonsoft.Json;

namespace Portador.Model
{
    public class Geometry
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        [JsonProperty("viewport")]
        public ViewPort Viewport { get; set; }
    }
}
