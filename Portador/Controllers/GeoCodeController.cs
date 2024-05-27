using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portador.Model;
using Portador.Model.dto;
using Portador.Services;

namespace Portador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoCodeController : ControllerBase
    {
        private readonly IGeoCodeService _geocodeService;
        private readonly ICotizacionService _cotizacionService;

        public GeoCodeController(IGeoCodeService geocodeService, ICotizacionService cotizacionService )
        {
            _geocodeService = geocodeService;
            _cotizacionService = cotizacionService;
        }

        [HttpGet("getgeocode")]
        public async Task<ActionResult<GeoCodeResponse>> GetGeocode([FromQuery] string direccion)
        {
            var geocodeRequest = new GeoCodeRequest(direccion);
            GeoCodeResponse response = await _geocodeService.GetGeoPoint(geocodeRequest);
            return(Ok(response));
        }

        [HttpPost("cotizacion")]
        public async Task<ActionResult<DatosCotizacion>> getCotizacion([FromBody] DatosCotizacion datosCotizacion)
        {
            DatosCotizacion respomse = await _cotizacionService.Cotizar(datosCotizacion);
            return (Ok(respomse));
        }
    }
}
