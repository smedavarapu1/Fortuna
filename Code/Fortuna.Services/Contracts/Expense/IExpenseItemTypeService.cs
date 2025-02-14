using Fortuna.Services.Models.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Contracts.Expense
{
    public interface IExpenseItemTypeService
    {
        Task<ExpenseItemTypeDto> GetExpenseItemTypeAsync(int expenseItemTypeId);

        Task<List<ExpenseItemTypeDto>> GetExpenseItemTypes();

        Task<ExpenseItemTypeDto> SaveExpenseItemType(ExpenseItemTypeDto expenseType);
    }
}
