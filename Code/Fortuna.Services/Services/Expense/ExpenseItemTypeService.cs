using AutoMapper;
using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.Entities.Expense;
using Fortuna.Services.Contracts.Expense;
using Fortuna.Services.Models.Asset;
using Fortuna.Services.Models.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Services.Expense
{
    public class ExpenseItemTypeService : IExpenseItemTypeService
    {
        private readonly IExpenseItemTypeRepository _expenseItemTypeRepository;
        private readonly IMapper _mapper;

        public ExpenseItemTypeService(IExpenseItemTypeRepository expenseItemTypeRepository, IMapper mapper)
        {
            _expenseItemTypeRepository = expenseItemTypeRepository;
            _mapper = mapper;
        }
        public async Task<ExpenseItemTypeDto> GetExpenseItemTypeAsync(int expenseItemTypeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ExpenseItemTypeDto>> GetExpenseItemTypes()
        {
            var expenseTypes = await this._expenseItemTypeRepository.GetExpenseItemTypesAsync();
            return _mapper.Map<List<ExpenseItemTypeDto>>(expenseTypes);
        }

        public async Task<ExpenseItemTypeDto> SaveExpenseItemType(ExpenseItemTypeDto expenseType)
        {
            var expenseTypeEntity = _mapper.Map<ExpenseItemType>(expenseType);
            var savedEntity = await this._expenseItemTypeRepository.SaveExpenseItemTypeAsync(expenseTypeEntity);
            return _mapper.Map<ExpenseItemTypeDto>(savedEntity);
        }
    }
}
