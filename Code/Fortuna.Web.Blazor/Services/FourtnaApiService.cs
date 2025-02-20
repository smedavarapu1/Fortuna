using Fortuna.Web.Blazor.Models.Asset;
using Fortuna.Web.Blazor.Models.Expense;
using Fortuna.Web.Blazor.Services.Contracts;
using MudBlazor;

namespace Fortuna.Web.Blazor.Services
{
    public class FortunaApiService : IFortunaAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly ISnackbar _snackbar;

        public FortunaApiService(IHttpClientFactory httpClientFactory, ISnackbar snackbar)
        {
            _httpClient = httpClientFactory.CreateClient("FortunaApi");
            _snackbar = snackbar;
        }

        /// <summary>
        /// Retrieves all asset types from the API.
        /// </summary>
        /// <returns>A list of AssetTypeDto.</returns>
        public async Task<List<AssetTypeDto>> GetAssetTypesAsync()
        {
            return await FetchDataAsync<List<AssetTypeDto>>("api/lookup/assettypes");
        }

        /// <summary>
        /// Retrieves all expense types from the API.
        /// </summary>
        /// <returns>A list of ExpenseTypeDto.</returns>
        public async Task<List<ExpenseTypeDto>> GetExpenseTypesAsync()
        {
            return await FetchDataAsync<List<ExpenseTypeDto>>("api/lookup/expensetypes");
        }

        /// <summary>
        /// Retrieves all quantity types from the API.
        /// </summary>
        /// <returns>A list of QuantityTypeDto.</returns>
        public async Task<List<QuantityTypeDto>> GetQuantityTypesAsync()
        {
            return await FetchDataAsync<List<QuantityTypeDto>>("api/lookup/quantitytypes");
        }

        /// <summary>
        /// Retrieves all stores from the API.
        /// </summary>
        /// <returns>A list of StoreDto.</returns>
        public async Task<List<StoreDto>> GetStoresAsync()
        {
            return await FetchDataAsync<List<StoreDto>>("api/lookup/stores");
        }

        /// <summary>
        /// Retrieves all expenseItemTyeps from the API.
        /// </summary>
        /// <returns>A list of expenseItemTyeps.</returns>
        public async Task<List<ExpenseItemTypeDto>> GetExpenseItemTypes()
        {
            return await FetchDataAsync<List<ExpenseItemTypeDto>>("api/lookup/expenseItemTypes");
        }

        /// <summary>
        /// Saves the expense.
        /// </summary>
        /// <param name="expense">Expense.</param>
        /// <returns>Saved expense</returns>
        public async Task<ExpenseDto> SaveExpenseAsync(ExpenseDto expense)
        {
            var result = await SaveDataAsync<ExpenseDto, ExpenseDto>("api/expense/save", expense);

            if (result != null)
            {
                _snackbar.Add("Expense saved successfully!", Severity.Success);
            }
            else
            {
                _snackbar.Add("Failed to save expense.", Severity.Error);
            }

            return result;
        }

        /// <summary>
        /// Helper method to fetch data from API endpoints.
        /// </summary>
        /// <typeparam name="T">The type of data to retrieve.</typeparam>
        /// <param name="url">API endpoint URL.</param>
        /// <returns>A deserialized response object of type T.</returns>
        private async Task<T> FetchDataAsync<T>(string url) where T : new()
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return new T();
                }

                return await response.Content.ReadFromJsonAsync<T>() ?? new T();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data from {url}: {ex.Message}");
                return new T();
            }
        }

        /// <summary>
        /// Generic method to save data via POST request.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request object.</typeparam>
        /// <typeparam name="TResponse">The type of the response object.</typeparam>
        /// <param name="url">API endpoint URL.</param>
        /// <param name="request">The object to send in the request body.</param>
        /// <returns>The response object of type TResponse.</returns>
        public async Task<TResponse> SaveDataAsync<TRequest, TResponse>(string url, TRequest request) where TResponse : new()
        {
            try
            {
                Console.WriteLine($"Calling API: {url}");
                var response = await _httpClient.PostAsJsonAsync(url, request);
                Console.WriteLine("Sending JSON:");
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(request));

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"API Call Failed: {response.StatusCode}, Response: {errorContent}");
                    return new TResponse();
                }

                return await response.Content.ReadFromJsonAsync<TResponse>() ?? new TResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception calling {url}: {ex.Message}");
                return new TResponse();
            }
        }
    }
}
