namespace HotelReservationSystem
{
    partial class ManagerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip = new StatusStrip();
            sidebarPanel = new Panel();
            Logout = new Button();
            Payment = new Button();
            Report = new Button();
            Booking = new Button();
            Guest = new Button();
            Room = new Button();
            ServiceButton = new Button();
            panel1 = new Panel();
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            sidebarPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Location = new Point(0, 408);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(784, 22);
            statusStrip.TabIndex = 9;
            statusStrip.Text = "statusStrip1";
            // 
            // sidebarPanel
            // 
            sidebarPanel.Controls.Add(Logout);
            sidebarPanel.Controls.Add(Payment);
            sidebarPanel.Controls.Add(Report);
            sidebarPanel.Controls.Add(Booking);
            sidebarPanel.Controls.Add(Guest);
            sidebarPanel.Controls.Add(Room);
            sidebarPanel.Controls.Add(ServiceButton);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.MaximumSize = new Size(180, 0);
            sidebarPanel.MinimumSize = new Size(180, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(180, 408);
            sidebarPanel.TabIndex = 10;
            // 
            // Logout
            // 
            Logout.Location = new Point(36, 248);
            Logout.Name = "Logout";
            Logout.Size = new Size(94, 34);
            Logout.TabIndex = 5;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // Payment
            // 
            Payment.Location = new Point(36, 170);
            Payment.Name = "Payment";
            Payment.Size = new Size(94, 34);
            Payment.TabIndex = 3;
            Payment.Text = "Payment";
            Payment.UseVisualStyleBackColor = true;
            Payment.Click += Payment_Click;
            // 
            // Report
            // 
            Report.Location = new Point(36, 210);
            Report.Name = "Report";
            Report.Size = new Size(94, 32);
            Report.TabIndex = 4;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            Report.Click += Report_Click;
            // 
            // Booking
            // 
            Booking.Location = new Point(36, 131);
            Booking.Name = "Booking";
            Booking.Size = new Size(94, 33);
            Booking.TabIndex = 2;
            Booking.Text = "Booking";
            Booking.UseVisualStyleBackColor = true;
            Booking.Click += Booking_Click;
            // 
            // Guest
            // 
            Guest.Location = new Point(36, 12);
            Guest.Name = "Guest";
            Guest.Size = new Size(94, 32);
            Guest.TabIndex = 0;
            Guest.Text = "Guest ";
            Guest.UseVisualStyleBackColor = true;
            Guest.Click += Guest_Click;
            // 
            // Room
            // 
            Room.Location = new Point(36, 50);
            Room.Name = "Room";
            Room.Size = new Size(94, 34);
            Room.TabIndex = 1;
            Room.Text = "Room";
            Room.UseVisualStyleBackColor = true;
            Room.Click += Room_Click;
            // 
            // ServiceButton
            // 
            ServiceButton.Location = new Point(36, 90);
            ServiceButton.Name = "ServiceButton";
            ServiceButton.Size = new Size(94, 35);
            ServiceButton.TabIndex = 6;
            ServiceButton.Text = "Service";
            ServiceButton.UseVisualStyleBackColor = true;
            ServiceButton.Click += ServiceButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(180, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 408);
            panel1.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(27, 142);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_07_26_072905;
            pictureBox1.Location = new Point(357, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(784, 430);
            Controls.Add(panel1);
            Controls.Add(sidebarPanel);
            Controls.Add(statusStrip);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ManagerDashboard";
            Load += ManagerDashboard_Load;
            sidebarPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip;
        private Panel sidebarPanel;
        private Button Logout;
        private Button Payment;
        private Button Report;
        private Button Booking;
        private Button Guest;
        private Button Room;
        private Button ServiceButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar1;
    }
}