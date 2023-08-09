using AlphaHotel_API.Domain.Common;

namespace AlphaHotel_API.Domain.Entities
{
    public class Partner : BaseEntity
    {
        public required string Name { get; set; }
        public required string Descreption { get; set; }
        public required string LogoUrl { get; set; }
    }
}
