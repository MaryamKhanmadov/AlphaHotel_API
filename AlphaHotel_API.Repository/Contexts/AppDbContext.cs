using AlphaHotel_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlphaHotel_API.Repository.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Room> Rooms { get; set; }
    }
}
