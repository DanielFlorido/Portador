using Portador.Model;

namespace Portador.Services
{
    public interface IGeoCodeService
    {
        Task<GeoCodeResponse> GetGeoPoint(GeoCodeRequest request);
    }
}
