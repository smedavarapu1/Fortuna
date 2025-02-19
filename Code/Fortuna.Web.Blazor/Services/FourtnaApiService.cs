using Fortuna.Web.Blazor.Models.Asset;
using Fortuna.Web.Blazor.Services.Contracts;

namespace Fortuna.Web.Blazor.Services
{
    public class FourtnaApiService : IFortunaAPIService
    {
        private readonly HttpClient _httpClient;

        public FourtnaApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("FortunaApi");
        }

        /// <summary>
        /// Retrieves all asset types from the API.
        /// </summary>
        /// <returns>A list of AssetTypeDto.</returns>
        public async Task<List<AssetTypeDto>> GetAssetTypesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/lookup/assettypes");

                if (!response.IsSuccessStatusCode)
                {
                    // Handle non-success status codes (e.g., 404, 500)
                    return new List<AssetTypeDto>();
                }

                return await response.Content.ReadFromJsonAsync<List<AssetTypeDto>>() ?? new List<AssetTypeDto>();
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                Console.WriteLine($"Error fetching asset types: {ex.Message}");
                return new List<AssetTypeDto>();
            }
        }
    }
}
