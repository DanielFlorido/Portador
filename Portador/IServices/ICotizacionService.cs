using Portador.Model.dto;

namespace Portador.Services
{
    public interface ICotizacionService
    {
        Task<DatosCotizacion> Cotizar(DatosCotizacion datos);
    }
}
