using Portador.Model;
using Portador.Model.dto;

namespace Portador.Services
{
    public class CotizacionService : ICotizacionService
    {
        private readonly IGeoCodeService _geoCodeService;
        public CotizacionService(IGeoCodeService geoCodeService)
        {
            _geoCodeService = geoCodeService;
        }

        async Task<DatosCotizacion> ICotizacionService.Cotizar(DatosCotizacion datos)
        {
            Cotizacion cotizacion = new Cotizacion(datos.DireccionEnvio, datos.DireccionEntrega, datos.NumProductos);
            double distancia = await CalcularDistancia(datos);
            cotizacion.Distancia = distancia;
            double costoTotal = cotizacion.CostoPerKilometro * distancia + cotizacion.CostoPerProducto * cotizacion.NumProductos;
            cotizacion.CostoTotal = costoTotal;
            return cotizacion;
        }
        private async Task<double> CalcularDistancia(DatosCotizacion datosCotizacion)
        {
            GeoCodeResponse geo1 = await _geoCodeService.GetGeoPoint(new GeoCodeRequest(datosCotizacion.DireccionEnvio));
            GeoCodeResponse geo2 = await _geoCodeService.GetGeoPoint(new GeoCodeRequest(datosCotizacion.DireccionEntrega));
            Location locationEntrega = geo1.Result[0].geometry.Location;
            Location locationEnvio =  geo2.Result[0].geometry.Location;

            double distancia = GetDistanceBetweenPointsNew(locationEntrega.Lat, locationEntrega.Lng, locationEnvio.Lat, locationEnvio.Lng, "kilometers");
            return distancia;
        }

        public double GetDistanceBetweenPointsNew(double latitude1, double longitude1, double latitude2, double longitude2, string unit)
        {
            double theta = longitude1 - longitude2;
            double distance = 60 * 1.1515 * (180 / Math.PI) * Math.Acos(
                Math.Sin(latitude1 * (Math.PI / 180)) * Math.Sin(latitude2 * (Math.PI / 180)) +
                Math.Cos(latitude1 * (Math.PI / 180)) * Math.Cos(latitude2 * (Math.PI / 180)) * Math.Cos(theta * (Math.PI / 180))
            );
            if (unit.Equals("miles"))
            {
                return Math.Round(distance);
            }
            else if (unit.Equals("kilometers"))
            {
                return Math.Round(distance * 1.609344);
            }
            else
            {
                return 0;
            }
        }
    }
}
