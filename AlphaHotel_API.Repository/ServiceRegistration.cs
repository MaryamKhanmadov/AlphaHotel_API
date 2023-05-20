using AlphaHotel_API.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AlphaHotel_API.Repository
{
    public static class ServiceRegistration
    {
        public static void AddRepositoryLayerServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql("User ID=postgres;Password=12345;Host=localhost;Port=5432;Database=API_AlphaHotelDB;"));
        }
    }
}
