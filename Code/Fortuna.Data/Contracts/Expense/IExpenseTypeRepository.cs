﻿using Fortuna.Data.Entities.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Contracts.Expense
{
    public interface IExpenseTypeRepository
    {
        Task<List<ExpenseType>> GetExpenseTypesAsync();

        Task<ExpenseType> SaveExpenseTypeAsync(ExpenseType expenseType);
    }
}
