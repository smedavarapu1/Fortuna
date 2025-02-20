using Fortuna.Services.Contracts.Asset;
using Fortuna.Services.Contracts.Expense;
using Fortuna.Services.Models.Expense;
using Fortuna.Services.Services.Asset;
using Microsoft.AspNetCore.Mvc;

namespace Fortuna.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController: ControllerBase
    {
        private readonly IExpenseService ExpenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            this.ExpenseService = expenseService;
        }


        [HttpPost("save")]
        public async Task<ActionResult<ExpenseDto>> SaveAssetTypeAsync([FromBody] ExpenseDto expense)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savedAssetType = await this.ExpenseService.SaveExpenseAsync(expense);

            return Ok(savedAssetType);
        }
    }
}
