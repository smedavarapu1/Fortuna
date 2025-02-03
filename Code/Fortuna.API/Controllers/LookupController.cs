﻿using Microsoft.AspNetCore.Mvc;
using Fortuna.Services.Models;
using Fortuna.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fortuna.Services.Contracts.Asset;
using Fortuna.Services.Models.Asset;

namespace Fortuna.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LookupController : ControllerBase
    {
        private readonly IAssetTypeService _assetTypeService;

        public LookupController(IAssetTypeService assetTypeService)
        {
            _assetTypeService = assetTypeService;
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
    }
}
