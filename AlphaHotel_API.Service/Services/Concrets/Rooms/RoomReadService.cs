using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Service.DTOs.Room;
using AlphaHotel_API.Service.Services.Interfaces.Room;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace AlphaHotel_API.Service.Services.Concrets.Rooms
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
        public List<RoomListDto> GetAll()
        {
            return _mapper.Map<List<RoomListDto>>(_repository.GetAll(false).ToList());
        }

        public async Task<RoomListDto> GetByIdAsync(string id)
        {
            return _mapper.Map<RoomListDto>(await _repository.GetByIdAsyncRepo(id, false));
        }

        public List<RoomListDto> Search(string? searchText)
        {
            List<Room> searchRooms = new();
            if (searchText != null)
            {
                searchRooms = (_repository.GetWhere(m => m.Name.ToLower().Contains(searchText),false).ToList());
            }
            else
            {
                searchRooms = _repository.GetAll(false).ToList();
            }
            return _mapper.Map<List<RoomListDto>>(searchRooms);
        }
    }
}
