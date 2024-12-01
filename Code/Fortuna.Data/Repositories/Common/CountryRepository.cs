using AutoMapper;
using Fortuna.Data.Contracts.Common;
using Fortuna.Data.DbContenxt;
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
    }
}
