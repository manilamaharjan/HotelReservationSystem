using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Guest Guest { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
        public ICollection<BookingService> BookingServices { get; set; }
        
        public Payment Payment { get; set; }

    }
}
