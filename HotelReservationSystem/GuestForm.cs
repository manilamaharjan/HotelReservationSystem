using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HotelReservationSystem.Data;
using HotelReservationSystem.Models;

namespace HotelReservationSystem
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
            LoadGuests();
        }
        private void LoadGuests()
        {
            using var context = new AppDbContext();
            var guests = context.Guests.ToList();
            GuestDataView.DataSource = guests;

        }
        private void Add_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var guest = new Guest
            {
                FirstName = FirstNameBox.Text,
                LastName = LastNameBox.Text,
                Email = EmailBox.Text,
                PhoneNumber = PhoneNumberBox.Text,
                Address = AddressBox.Text,
            };
            context.Guests.Add(guest);
            context.SaveChanges();
            LoadGuests();
            ClearFields();

            MessageBox.Show("Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearFields()
        {
            FirstNameBox.Clear();
            LastNameBox.Clear();
            EmailBox.Clear();
            PhoneNumberBox.Clear();
            AddressBox.Clear();
        }

        private void GuestDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GuestDataView.CurrentRow != null)
            {
                FirstNameBox.Text = GuestDataView.CurrentRow.Cells["FirstName"].Value.ToString();
                LastNameBox.Text = GuestDataView.CurrentRow.Cells["LastName"].Value.ToString();
                EmailBox.Text = GuestDataView.CurrentRow.Cells["Email"].Value.ToString();
                PhoneNumberBox.Text = GuestDataView.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                AddressBox.Text = GuestDataView.CurrentRow.Cells["Address"].Value.ToString();

            }
        }
    }
}
