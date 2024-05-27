using Newtonsoft.Json;

namespace Portador.Model
{
    public class ViewPort
    {
        [JsonProperty("northeast")]
        public Location Northeast { get; set; }

        [JsonProperty("southwest")]
        public Location Southwest { get; set; }
    }
}
