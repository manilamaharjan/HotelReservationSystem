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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            LoadServices();
            LoadServiceTypes();
            
        }
        private void LoadServices()
        {
            using var context = new AppDbContext();
            ServiceDataView.DataSource = context.Services.ToList();
        }
        private void LoadServiceTypes()
        {
            ServiceTypeBox.Items.Clear();
            ServiceTypeBox.Items.Add("Airport Pickup and Drop off");
            ServiceTypeBox.Items.Add("Extra Bed");
            ServiceTypeBox.Items.Add("Sightseeing");
            ServiceTypeBox.Items.Add("Meals");
        }

       
        private void ServiceDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ServiceDataView.CurrentRow != null)
            {
                ServiceTypeBox.SelectedItem = ServiceDataView.CurrentRow.Cells["ServiceName"].Value.ToString();
                PriceBox.Text = ServiceDataView.CurrentRow.Cells["Price"].Value.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ServiceTypeBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a service type.");
                return;
            }

            using var context = new AppDbContext();
            var service = new Service
            {
                ServiceName = ServiceTypeBox.SelectedItem.ToString(),
                Price = decimal.Parse(PriceBox.Text)
            };
            context.Services.Add(service);
            context.SaveChanges();
            LoadServices();
            ClearFields();
        }

        private void ClearFields()
        {
            ServiceTypeBox.SelectedIndex = -1;
            PriceBox.Clear();
        }
    }
}
    

