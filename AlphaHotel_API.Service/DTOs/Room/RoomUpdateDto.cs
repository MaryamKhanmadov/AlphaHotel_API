namespace AlphaHotel_API.Service.DTOs.Room
{
    public class RoomUpdateDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Descreption { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }
    }
}
