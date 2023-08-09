using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Contexts;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Repository.Repositories;

namespace AlphaHotel_API.Repository
{
    public class RoomReadRepository : ReadRepository<Room>, IRoomReadRepository
    {
        public RoomReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
