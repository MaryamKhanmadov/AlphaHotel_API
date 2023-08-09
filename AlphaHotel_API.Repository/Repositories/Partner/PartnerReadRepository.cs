using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Repository.Contexts;
using AlphaHotel_API.Repository.Interfaces;
using AlphaHotel_API.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaHotel_API.Repository
{
    public class PartnerReadRepository : ReadRepository<Partner>, IPartnerReadRepository
    {
        public PartnerReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
