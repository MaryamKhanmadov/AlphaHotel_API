using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.DTOs.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaHotel_API.Service.Services.Interfaces
{
    public interface IRoomWriteService
    {
        Task CreateAsync(RoomCreateDto room);
        Task DeleteAsync(string id);
        Task SoftDeleteAsync(string id);
        Task UpdateAsync(string id, RoomUpdateDto room);
    }
}
