using AlphaHotel_API.Service.DTOs.Room;

namespace AlphaHotel_API.Service.Services.Interfaces
{
    public interface IRoomReadService
    {
        Task<List<RoomListDto>> GetAllAsync();
        Task<List<RoomListDto>> SearchAsync(string? searchText);
    }
}
