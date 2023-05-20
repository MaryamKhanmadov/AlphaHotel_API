namespace AlphaHotel_API.Service.DTOs.Product
{
    public class RoomCreateDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Descreption { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }
    }
}
