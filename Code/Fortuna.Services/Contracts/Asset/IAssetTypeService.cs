using Fortuna.Services.Models.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Contracts.Asset
{
    public interface IAssetTypeService
    {
        Task<List<AssetTypeDto>> GetAssetTypesAsync();

        Task<AssetTypeDto> SaveAssetTypeAsync(AssetTypeDto assetTypeDto);
    }
}
