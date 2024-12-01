using AutoMapper;
using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.DbContenxt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Repositories.Expense
{
    public class ExpenseRepository: BaseRepository, IExpenseRepository
    {
        public ExpenseRepository(FortunaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            
        }
    }
}
