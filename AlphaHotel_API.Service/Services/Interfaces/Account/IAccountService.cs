using AlphaHotel_API.Service.DTOs.Account;

namespace AlphaHotel_API.Service.Services.Interfaces.Account
{
    public interface IAccountService
    {
        Task<string?> LoginAsync(LoginDto model);
        Task<ApiResponse> RegisterAsync(RegisterDto model);
        Task CreateRoleAsync(RoleDto model);
    }
}
