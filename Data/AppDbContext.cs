using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.Models;

namespace HotelReservationSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingRoom> BookingRooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<BookingService> BookingServices { get; set; }

        public DbSet<Payment> Payments { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = "Data Source=LAPTOP-5QPNT8AG\\SQLEXPRESS01;Initial Catalog=HotelDbContext;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingRoom>()
                .HasKey(br => new { br.BookingId, br.RoomId });
            modelBuilder.Entity<BookingService>()
        .HasKey(bs => new { bs.BookingId, bs.ServiceId });
        }
    }
}