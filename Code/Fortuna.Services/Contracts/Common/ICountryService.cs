using Fortuna.Services.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Contracts.Common
{
    public interface ICountryService
    {
        Task<List<CountryDto>> GetCountriesAsync();

        Task<CountryDto> GetCountryAsync(int countryId);

        Task<CountryDto> SaveAssetTypeAsync(CountryDto countryDto);
    }
}
