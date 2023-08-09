using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.DTOs.Partner;
using AlphaHotel_API.Service.Services.Interfaces.Partner;
using AutoMapper;

namespace AlphaHotel_API.Service.Services.Concrets.Partners
{
    public class PartnerWriteService : IPartnerWriteService
    {
        private readonly IPartnerWriteRepository _repository;
        private readonly IMapper _mapper;

        public PartnerWriteService(IMapper mapper, IPartnerWriteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task CreateAsync(PartnerCreateDto room)
        {
            await _repository.AddAsync(_mapper.Map<Partner>(room));
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, PartnerUpdateDto room)
        {
            throw new NotImplementedException();
        }
    }
}
