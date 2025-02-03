using AutoMapper;
using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.DbContenxt;
using Fortuna.Data.Entities.Asset;
using Fortuna.Data.Entities.Expense;
using Microsoft.EntityFrameworkCore;

namespace Fortuna.Data.Repositories.Expense
{
    public class ExpenseTypeRepository: BaseRepository, IExpenseTypeRepository
    {
        public ExpenseTypeRepository(FortunaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        { 
        
        }

        public async Task<List<ExpenseType>> GetExpenseTypesAsync()
        {
            return await _dbContext.Set<ExpenseType>()
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<ExpenseType> SaveExpenseTypeAsync(ExpenseType expenseType)
        {
            await this.SaveAsync(expenseType);
            return expenseType;
        }
    }
}
