using AutoMapper;
using Fortuna.Data.Entities.Asset;
using Fortuna.Data.Entities.Common;
using Fortuna.Data.Entities.Expense;
using Fortuna.Services.Models.Asset;
using Fortuna.Services.Models.Common;
using Fortuna.Services.Models.Expense;

namespace Fortuna.Services.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Expense, ExpenseDto>().ReverseMap();
            this.CreateMap<ExpenseType, ExpenseTypeDto>().ReverseMap();
            this.CreateMap<ExpenseItemType, ExpenseItemTypeDto>().ReverseMap();
            this.CreateMap<Asset, AssetDto>().ReverseMap();
            this.CreateMap<AssetType, AssetTypeDto>().ReverseMap();
            this.CreateMap<Country, CountryDto>().ReverseMap();
            this.CreateMap<Store, StoreDto>().ReverseMap();
            this.CreateMap<QuantityType, QuantityTypeDto>().ReverseMap();
        }
    }
}
