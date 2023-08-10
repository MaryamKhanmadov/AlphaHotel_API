using AlphaHotel_API.Service.DTOs.Account;

namespace AlphaHotel_API.Service.Services.Interfaces.Account
{
    public interface IAccountService
    {
        Task LoginAsync(LoginDto model);
        Task<ApiResponse> RegisterAsync(RegisterDto model);
    }
}
