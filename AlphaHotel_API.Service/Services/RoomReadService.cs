using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.DTOs.Room;
using AlphaHotel_API.Service.Services.Interfaces;
using AutoMapper;

namespace AlphaHotel_API.Service.Services
{
    public class RoomReadService : IRoomReadService
    {
        private readonly IRoomReadRepository _repository;
        private readonly IMapper _mapper;

        public RoomReadService(IRoomReadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<RoomListDto>> GetAllAsync()
        {
            return _mapper.Map<List<RoomListDto>>(await _repository.GetAll());
        }

        public Task<List<RoomListDto>> SearchAsync(string? searchText)
        {
            throw new NotImplementedException();
        }
    }
}
