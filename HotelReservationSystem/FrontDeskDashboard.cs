using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelReservationSystem
{
    public partial class FrontDeskDashboard : Form
    {
        private readonly string _username;

        public FrontDeskDashboard(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            new GuestForm().ShowDialog();
        }

        private void Room_Click(object sender, EventArgs e)
        {
            new RoomForm().ShowDialog();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            new BookingForm().ShowDialog();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            new PaymentForm().ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void FrontDeskDashboard_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(176, 224, 230); // Pastel blue

            // Header Panel
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;
            headerPanel.BackColor = Color.FromArgb(150, 200, 210);
            this.Controls.Add(headerPanel);

            Label titleLabel = new Label();
            titleLabel.Text = "FrontDesk Dashboard";
            titleLabel.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            titleLabel.ForeColor = Color.Black;
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(20, 15);
            headerPanel.Controls.Add(titleLabel);
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome, Receptionist";
            welcomeLabel.Font = new Font("Segoe UI", 09, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.Black;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            welcomeLabel.Location = new Point(headerPanel.Width - 180, 20);
            welcomeLabel.Left = headerPanel.Width - welcomeLabel.Width - 20;
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            headerPanel.Controls.Add(welcomeLabel);

            // Style all Buttons (including those inside panels)
            Color sidebarButtonColor = Color.FromArgb(120, 180, 190);
            StyleButtonsRecursively(this.Controls, sidebarButtonColor);

            // Status Bar
            StatusStrip statusStrip = new StatusStrip();
            statusStrip.BackColor = Color.LightGray;
            statusStrip.ForeColor = Color.Black;
            statusStrip.Dock = DockStyle.Bottom;
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Ready");
            statusStrip.Items.Add(statusLabel);
            this.Controls.Add(statusStrip);
        }
        private void StyleButtonsRecursively(Control.ControlCollection controls, Color backgroundColor)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    StyleSidebarButton(btn, backgroundColor);
                }
                else
                {
                    StyleButtonsRecursively(ctrl.Controls, backgroundColor);
                }
            }
        }
        private void StyleSidebarButton(Button btn, Color backgroundColor)
        {
            btn.BackColor = backgroundColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Paint += RoundedButton_Paint;

            btn.MouseEnter += (s, e) => { btn.BackColor = ControlPaint.Light(backgroundColor); };
            btn.MouseLeave += (s, e) => { btn.BackColor = backgroundColor; };
        }
        private void RoundedButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            Rectangle bounds = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            int radius = 10;
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }


        private void ServiveButton_Click(object sender, EventArgs e)
        {
            new ServiceForm().ShowDialog();
        }
    }
}
