using AlphaHotel_API.Domain.Common;

namespace AlphaHotel_API.Domain.Entities
{
    public class Room : BaseEntity
    {
        public required string Name { get; set; }
        public required string Location { get; set; }
        public  required string Descreption { get; set; }
        public int ViewCount { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }
    }
}
