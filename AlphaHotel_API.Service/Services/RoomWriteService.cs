using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.DTOs.Room;
using AlphaHotel_API.Service.Services.Interfaces;
using AutoMapper;

namespace AlphaHotel_API.Service.Services
{
    public class RoomWriteService : IRoomWriteService
    {
        private readonly IMapper _mapper;
        private readonly IRoomWriteRepository _repository;

        public RoomWriteService(IMapper mapper, IRoomWriteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task CreateAsync(RoomCreateDto room)
        {
            await _repository.AddAsync(_mapper.Map<Room>(room));
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, RoomUpdateDto room)
        {
            throw new NotImplementedException();
        }
    }
}
