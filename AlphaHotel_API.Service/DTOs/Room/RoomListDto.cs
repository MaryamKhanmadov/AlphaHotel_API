using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaHotel_API.Service.DTOs.Room
{
    public class RoomListDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
