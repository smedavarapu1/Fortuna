using Fortuna.Services.Models.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Contracts.Expense
{
    public interface IExpenseTypeService
    {
        Task<ExpenseTypeDto> GetExpenseTypeAsync(int expenseTypeId);

        Task<List<ExpenseTypeDto>> GetExpenseTypesAsync();

        Task<ExpenseTypeDto> SaveExpenseTypeAsync(ExpenseTypeDto expenseType);

        Task<List<QuantityTypeDto>> GetQuantityTypes();

        Task<List<StoreDto>> GetStoresAsync();
    }
}
