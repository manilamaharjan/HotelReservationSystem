using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelReservationSystem.Data;
using Microsoft.EntityFrameworkCore;


namespace HotelReservationSystem
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            LoadReportTypes();
        }
        private void LoadReportTypes()
        {
            ReportTypeBox.Items.Clear();
            ReportTypeBox.Items.Add("All");
            ReportTypeBox.Items.Add("Daily");
            ReportTypeBox.Items.Add("Weekly");
            ReportTypeBox.Items.Add("Monthly");
            ReportTypeBox.Items.Add("Yearly");

            ReportTypeBox.SelectedIndex = 0; 
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            DateTime start = StartDatePicker.Value.Date;
            DateTime end = EndDatePicker.Value.Date;

            using var context = new AppDbContext();

            var bookings = context.Bookings
                .Include(b => b.Payment)
                .Include(b => b.Guest)
                .Include(b => b.BookingServices).ThenInclude(bs => bs.Service)
                .Where(b => b.CheckIn >= start && b.CheckIn <= end)
                .ToList();

            int totalBookings = bookings.Count;
            int totalGuests = bookings.Select(b => b.GuestId).Distinct().Count();
            decimal totalRevenue = bookings
                  .Where(b => b.Payment != null)
                  .Select(b => b.Payment.TotalAmount)
                  .DefaultIfEmpty(0)
                  .Sum();


            var topServices = bookings
                .SelectMany(b => b.BookingServices)
                .GroupBy(bs => bs.Service)
                .Select(g => new { Service = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.Count)
                .Take(5)
                .ToList();

            // Summary Data
            var summaryData = new List<ReportSummary>
            {
                new ReportSummary { Metric = "Total Bookings", Value = totalBookings.ToString() },
                new ReportSummary { Metric = "Unique Guests", Value = totalGuests.ToString() },
                new ReportSummary { Metric = "Total Revenue", Value = $"Rs. {totalRevenue:N2}" }
            };

            SummaryDataView.DataSource = null;
            SummaryDataView.DataSource = summaryData;

            

            SummaryDataView.Columns[0].HeaderText = "Metric";
            SummaryDataView.Columns[1].HeaderText = "Value";

            
        }

        private void SummaryDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class ReportSummary
    {
        public string Metric { get; set; }
        public string Value { get; set; }
    }
}

        
    

