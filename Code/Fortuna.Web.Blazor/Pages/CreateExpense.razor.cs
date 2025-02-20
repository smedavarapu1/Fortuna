using Fortuna.Web.Blazor.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Fortuna.Web.Blazor.Models.Expense;
using Fortuna.Web.Blazor.Shared.Components;

namespace Fortuna.Web.Blazor.Pages
{
    partial class CreateExpense : BaseComponent
    {
        [Inject] IFortunaAPIService FortunaApiService { get; set; }

        private int selectedExpenseTypeId;
        private int selectedExpenseItemTypeId;
        private int selectedQuantityTypeId;
        private int selectedStoreId;
        private decimal expenseAmount;
        private int quantity;
        private DateTime? expenseDate = DateTime.Today;
        private string notes;
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        private async Task SaveExpense()
        {
            var newExpense = new ExpenseDto
            {
                ExpenseTypeId = selectedExpenseTypeId,
                ExpenseItemTypeId = selectedExpenseItemTypeId,
                ExpenseAmount = expenseAmount,
                QuantityTypeId = selectedQuantityTypeId,
                Quantity = quantity,
                PurchaseDate = expenseDate.Value,
                ExpenseName = "test",
                StoreId = selectedStoreId
            };

            await this.FortunaApiService.SaveExpenseAsync(newExpense);
        }
    }
}
