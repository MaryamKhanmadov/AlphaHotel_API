using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Service.DTOs.Account;
using AlphaHotel_API.Service.Services.Interfaces.Account;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AlphaHotel_API.Service.Services.Concrets.Account
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountService(RoleManager<IdentityRole> roleManager,
                              UserManager<AppUser> userManager,
                              IMapper mapper)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
        }

        public Task LoginAsync(LoginDto model)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> RegisterAsync(RegisterDto model)
        {
            var user = _mapper.Map<AppUser>(model);

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return new ApiResponse { Errors = result.Errors.Select(m=>m.Description).ToList(),
                    StatusMessage = "Failed" };
            }
            return new ApiResponse { Errors = null, StatusMessage = "Success" };
        }
    }
}
