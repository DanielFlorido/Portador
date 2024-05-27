using Newtonsoft.Json;

namespace Portador.Model
{
    public class Result
    {
        [JsonProperty("address_components")]
        public List<AddressComponent> _addresses {  get; set; }

        [JsonProperty("formatted_address")]
        public string formattedAddresss { get; set; }

        [JsonProperty("geometry")]
        public Geometry geometry { get; set; }

        [JsonProperty("place_id")]
        public string placeId { get; set; }

        [JsonProperty("types")]
        public List<string> types { get; set; }

    }
}
