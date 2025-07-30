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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            PopulateRoomNumbers();
            PopulateRoomTypes();
            PopulateAvailability();
            LoadRooms();
        }
        private void PopulateRoomNumbers()
        {
            RoomNumberBox.Items.Clear();
            for (int floor = 1; floor <= 3; floor++)
            {
                for (int room = 1; room <= 7; room++)
                {
                    RoomNumberBox.Items.Add($"{floor}0{room}");
                }
            }
        }
        private void PopulateRoomTypes()
        {
            RoomTypeBox.Items.Clear();
            RoomTypeBox.Items.AddRange(new string[]
            {
                "Single", "Double", "Deluxe", "SuperDeluxe", "FamilyRoom"
            });
        }
        private void PopulateAvailability()
        {
            AvailabilityBox.Items.Clear();
            AvailabilityBox.Items.AddRange(new string[] { "Available", "Occupied" });
        }
        private void LoadRooms()
        {
            using var context = new AppDbContext();
            RoomDataView.DataSource = context.Rooms
                .Select(r => new
                {
                    RoomID = r.RoomId,
                    r.RoomNumber,
                    r.RoomType,
                    r.PricePerNight,
                    r.Availability
                })
                .ToList();
        }

        private void RoomNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvailabilityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var room = new Room
            {
                RoomNumber = RoomNumberBox.Text,
                RoomType = RoomTypeBox.Text,
                PricePerNight = decimal.Parse(PriceBox.Text),
                Availability = AvailabilityBox.Text
            };
            context.Rooms.Add(room);
            context.SaveChanges();
            LoadRooms();
            ClearFields();

            MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (RoomDataView.CurrentRow == null) return;

            int id = (int)RoomDataView.CurrentRow.Cells["RoomID"].Value;

            using var context = new AppDbContext();
            var room = context.Rooms.Find(id);
            if (room != null)
            {
                room.RoomNumber = RoomNumberBox.Text;
                room.RoomType = RoomTypeBox.Text;
                room.PricePerNight = decimal.Parse(PriceBox.Text);
                room.Availability = AvailabilityBox.Text;

                context.SaveChanges();
                LoadRooms();
                ClearFields();


            }
        }
        

        private void ClearFields()
        {
            RoomNumberBox.SelectedIndex = -1;
            RoomTypeBox.SelectedIndex = -1;
            AvailabilityBox.SelectedIndex = -1;
            PriceBox.Clear();
        }

        private void RoomDataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (RoomDataView.CurrentRow != null)
            {
                RoomNumberBox.Text = RoomDataView.CurrentRow.Cells["RoomNumber"].Value.ToString();
                RoomTypeBox.Text = RoomDataView.CurrentRow.Cells["Type"].Value.ToString();
                PriceBox.Text = RoomDataView.CurrentRow.Cells["PricePerNight"].Value.ToString();
                AvailabilityBox.Text = RoomDataView.CurrentRow.Cells["Availability"].Value.ToString();
            }
        }
    }
}
