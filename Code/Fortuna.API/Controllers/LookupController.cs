using Fortuna.Services.Contracts.Asset;
using Fortuna.Services.Contracts.Expense;
using Fortuna.Services.Models.Asset;
using Fortuna.Services.Models.Expense;
using Microsoft.AspNetCore.Mvc;

namespace Fortuna.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LookupController : ControllerBase
    {
        private readonly IAssetTypeService _assetTypeService;
        private readonly IExpenseTypeService expenseTypeService;
        private readonly IExpenseItemTypeService expenseItemTypeService;

        public LookupController(IAssetTypeService assetTypeService, IExpenseTypeService expenseTypeService, IExpenseItemTypeService expenseItemTypeService)
        {
            this._assetTypeService = assetTypeService;
            this.expenseTypeService = expenseTypeService;
            this.expenseItemTypeService = expenseItemTypeService;
        }

        /// <summary>
        /// Retrieves all asset types.
        /// </summary>
        /// <returns>A list of asset type DTOs.</returns>
        [HttpGet("assettypes")]
        public async Task<ActionResult<List<AssetTypeDto>>> GetAssetTypesAsync()
        {
            var assetTypes = await _assetTypeService.GetAssetTypesAsync();

            if (assetTypes == null || assetTypes.Count == 0)
            {
                return NotFound("No asset types found.");
            }

            return Ok(assetTypes);
        }

        [HttpGet("expensetypes")]
        public async Task<ActionResult<List<AssetTypeDto>>> GetExpenseTypesAsync()
        {
            var expenseTypes = await this.expenseTypeService.GetExpenseTypesAsync();

            if (expenseTypes == null || expenseTypes.Count == 0)
            {
                return NotFound("No asset types found.");
            }

            return Ok(expenseTypes);
        }

        [HttpGet("quantitytypes")]
        public async Task<ActionResult<List<QuantityTypeDto>>> GetQuantityTypesAsync()
        {
            var quantityTypes = await this.expenseTypeService.GetQuantityTypes();

            if (quantityTypes == null || quantityTypes.Count == 0)
            {
                return NotFound("No Quantity types found.");
            }

            return Ok(quantityTypes);
        }

        [HttpGet("stores")]
        public async Task<ActionResult<List<StoreDto>>> GetStoresAsync()
        {
            var stores = await this.expenseTypeService.GetStoresAsync();

            if (stores == null || stores.Count == 0)
            {
                return NotFound("No stores found.");
            }

            return Ok(stores);
        }

        [HttpGet("expenseItemTypes")]
        public async Task<ActionResult<List<ExpenseItemTypeDto>>> GetExpenseItemTypesAsync()
        {
            var expenseItemTypes = await this.expenseItemTypeService.GetExpenseItemTypes();

            if (expenseItemTypes == null || expenseItemTypes.Count == 0)
            {
                return NotFound("No expense item types found.");
            }

            return Ok(expenseItemTypes);
        }
    }
}
