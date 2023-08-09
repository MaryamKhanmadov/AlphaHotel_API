using AlphaHotel_API.Service.DTOs.Room;

namespace AlphaHotel_API.Service.Services.Interfaces.Room
{
    public interface IRoomReadService
    {
        List<RoomListDto> GetAll();
        List<RoomListDto> Search(string? searchText);
        Task<RoomListDto> GetByIdAsync(string id);
    }
}
