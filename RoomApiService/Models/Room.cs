using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomApiService.Models
{
    public class Room
    {
        public int RoomId { get; set; }

        public int FloorNumber { get; set; }

        public int RoomNumber { get; set; }

        public string RoomType { get; set; }

        public int RoomCapacity { get; set; }

        public int CostPerDay { get; set; }

        public string RoomStatus { get; set; }
        public int HotelId { get; set; }

        public string HotelName { get; set; }



    }
}
