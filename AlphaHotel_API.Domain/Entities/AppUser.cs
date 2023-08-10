using Microsoft.AspNetCore.Identity;

namespace AlphaHotel_API.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
