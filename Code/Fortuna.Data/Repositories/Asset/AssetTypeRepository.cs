using AutoMapper;
using Fortuna.Data.Contracts.Asset;
using Fortuna.Data.DbContenxt;

namespace Fortuna.Data.Repositories.Asset
{
    public class AssetTypeRepository: BaseRepository, IAssetTypeRepository
    {
        public AssetTypeRepository(FortunaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            
        }
    }
}
