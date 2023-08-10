namespace AlphaHotel_API.Service.DTOs.Account
{
    public class RegisterDto
    {
        public required string FullName { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
