using Fortuna.Services.Models.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Contracts.Expense
{
    public interface IExpenseService
    {
        Task<ExpenseDto> GetExpenseAsync(int expenseId);

        Task<List<ExpenseDto>> GetExpensesAsync();

        Task<ExpenseDto> SaveExpenseAsync(ExpenseDto expense);
    }
}
