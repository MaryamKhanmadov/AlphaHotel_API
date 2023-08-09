using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.DTOs.Room;

namespace AlphaHotel_API.Service.Services.Interfaces.Room
{
    public interface IRoomWriteService
    {
        Task CreateAsync(RoomCreateDto room);
        Task DeleteAsync(string id);
        Task SoftDeleteAsync(string id);
        Task UpdateAsync(string id, RoomUpdateDto room);
    }
}
