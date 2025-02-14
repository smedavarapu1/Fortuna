using Fortuna.Services.Contracts.Common;
using Fortuna.Services.Models.Asset;
using Microsoft.AspNetCore.Mvc;

namespace Fortuna.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            this._countryService = countryService;
        }

        [HttpGet("countries")]
        public async Task<ActionResult<List<AssetTypeDto>>> GetCountriesAsync()
        {
            var countries = await this._countryService.GetCountriesAsync();

            if (countries == null || countries.Count == 0)
            {
                return NotFound("No asset types found.");
            }

            return Ok(countries);
        }
    }
}
