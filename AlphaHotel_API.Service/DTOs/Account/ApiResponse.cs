namespace AlphaHotel_API.Service.DTOs.Account
{
    public class ApiResponse
    {
        public List<string>? Errors { get; set; }
        public required string StatusMessage { get; set; }
    }
}
