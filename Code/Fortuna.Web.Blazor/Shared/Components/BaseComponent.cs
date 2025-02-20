using Fortuna.Web.Blazor.Models.Asset;
using Fortuna.Web.Blazor.Models.Expense;
using Fortuna.Web.Blazor.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Fortuna.Web.Blazor.Shared.Components
{
    public class BaseComponent : ComponentBase
    {
        [Inject] IFortunaAPIService FortunaApiService { get; set; }

        protected List<AssetTypeDto> AssetTypes { get; private set; } = new();
        protected List<ExpenseTypeDto> ExpenseTypes { get; private set; } = new();
        protected List<ExpenseItemTypeDto> ExpenseItemTypes { get; private set; } = new();
        protected List<StoreDto> StoreTypes { get; private set; } = new();
        protected List<QuantityTypeDto> QuantityTypes { get; private set; } = new();

        protected override async Task OnInitializedAsync()
        {
            this.AssetTypes = await FortunaApiService.GetAssetTypesAsync();
            this.ExpenseTypes = await FortunaApiService.GetExpenseTypesAsync();
            this.ExpenseItemTypes = await FortunaApiService.GetExpenseItemTypes();
            this.StoreTypes = await FortunaApiService.GetStoresAsync();
            this.QuantityTypes = await this.FortunaApiService.GetQuantityTypesAsync();
        }
    }
}
