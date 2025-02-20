using AutoMapper;
using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.Entities.Expense;
using Fortuna.Services.Contracts.Expense;
using Fortuna.Services.Models.Expense;

namespace Fortuna.Services.Services.Expense
{
    public class ExpenseTypeService: IExpenseTypeService
    {
        private readonly IExpenseTypeRepository _expenseTypeRepository;
        private readonly IMapper _mapper;

        public ExpenseTypeService(IExpenseTypeRepository expenseTypeRepository, IMapper mapper)
        {
            _expenseTypeRepository = expenseTypeRepository;
            _mapper = mapper;
        }

        public Task<ExpenseTypeDto> GetExpenseTypeAsync(int expenseTypeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ExpenseTypeDto>> GetExpenseTypesAsync()
        {
            var expenseTypes = await this._expenseTypeRepository.GetExpenseTypesAsync();
            return _mapper.Map<List<ExpenseTypeDto>>(expenseTypes);
        }

        public async Task<ExpenseTypeDto> SaveExpenseTypeAsync(ExpenseTypeDto assetTypeDto)
        {
            var expenseTypeEntity = _mapper.Map<ExpenseType>(assetTypeDto);
            var savedEntity = await this._expenseTypeRepository.SaveExpenseTypeAsync(expenseTypeEntity);
            return _mapper.Map<ExpenseTypeDto>(savedEntity);
        }

        public async Task<List<QuantityTypeDto>> GetQuantityTypes()
        {
            var quantityTypes = await this._expenseTypeRepository.GetQuantityTypesAsync();
            return _mapper.Map<List<QuantityTypeDto>>(quantityTypes);
        }

        public async Task<List<StoreDto>> GetStoresAsync()
        {
            var stores = await this._expenseTypeRepository.GetStoresAsync();
            return _mapper.Map<List<StoreDto>>(stores);
        }

    }
}
