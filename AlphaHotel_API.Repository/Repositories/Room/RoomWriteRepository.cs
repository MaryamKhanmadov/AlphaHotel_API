using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Contexts;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Repository.Repositories;

namespace AlphaHotel_API.Repository
{
    public class RoomWriteRepository : WriteRepository<Room>, IRoomWriteRepository
    {
        public RoomWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
