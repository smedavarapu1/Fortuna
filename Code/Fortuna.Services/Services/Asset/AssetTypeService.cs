using AutoMapper;
using Fortuna.Data.Contracts.Asset;
using Fortuna.Data.Entities.Asset;
using Fortuna.Services.Contracts.Asset;
using Fortuna.Services.Models.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Services.Asset
{
    public class AssetTypeService: IAssetTypeService
    {
        private readonly IAssetTypeRepository _assetTypeRepository;
        private readonly IMapper _mapper;

        public AssetTypeService(IAssetTypeRepository assetTypeRepository, IMapper mapper)
        {
            _assetTypeRepository = assetTypeRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves all asset types.
        /// </summary>
        /// <returns>A list of asset type DTOs.</returns>
        public async Task<List<AssetTypeDto>> GetAssetTypesAsync()
        {
            var assetTypes = await _assetTypeRepository.GetAssetTypesAsync();
            return _mapper.Map<List<AssetTypeDto>>(assetTypes);
        }

        /// <summary>
        /// Saves or updates an asset type.
        /// </summary>
        /// <param name="assetTypeDto">The asset type DTO to save.</param>
        /// <returns>The saved or updated asset type DTO.</returns>
        public async Task<AssetTypeDto> SaveAssetTypeAsync(AssetTypeDto assetTypeDto)
        {
            var assetTypeEntity = _mapper.Map<AssetType>(assetTypeDto);
            var savedEntity = await _assetTypeRepository.SaveAssetTypeAsync(assetTypeEntity);
            return _mapper.Map<AssetTypeDto>(savedEntity);
        }
    }
}
