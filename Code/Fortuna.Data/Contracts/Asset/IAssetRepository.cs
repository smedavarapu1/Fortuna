using Fortuna.Data.Entities.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Contracts.Asset
{
    public interface IAssetRepository
    {
        Task<List<Entities.Asset.Asset>> GetAssetsAsync();

        Task<Entities.Asset.Asset> GetAssetByAssetIdAsync(int assetId);

        Task<Entities.Asset.Asset> SaveAssetAsync(Entities.Asset.Asset asset);
    }
}
