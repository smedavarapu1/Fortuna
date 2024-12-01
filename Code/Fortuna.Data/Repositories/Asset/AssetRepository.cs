using AutoMapper;
using Fortuna.Data.Contracts.Asset;
using Fortuna.Data.DbContenxt;
using Microsoft.EntityFrameworkCore;

namespace Fortuna.Data.Repositories.Asset
{
    public class AssetRepository: BaseRepository, IAssetRepository
    {
        public AssetRepository(FortunaDbContext dbContext, IMapper mapper): base(dbContext, mapper)
        {
            
        }

        /// <summary>
        /// Retrieves a single asset by its ID.
        /// </summary>
        /// <param name="assetId">The ID of the asset.</param>
        /// <returns>The asset with the specified ID, or null if not found.</returns>
        public async Task<Entities.Asset.Asset> GetAssetByAssetIdAsync(int assetId)
        {
            return await _dbContext.Set<Entities.Asset.Asset>()
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.AssetId == assetId);
        }

        /// <summary>
        /// Retrieves all assets from the database.
        /// </summary>
        /// <returns>A list of all assets.</returns>
        public async Task<List<Entities.Asset.Asset>> GetAssetsAsync()
        {
            return await _dbContext.Set<Entities.Asset.Asset>()
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Saves or updates the given asset in the database.
        /// </summary>
        /// <param name="asset">The asset to save or update.</param>
        /// <returns>The saved or updated asset.</returns>
        public async Task<Entities.Asset.Asset> SaveAssetAsync(Entities.Asset.Asset asset)
        {
            await SaveAsync(asset); // Use BaseRepository SaveAsync method
            return asset;
        }
    }
}
