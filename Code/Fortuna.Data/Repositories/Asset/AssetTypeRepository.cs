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
            // Check if the entity is new or existing
            if (assetType.AssetTypeId == 0)
            {
                // New entity
                _dbContext.AssetType.Add(assetType);
            }
            else
            {
                // Existing entity, ensure it is tracked and considered for update
                _dbContext.AssetType.Update(assetType);
            }

            // Save changes to the database
            await _dbContext.SaveChangesAsync();
            return assetType;
        }
    }
}
