using Fortuna.Web.Blazor.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Fortuna.Web.Blazor.Models.Expense;

namespace Fortuna.Web.Blazor.Pages
{
    partial class CreateExpense : ComponentBase
    {
        [Inject] IFortunaAPIService FortunaApiService { get; set; }

        private List<ExpenseTypeDto> ExpenseTypes = new();
        private List<ExpenseItemTypeDto> ExpenseItems = new();
        private List<int> QuantityTypes = new();

        private int selectedExpenseTypeId;
        private int selectedExpenseItemId;
        private int selectedQuantityTypeId;
        private decimal expenseAmount;
        private int quantity;
        private DateTime expenseDate = DateTime.Today;
        private string notes;
        private decimal totalExpenseToday = 0;
        private decimal totalExpenseMonth = 0;
        protected override async Task OnInitializedAsync()
        {
            var assetTypes = await this.FortunaApiService.GetAssetTypesAsync();
            ExpenseTypes = new List<ExpenseTypeDto>();
            ExpenseItems = new List<ExpenseItemTypeDto>();
        }

        private async Task SaveExpense()
        {
            var newExpense = new ExpenseDto
            {
                ExpenseTypeId = selectedExpenseTypeId,
                ExpenseItemId = selectedExpenseItemId,
                ExpenseAmount = expenseAmount,
                QuantityTypeId = selectedQuantityTypeId,
                Quantity = quantity,
            };

            bool success = true;//await FortunaApiService.AddExpenseAsync(newExpense);

            if (success)
            {
                Console.WriteLine("Expense saved successfully!");
                totalExpenseToday += expenseAmount;
                totalExpenseMonth += expenseAmount;
            }
            else
            {
                Console.WriteLine("Error saving expense.");
            }
        }
    }
}
