using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Contracts.Expense
{
    public interface IExpenseRepository
    {
        Task<Entities.Expense.Expense> GetExpense(int expenseId);

        Task<List<Entities.Expense.Expense>> GetExpensesAsync();

        Task<Entities.Expense.Expense> SaveExpenseAsync(Entities.Expense.Expense expense);
    }
}
