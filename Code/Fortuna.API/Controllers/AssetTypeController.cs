using Fortuna.Services.Contracts.Asset;
using Fortuna.Services.Models.Asset;
using Microsoft.AspNetCore.Mvc;

namespace Fortuna.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetTypeController : ControllerBase
    {
        private readonly IAssetTypeService _assetTypeService;

        public AssetTypeController(IAssetTypeService assetTypeService)
        {
            _assetTypeService = assetTypeService;
        }

        /// <summary>
        /// Saves or updates an asset type.
        /// </summary>
        /// <param name="assetTypeDto">The asset type DTO to save.</param>
        /// <returns>The saved or updated asset type DTO.</returns>
        [HttpPost("save/assettype")]
        public async Task<ActionResult<AssetTypeDto>> SaveAssetTypeAsync([FromBody] AssetTypeDto assetTypeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savedAssetType = await _assetTypeService.SaveAssetTypeAsync(assetTypeDto);

            return Ok(savedAssetType);
        }
    }
}
