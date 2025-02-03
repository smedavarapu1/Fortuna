using AutoMapper;
using Fortuna.Data.Contracts.Common;
using Fortuna.Data.DbContenxt;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Repositories.Common
{
    public class CountryRepository: BaseRepository, ICountryRepository
    {
        public CountryRepository(FortunaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            
        }

        public async Task<Entities.Common.Country> GetCountryAsync(int countryId)
        {
            return await _dbContext.Set<Entities.Common.Country>()
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.CountryId == countryId);
        }

        public async Task<List<Entities.Common.Country>> GetCountriesAsync()
        {
            return await _dbContext.Set<Entities.Common.Country>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Entities.Common.Country> SaveCountryAsync(Entities.Common.Country country)
        {
            await SaveAsync(country);
            return country;
        }
    }
}
