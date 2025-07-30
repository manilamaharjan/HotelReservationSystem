using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelReservationSystem.Data;
using HotelReservationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            LoadGuests();
            LoadBookings();
            LoadServices();
        }
        private void LoadGuests()
        {
            using var context = new AppDbContext();
            var guests = context.Guests
                .Select(g => new
                {
                    g.GuestId,
                    FullName = g.FirstName + " " + g.LastName
                })
                .ToList();

            GuestBox.DataSource = guests;
            GuestBox.DisplayMember = "FullName";
            GuestBox.ValueMember = "GuestId";
        }
        private void LoadBookings()
        {
            using var context = new AppDbContext();
            var bookings = context.Bookings
                .Select(b => new
                {
                    b.BookingId,
                    Guest = b.Guest.FirstName + " " + b.Guest.LastName,
                    b.CheckIn,
                    b.CheckOut,
                    Rooms = string.Join(", ", b.BookingRooms.Select(br => br.Room.RoomNumber))
                })
                .ToList();
            BookingDataView.DataSource = bookings;


        }
        private void LoadServices()
        {
            using var context = new AppDbContext();
            var services = context.Services
                .Select(s => new
                {
                    s.ServiceId,
                    Service = s.ServiceName
                })
                .ToList();
            ServiceBox.DataSource = services;
            ServiceBox.DisplayMember = "Service";
            ServiceBox.ValueMember = "ServiceId";
            ServiceBox.SelectedIndex = -1; // Optional: Clear initial selection
        }






        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime checkIn = CheckInDatePicker.Value.Date;
            DateTime checkOut = CheckOutDatePicker.Value.Date.AddHours(12); // Checkout at 12 PM

            using var context = new AppDbContext();

            // Step 1: Get IDs of rooms that are already booked in the date range
            var conflictingRoomIds = context.BookingRooms
                .Where(br =>
                    br.Booking.CheckOut > checkIn &&
                    br.Booking.CheckIn < checkOut)
                .Select(br => br.RoomId)
                .Distinct()
                .ToList();

            // Step 2: Get available rooms that are not in the conflicting list
            var availableRooms = context.Rooms
                .Where(r => r.Availability == "Available" && !conflictingRoomIds.Contains(r.RoomId))
                .ToList();

            // Bind available rooms to AvailableRoomBox
            AvailableRoomBox.DataSource = availableRooms;
            AvailableRoomBox.DisplayMember = "RoomNumber";
            AvailableRoomBox.ValueMember = "RoomId";
            AvailableRoomBox.SelectedIndex = -1; // Optional: Clear initial selection


        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            if (AvailableRoomBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a room.");
                return;
            }

            int guestId = (int)GuestBox.SelectedValue;
            int roomId = (int)AvailableRoomBox.SelectedValue;
            DateTime checkIn = CheckInDatePicker.Value.Date;
            DateTime checkOut = CheckOutDatePicker.Value.Date.AddHours(12); // Checkout at 12 PM

            using var context = new AppDbContext();

            var booking = new Booking
            {
                GuestId = guestId,
                CheckIn = checkIn,
                CheckOut = checkOut,
                BookingRooms = new List<BookingRoom>
                {
                    new BookingRoom { RoomId = roomId }
                }
            };

            // Update room availability
            var roomToUpdate = context.Rooms.Find(roomId);
            if (roomToUpdate != null)
            {
                roomToUpdate.Availability = "Occupied";
            }

            context.Bookings.Add(booking);
            context.SaveChanges();

            MessageBox.Show("Booking successful!");
            AvailableRoomBox.DataSource = null;
            LoadBookings();
        }

        private void bookingBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
    

