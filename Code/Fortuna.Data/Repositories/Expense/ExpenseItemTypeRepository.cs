using AutoMapper;
using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.DbContenxt;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Repositories.Expense
{
    public class ExpenseItemTypeRepository: BaseRepository, IExpenseItemTypeRepository
    {
        public ExpenseItemTypeRepository(FortunaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            
        }

        public async Task<Entities.Expense.ExpenseItemType> GetExpenseItemTypeAsync(int expensItemTypeId)
        {
            return await _dbContext.Set<Entities.Expense.ExpenseItemType>()
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.ExpenseItemTypeId == expensItemTypeId);
        }

        public async Task<List<Entities.Expense.ExpenseItemType>> GetExpenseItemTypesAsync()
        {
            return await _dbContext.Set<Entities.Expense.ExpenseItemType>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Entities.Expense.ExpenseItemType> SaveExpenseItemTypeAsync(Entities.Expense.ExpenseItemType expenseItemType)
        {
            await SaveAsync(expenseItemType);
            return expenseItemType;
        }
    }
}
