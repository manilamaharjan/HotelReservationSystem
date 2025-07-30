using HotelReservationSystem.Data;
using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            LoadBookings();
            LoadPaymentMethods();
            LoadPayments();
        }
        private void LoadPaymentMethods()
        {
            PaymentMethodBox.Items.Clear();
            PaymentMethodBox.Items.Add("Cash");
            PaymentMethodBox.Items.Add("Credit Card");
            PaymentMethodBox.Items.Add("Debit Card");
            PaymentMethodBox.Items.Add("Mobile Payment");
            PaymentMethodBox.Items.Add("Bank Transfer");

            PaymentMethodBox.SelectedIndex = 0; // Select first item by default
        }
        private void LoadBookings()
        {
            using var context = new AppDbContext();
            var bookings = context.Bookings
                .Select(b => new
                {
                    b.BookingId,
                    GuestName = b.Guest.FirstName + " - " + b.Guest.LastName,
                    DisplayText = b.BookingId + " - " + b.Guest.FirstName + " - " + b.Guest.LastName
                }).ToList();
            BookingBox.DataSource = bookings;
            BookingBox.DisplayMember = "DisplayText";
            BookingBox.ValueMember = "BookingId";
        }
        private void LoadPayments()
        {
            using var context = new AppDbContext();

            var payments = context.Payments
                .Select(p => new
                {
                    p.PaymentId,
                    BookingId = p.BookingId,
                    GuestName = p.Booking.Guest.FirstName,   // assuming Booking->Guest navigation exists
                    p.TotalAmount,
                    PaymentDate = p.PaymentDate,
                    p.PaymentMethod
                })
                .ToList();

            PaymentDataView.DataSource = payments;
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            int bookingId = (int)BookingBox.SelectedValue;
            using var context = new AppDbContext();

            var booking = context.Bookings
                .Where(b => b.BookingId == bookingId)
                .Select(b => new
                {
                    Rooms = b.BookingRooms.Select(br => br.Room.PricePerNight),
                    Services = b.BookingServices.Select(bs => bs.Service.Price),
                    CheckIn = b.CheckIn,
                    CheckOut = b.CheckOut
                }).FirstOrDefault();

            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }

            int nights = (booking.CheckOut - booking.CheckIn).Days;
            if (nights <= 0) nights = 1;

            decimal roomTotal = booking.Rooms.Sum() * nights;
            decimal serviceTotal = booking.Services.Sum();
            decimal finalTotal = roomTotal + serviceTotal;

            RoomTotal.Text = $"Room Charges: Rs. {roomTotal:N2}";
            ServiceTotal.Text = $"Service Charges: Rs. {serviceTotal:N2}";
            TotalAmount.Text = $"TOTAL: Rs. {finalTotal:N2}";
        }
                

        private void Pay_Click(object sender, EventArgs e)
        {
            int bookingId = (int)BookingBox.SelectedValue;
            using var context = new AppDbContext();

            var booking = context.Bookings
                .Where(b => b.BookingId == bookingId)
                .Select(b => new
                {
                    Rooms = b.BookingRooms.Select(br => br.Room.PricePerNight),
                    Services = b.BookingServices.Select(bs => bs.Service.Price),
                    CheckIn = b.CheckIn,
                    CheckOut = b.CheckOut
                }).FirstOrDefault();
            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }
            int nights = (booking.CheckOut - booking.CheckIn).Days;
            if (nights <= 0) nights = 1;

            decimal total = booking.Rooms.Sum() * nights + booking.Services.Sum();

            var payment = new Payment
            {
                BookingId = bookingId,
                TotalAmount = total,
                PaymentDate = DateTime.Now,
                PaymentMethod = PaymentMethodBox.Text
            };

            context.Payments.Add(payment);
            context.SaveChanges();

            MessageBox.Show("Payment recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPayments();
        }
    }
    
}
