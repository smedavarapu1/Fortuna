using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Contracts.Expense
{
    public interface IExpenseItemTypeRepository
    {
        Task<Entities.Expense.ExpenseItemType> GetExpenseItemTypeAsync(int expenseTypeId);

        Task<List<Entities.Expense.ExpenseItemType>> GetExpenseItemTypesAsync();

        Task<Entities.Expense.ExpenseItemType> SaveExpenseItemTypeAsync(Entities.Expense.ExpenseItemType expenseType);
    }
}
