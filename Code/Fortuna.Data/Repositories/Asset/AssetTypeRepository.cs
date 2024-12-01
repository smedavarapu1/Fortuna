using AutoMapper;
using Fortuna.Data.Contracts.Asset;
using Fortuna.Data.DbContenxt;
using Fortuna.Data.Entities.Asset;
using Microsoft.EntityFrameworkCore;

namespace Fortuna.Data.Repositories.Asset
{
    public class AssetTypeRepository: BaseRepository, IAssetTypeRepository
    {
        public AssetTypeRepository(FortunaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            
        }

        public async Task<List<AssetType>> GetAssetTypesAsync()
        {
            return await _dbContext.Set<AssetType>()
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<AssetType> SaveAssetTypeAsync(AssetType assetType)
        {
            await this.SaveAsync(assetType);
            return assetType;
        }
    }
}
