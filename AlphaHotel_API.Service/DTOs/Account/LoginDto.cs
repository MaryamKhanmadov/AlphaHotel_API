﻿namespace AlphaHotel_API.Service.DTOs.Account
{
    public class LoginDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
