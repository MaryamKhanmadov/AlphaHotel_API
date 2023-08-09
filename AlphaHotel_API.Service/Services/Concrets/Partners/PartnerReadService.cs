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

        public async Task<List<PartnerListDto>> SearchAsync(string searchText)
        {
            throw new NotImplementedException();
            //return _mapper.Map<List<PartnerListDto>>(await _repository.GetWhere(m=>m.Name.StartsWith(searchText),false));
        }
    }
}
