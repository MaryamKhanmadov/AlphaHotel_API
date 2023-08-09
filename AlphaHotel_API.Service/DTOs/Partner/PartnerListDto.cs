namespace AlphaHotel_API.Service.DTOs.Partner
{
    public class PartnerListDto
    {
        public required string Name { get; set; }
        public required string Descreption { get; set; }
        public required string LogoUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
