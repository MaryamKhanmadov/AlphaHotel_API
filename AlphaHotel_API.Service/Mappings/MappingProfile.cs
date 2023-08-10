using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Service.DTOs.Account;
using AlphaHotel_API.Service.DTOs.Partner;
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
            CreateMap<Room, RoomListDto>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
            CreateMap<Partner, PartnerListDto>().ReverseMap();
            CreateMap<PartnerCreateDto, Partner>();
            CreateMap<PartnerUpdateDto, Partner>().ReverseMap();
            CreateMap<RegisterDto, AppUser>();
        }
    }
}
