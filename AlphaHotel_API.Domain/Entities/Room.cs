using AlphaHotel_API.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaHotel_API.Domain.Entities
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Descreption { get; set; }
        public int ViewCount { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }
    }
}
