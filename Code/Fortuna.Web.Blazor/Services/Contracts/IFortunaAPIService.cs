using Fortuna.Web.Blazor.Models.Asset;

namespace Fortuna.Web.Blazor.Services.Contracts
{
    public interface IFortunaAPIService
    {
        Task<List<AssetTypeDto>> GetAssetTypesAsync();
    }
}
