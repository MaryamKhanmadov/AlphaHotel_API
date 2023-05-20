using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.DTOs.Room;
using AutoMapper;

namespace AlphaHotel_API.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomCreateDto, Room>();
            CreateMap<Room, RoomListDto>();
        }
    }
}
