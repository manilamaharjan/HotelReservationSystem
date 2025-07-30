using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public string Availability { get; set; } // Available or Occupied
        public override string ToString()
        {
            return $"Room {RoomNumber}"; // This will show in AvailableRoomBox
        }
    }

}
