using AutoMapper;
using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.DbContenxt;
using Microsoft.EntityFrameworkCore;

namespace Fortuna.Data.Repositories.Expense
{
    public class ExpenseRepository: BaseRepository, IExpenseRepository
    {
        public ExpenseRepository(FortunaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            
        }

        public async Task<Entities.Expense.Expense> GetExpense(int expenseId)
        {
            return await _dbContext.Set<Entities.Expense.Expense>()
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.ExpenseId == expenseId);
        }

        public async Task<List<Entities.Expense.Expense>> GetExpensesAsync()
        {
            return await _dbContext.Set<Entities.Expense.Expense>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Entities.Expense.Expense> SaveExpenseAsync(Entities.Expense.Expense asset)
        {
            await SaveAsync(asset); // Use BaseRepository SaveAsync method
            return asset;
        }
    }
}
