using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HotelReservationSystem.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        public Booking Booking { get; set; }
    }
}
