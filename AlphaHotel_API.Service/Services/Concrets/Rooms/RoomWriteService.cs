using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.DTOs.Room;
using AlphaHotel_API.Service.Services.Interfaces.Room;
using AutoMapper;

namespace AlphaHotel_API.Service.Services.Concrets.Rooms
{
    public class RoomWriteService : IRoomWriteService
    {
        private readonly IMapper _mapper;
        private readonly IRoomWriteRepository _repositoryWrite;
        private readonly IRoomReadRepository _repositoryRead;

        public RoomWriteService(IMapper mapper, IRoomWriteRepository repositoryWrite, IRoomReadRepository repositoryRead)
        {
            _mapper = mapper;
            _repositoryWrite = repositoryWrite;
            _repositoryRead = repositoryRead;
        }
        public async Task CreateAsync(RoomCreateDto room)
        {
            await _repositoryWrite.AddAsync(_mapper.Map<Room>(room));
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string id, RoomUpdateDto room)
        {
            var dbRoom = await _repositoryRead.GetByIdAsyncRepo(id);
            _repositoryWrite.Update(_mapper.Map(room, dbRoom));
        }
    }
}
