using Fortuna.Data.Entities.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Contracts.Asset
{
    public interface IAssetTypeRepository
    {
        Task<List<AssetType>> GetAssetTypesAsync();

        Task<AssetType> SaveAssetTypeAsync(AssetType assetType);
    }
}
