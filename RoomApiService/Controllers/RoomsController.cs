using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RoomApiService.Models;

namespace RoomApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        public IActionResult Get()
        {
            var roomList = new List<Room>() {
                new Room(){ RoomId = 1, FloorNumber = 4, RoomNumber = 100, RoomType ="Double", RoomCapacity=3, CostPerDay =2800, RoomStatus="Available", HotelId=100,HotelName="ABC" },
                new Room(){ RoomId = 2, FloorNumber = 4, RoomNumber = 101, RoomType ="Double", RoomCapacity=3, CostPerDay =3800, RoomStatus="Available", HotelId=100,HotelName="ABC"  },
                new Room(){ RoomId = 3, FloorNumber = 5, RoomNumber = 500, RoomType ="3BHK", RoomCapacity=6, CostPerDay =5800, RoomStatus="Available",   HotelId=200,HotelName="PQR" },
                new Room(){ RoomId = 4, FloorNumber = 5, RoomNumber = 501, RoomType ="2BHK", RoomCapacity=4, CostPerDay =3800, RoomStatus="Not Available",HotelId=200,HotelName="PQR" },
                new Room(){ RoomId = 5, FloorNumber = 3, RoomNumber = 300, RoomType ="Double", RoomCapacity=3, CostPerDay =5800, RoomStatus="Available", HotelId=300,HotelName="XYZ"  }

            };

            return Ok(roomList);
        }
    }
}
