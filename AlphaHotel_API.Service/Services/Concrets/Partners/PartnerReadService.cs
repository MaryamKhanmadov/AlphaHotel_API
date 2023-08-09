using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.DTOs.Partner;
using AlphaHotel_API.Service.Services.Interfaces.Partner;
using AutoMapper;

namespace AlphaHotel_API.Service.Services.Concrets.Partners
{
    public class PartnerReadService : IPartnerReadService
    {
        private readonly IPartnerReadRepository _repository;
        private readonly IMapper _mapper;
        public PartnerReadService(IPartnerReadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<PartnerListDto> GetAll()
        {
            return _mapper.Map<List<PartnerListDto>>(_repository.GetAll(false).ToList());
        }

        public async Task<PartnerListDto> GetByIdAsync(string id)
        {
            return _mapper.Map<PartnerListDto>(await _repository.GetByIdAsyncRepo(id,false));
        }

        public List<PartnerListDto> Search(string? searchText)
        {
            List<Partner> searchPartners = new();
            if (searchText != null)
            {
                searchPartners = (_repository.GetWhere(m => m.Name.ToLower().Contains(searchText), false).ToList());
            }
            else
            {
                searchPartners = _repository.GetAll(false).ToList();
            }
            return _mapper.Map<List<PartnerListDto>>(searchPartners);
        }
    }
}
