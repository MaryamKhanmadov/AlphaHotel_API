using AlphaHotel_API.Service.DTOs.Partner;
using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.Services.Concrets.Account;
using AlphaHotel_API.Service.Services.Concrets.Partners;
using AlphaHotel_API.Service.Services.Concrets.Rooms;
using AlphaHotel_API.Service.Services.Interfaces.Account;
using AlphaHotel_API.Service.Services.Interfaces.Partner;
using AlphaHotel_API.Service.Services.Interfaces.Room;
using AlphaHotel_API.Service.Validators.Partners;
using AlphaHotel_API.Service.Validators.Rooms;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AlphaHotel_API.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiceLayerServices(this IServiceCollection services)
        {
            services.AddScoped<IRoomWriteService, RoomWriteService>();
            services.AddScoped<IRoomReadService, RoomReadService>();
            services.AddScoped<IPartnerWriteService, PartnerWriteService>();
            services.AddScoped<IPartnerReadService, PartnerReadService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IValidator<RoomCreateDto>, CreateRoomValidator>();
            services.AddScoped<IValidator<PartnerCreateDto>, CreatePartnerValidator>();
        }
    }
}
