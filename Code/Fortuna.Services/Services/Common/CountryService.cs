using AutoMapper;
using Fortuna.Data.Contracts.Common;
using Fortuna.Data.Entities.Common;
using Fortuna.Services.Contracts.Common;
using Fortuna.Services.Models.Common;

namespace Fortuna.Services.Services.Common
{
    public class CountryService: ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        
        public async Task<List<CountryDto>> GetCountriesAsync()
        {
            var assetTypes = await _countryRepository.GetCountriesAsync();
            return _mapper.Map<List<CountryDto>>(assetTypes);
        }

        public async Task<CountryDto> GetCountryAsync(int countryId)
        {
            var country = await _countryRepository.GetCountryAsync(countryId);
            return _mapper.Map<CountryDto>(country);
        }

        public async Task<CountryDto> SaveAssetTypeAsync(CountryDto countryDto)
        {
            var country = _mapper.Map<Country>(countryDto);
            var savedEntity = await _countryRepository.SaveCountryAsync(country);
            return _mapper.Map<CountryDto>(savedEntity);
        }
    }
}
