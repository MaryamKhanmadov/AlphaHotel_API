using AlphaHotel_API.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace AlphaHotel_API.Repository.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
