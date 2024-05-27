using Newtonsoft.Json;
using Portador.Model;
namespace Portador.Services
{
    public class GeoCodeService : IGeoCodeService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://api.distancematrix.ai/maps/api/geocode/json";

        public GeoCodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        async Task<GeoCodeResponse> IGeoCodeService.GetGeoPoint(GeoCodeRequest request)
        {
            var parameters = request.ToDictionary();
            var builder = new UriBuilder(_baseUrl);
            var query = System.Web.HttpUtility.ParseQueryString(builder.Query);

            foreach (var param in parameters)
            {
                query[param.Key] = param.Value;
            }

            builder.Query = query.ToString();
            var uri = builder.ToString();

            var response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GeoCodeResponse>(content);
            }
            else
            {
                throw new HttpRequestException($"Failed to retrieve geocode data: {response.StatusCode}");
            }
        }
    }
}
