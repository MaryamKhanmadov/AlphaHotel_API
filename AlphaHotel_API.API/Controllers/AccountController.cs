using AlphaHotel_API.Service.DTOs.Account;
using AlphaHotel_API.Service.Services.Interfaces.Account;
using Microsoft.AspNetCore.Mvc;

namespace AlphaHotel_API.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<ApiResponse> Register([FromBody]RegisterDto user)
        {
            return await _accountService.RegisterAsync(user);
        }
    }
}
