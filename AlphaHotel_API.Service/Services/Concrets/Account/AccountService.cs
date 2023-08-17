using AlphaHotel_API.Domain.Entities;
using AlphaHotel_API.Service.DTOs.Account;
using AlphaHotel_API.Service.Services.Interfaces.Account;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AlphaHotel_API.Service.Services.Concrets.Account
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountService(RoleManager<IdentityRole> roleManager,
                              UserManager<AppUser> userManager,
                              IMapper mapper,
                              IConfiguration configuration)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task CreateRoleAsync(RoleDto model)
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = model.Role });
        }

        public async Task<string?> LoginAsync(LoginDto model)
        {
            var dbUser = await _userManager.FindByEmailAsync(model.Email);

            if (!await _userManager.CheckPasswordAsync(dbUser, model.Password)) 
                return null;

            var roles = await _userManager.GetRolesAsync(dbUser);

            return GenerateJwtToken(dbUser.UserName, (List<string>) roles);
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

            var dbUser = await _userManager.FindByEmailAsync(model.Email);
            await _userManager.AddToRoleAsync(dbUser, "Member");

            return new ApiResponse { Errors = null, StatusMessage = "Success" };
        }

        private string GenerateJwtToken(string username, List<string> roles)
        {
            var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, username)
        };

            roles.ForEach(role =>
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            });

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["Jwt:ExpireDays"]));

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: expires,
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
