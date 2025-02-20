using Fortuna.Web.Blazor.Models.Asset;
using Fortuna.Web.Blazor.Models.Expense;

namespace Fortuna.Web.Blazor.Services.Contracts
{
    public interface IFortunaAPIService
    {
        Task<List<AssetTypeDto>> GetAssetTypesAsync();

        Task<List<ExpenseTypeDto>> GetExpenseTypesAsync();

        Task<List<QuantityTypeDto>> GetQuantityTypesAsync();

        Task<List<StoreDto>> GetStoresAsync();

        Task<List<ExpenseItemTypeDto>> GetExpenseItemTypes();

        Task<ExpenseDto> SaveExpenseAsync(ExpenseDto expense);
    }
}
