namespace Portador.Model.dto
{
    public class Cotizacion : DatosCotizacion
    {
        public double Distancia { get; set; } = 0;
        public double CostoTotal { get; set; } = 0;
        public double CostoPerProducto { get; set; } = 1000.0;
        public double CostoPerKilometro { get; set; } = 2000.0;

        public Cotizacion(string direccionEnvio, string direccionEntrega, int numProductos)
            : base(direccionEnvio, direccionEntrega, numProductos)
        {
        }
    }
}
