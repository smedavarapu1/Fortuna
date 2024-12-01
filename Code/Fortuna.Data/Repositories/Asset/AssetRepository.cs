using AutoMapper;
using Fortuna.Data.Contracts.Asset;
using Fortuna.Data.DbContenxt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Repositories.Asset
{
    public class AssetRepository: BaseRepository, IAssetRepository
    {
        public AssetRepository(FortunaDbContext dbContext, IMapper mapper): base(dbContext, mapper)
        {
            
        }
    }
}
