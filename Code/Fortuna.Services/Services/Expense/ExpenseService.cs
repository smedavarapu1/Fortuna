using AutoMapper;
using Fortuna.Data.Contracts.Common;
using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.Entities.Common;
using Fortuna.Services.Contracts.Expense;
using Fortuna.Services.Models.Common;
using Fortuna.Services.Models.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Services.Expense
{
    public class ExpenseService: IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public ExpenseService(IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }

        public async Task<List<ExpenseDto>> GetExpensesAsync()
        {
            var expenses = await _expenseRepository.GetExpensesAsync();
            return _mapper.Map<List<ExpenseDto>>(expenses);
        }

        public async Task<ExpenseDto> GetExpenseAsync(int expenseId)
        {
            var expense = await _expenseRepository.GetExpense(expenseId);
            return _mapper.Map<ExpenseDto>(expense);
        }

        public async Task<ExpenseDto> SaveExpenseAsync(ExpenseDto expenseDto)
        {
            var expense = _mapper.Map<Fortuna.Data.Entities.Expense.Expense>(expenseDto);
            var savedEntity = await _expenseRepository.SaveExpenseAsync(expense);
            return _mapper.Map<ExpenseDto>(savedEntity);
        }
    }
}
