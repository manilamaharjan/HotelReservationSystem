namespace HotelReservationSystem
{
    partial class FrontDeskDashboard
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
            Guest = new Button();
            Room = new Button();
            Booking = new Button();
            Payment = new Button();
            Logout = new Button();
            ServiveButton = new Button();
            panel = new Panel();
            statusStrip1 = new StatusStrip();
            panel1 = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // Guest
            // 
            Guest.Location = new Point(57, 44);
            Guest.Name = "Guest";
            Guest.Size = new Size(75, 38);
            Guest.TabIndex = 0;
            Guest.Text = "Guest";
            Guest.UseVisualStyleBackColor = true;
            Guest.Click += Guest_Click;
            // 
            // Room
            // 
            Room.Location = new Point(57, 88);
            Room.Name = "Room";
            Room.Size = new Size(75, 41);
            Room.TabIndex = 1;
            Room.Text = "Room";
            Room.UseVisualStyleBackColor = true;
            Room.Click += Room_Click;
            // 
            // Booking
            // 
            Booking.Location = new Point(57, 179);
            Booking.Name = "Booking";
            Booking.Size = new Size(75, 40);
            Booking.TabIndex = 2;
            Booking.Text = "Booking";
            Booking.UseVisualStyleBackColor = true;
            Booking.Click += Booking_Click;
            // 
            // Payment
            // 
            Payment.Location = new Point(57, 225);
            Payment.Name = "Payment";
            Payment.Size = new Size(75, 44);
            Payment.TabIndex = 3;
            Payment.Text = "Payment";
            Payment.UseVisualStyleBackColor = true;
            Payment.Click += Payment_Click;
            // 
            // Logout
            // 
            Logout.Location = new Point(57, 275);
            Logout.Name = "Logout";
            Logout.Size = new Size(75, 41);
            Logout.TabIndex = 4;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // ServiveButton
            // 
            ServiveButton.Location = new Point(57, 135);
            ServiveButton.Name = "ServiveButton";
            ServiveButton.Size = new Size(75, 38);
            ServiveButton.TabIndex = 6;
            ServiveButton.Text = "Service";
            ServiveButton.UseVisualStyleBackColor = true;
            ServiveButton.Click += ServiveButton_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.PowderBlue;
            panel.Controls.Add(statusStrip1);
            panel.Controls.Add(Guest);
            panel.Controls.Add(ServiveButton);
            panel.Controls.Add(Logout);
            panel.Controls.Add(Room);
            panel.Controls.Add(Payment);
            panel.Controls.Add(Booking);
            panel.Dock = DockStyle.Left;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(200, 450);
            panel.TabIndex = 7;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(200, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 8;
            // 
            // FrontDeskDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrontDeskDashboard";
            Text = "FrontDeskDashboard";
            Load += FrontDeskDashboard_Load_1;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Guest;
        private Button Room;
        private Button Booking;
        private Button Payment;
        private Button Logout;
        private Button ServiveButton;
        private Panel panel;
        private StatusStrip statusStrip1;
        private Panel panel1;
    }
}