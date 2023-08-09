using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Contexts;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Repository.Repositories;

namespace AlphaHotel_API.Repository
{
    public class PartnerWriteRepository : WriteRepository<Partner>, IPartnerWriteRepository
    {
        public PartnerWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
