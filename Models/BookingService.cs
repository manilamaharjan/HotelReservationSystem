using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Models
{
    public class BookingService
    {
        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
