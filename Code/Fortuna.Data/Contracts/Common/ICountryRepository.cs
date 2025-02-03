using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Contracts.Common
{
    public interface ICountryRepository
    {
        Task<Entities.Common.Country> GetCountryAsync(int countryId);

        Task<List<Entities.Common.Country>> GetCountriesAsync();

        Task<Entities.Common.Country> SaveCountryAsync(Entities.Common.Country country);
    }
}
