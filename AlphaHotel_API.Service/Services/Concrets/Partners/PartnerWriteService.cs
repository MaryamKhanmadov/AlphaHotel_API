using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.DTOs.Partner;
using AlphaHotel_API.Service.Services.Interfaces.Partner;
using AutoMapper;

namespace AlphaHotel_API.Service.Services.Concrets.Partners
{
    public class PartnerWriteService : IPartnerWriteService
    {
        private readonly IPartnerWriteRepository _repositoryWrite;
        private readonly IPartnerReadRepository _repositoryRead;
        private readonly IMapper _mapper;

        public PartnerWriteService(IMapper mapper, IPartnerWriteRepository repositoryWrite, IPartnerReadRepository repositoryRead)
        {
            _mapper = mapper;
            _repositoryWrite = repositoryWrite;
            _repositoryRead = repositoryRead;
        }

        public async Task CreateAsync(PartnerCreateDto room)
        {
            await _repositoryWrite.AddAsync(_mapper.Map<Partner>(room));
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string id, PartnerUpdateDto partner)
        {
            var dbPartner = await _repositoryRead.GetByIdAsyncRepo(id);
            _repositoryWrite.Update(_mapper.Map(partner, dbPartner));
        }
    }
}
