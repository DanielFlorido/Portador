using Newtonsoft.Json;

namespace Portador.Model.dto
{
    public class DatosCotizacion
    {
        [JsonProperty("direccion_envio")]
        public string DireccionEnvio { get; set; }

        [JsonProperty("direccion_entrega")]
        public string DireccionEntrega { get; set; }

        [JsonProperty("numero_productos")]
        public int NumProductos { get; set; }

        public DatosCotizacion(string direccionEnvio, string direccionEntrega, int numProductos)
        {
            DireccionEnvio = direccionEnvio;
            DireccionEntrega = direccionEntrega;
            NumProductos = numProductos;
        }
    }
}
