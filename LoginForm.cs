using HotelReservationSystem.Data;
using Microsoft.Data.SqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = !ShowPasswordBox.Checked;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            using var context = new AppDbContext();

            var user = context.Users.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                

                if (user.Role == "Manager")
                {
                    this.Hide();
                    new ManagerDashboard(user.Username).Show();
                }
                else if (user.Role == "FrontDesk")
                {
                    this.Hide();
                    new FrontDeskDashboard(user.Username).Show();
                }
                else
                {
                    MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
