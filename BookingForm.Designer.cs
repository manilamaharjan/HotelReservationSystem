namespace HotelReservationSystem
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guest = new Label();
            GuestBox = new ComboBox();
            CheckInDate = new Label();
            CheckInDatePicker = new DateTimePicker();
            CheckOutDate = new Label();
            CheckOutDatePicker = new DateTimePicker();
            SearchButton = new Button();
            AvailableRooms = new Label();
            BookButton = new Button();
            ServiceLabel = new Label();
            bookingBindingSource = new BindingSource(components);
            bookingRoomBindingSource = new BindingSource(components);
            AvailableRoomBox = new ComboBox();
            ServiceBox = new ComboBox();
            bookingServiceBindingSource = new BindingSource(components);
            BookingDataView = new DataGridView();
            bookingIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingRoomsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingServicesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingRoomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookingDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Guest
            // 
            Guest.AutoSize = true;
            Guest.Location = new Point(48, 29);
            Guest.Name = "Guest";
            Guest.Size = new Size(36, 15);
            Guest.TabIndex = 0;
            Guest.Text = "Guest";
            // 
            // GuestBox
            // 
            GuestBox.FormattingEnabled = true;
            GuestBox.Location = new Point(151, 29);
            GuestBox.Name = "GuestBox";
            GuestBox.Size = new Size(121, 23);
            GuestBox.TabIndex = 1;
            // 
            // CheckInDate
            // 
            CheckInDate.AutoSize = true;
            CheckInDate.Location = new Point(48, 67);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Size = new Size(76, 15);
            CheckInDate.TabIndex = 2;
            CheckInDate.Text = "Check In Date";
            // 
            // CheckInDatePicker
            // 
            CheckInDatePicker.Location = new Point(151, 67);
            CheckInDatePicker.Name = "CheckInDatePicker";
            CheckInDatePicker.Size = new Size(200, 21);
            CheckInDatePicker.TabIndex = 3;
            // 
            // CheckOutDate
            // 
            CheckOutDate.AutoSize = true;
            CheckOutDate.Location = new Point(48, 94);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new Size(85, 15);
            CheckOutDate.TabIndex = 4;
            CheckOutDate.Text = "Check Out Date";
            // 
            // CheckOutDatePicker
            // 
            CheckOutDatePicker.Location = new Point(151, 94);
            CheckOutDatePicker.Name = "CheckOutDatePicker";
            CheckOutDatePicker.Size = new Size(200, 21);
            CheckOutDatePicker.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(48, 131);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // AvailableRooms
            // 
            AvailableRooms.AutoSize = true;
            AvailableRooms.Location = new Point(48, 170);
            AvailableRooms.Name = "AvailableRooms";
            AvailableRooms.Size = new Size(88, 15);
            AvailableRooms.TabIndex = 7;
            AvailableRooms.Text = "Available Rooms";
            // 
            // BookButton
            // 
            BookButton.Location = new Point(47, 256);
            BookButton.Name = "BookButton";
            BookButton.Size = new Size(75, 23);
            BookButton.TabIndex = 9;
            BookButton.Text = "Book";
            BookButton.UseVisualStyleBackColor = true;
            BookButton.Click += BookButton_Click;
            // 
            // ServiceLabel
            // 
            ServiceLabel.AutoSize = true;
            ServiceLabel.Location = new Point(47, 211);
            ServiceLabel.Name = "ServiceLabel";
            ServiceLabel.Size = new Size(77, 15);
            ServiceLabel.TabIndex = 11;
            ServiceLabel.Text = "Select Services";
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.CurrentChanged += bookingBindingSource_CurrentChanged;
            // 
            // bookingRoomBindingSource
            // 
            bookingRoomBindingSource.DataSource = typeof(Models.BookingRoom);
            // 
            // AvailableRoomBox
            // 
            AvailableRoomBox.FormattingEnabled = true;
            AvailableRoomBox.Location = new Point(195, 158);
            AvailableRoomBox.Name = "AvailableRoomBox";
            AvailableRoomBox.Size = new Size(121, 23);
            AvailableRoomBox.TabIndex = 12;
            // 
            // ServiceBox
            // 
            ServiceBox.FormattingEnabled = true;
            ServiceBox.Location = new Point(195, 211);
            ServiceBox.Name = "ServiceBox";
            ServiceBox.Size = new Size(121, 23);
            ServiceBox.TabIndex = 13;
            // 
            // bookingServiceBindingSource
            // 
            bookingServiceBindingSource.DataSource = typeof(Models.BookingService);
            // 
            // BookingDataView
            // 
            BookingDataView.AllowUserToDeleteRows = false;
            BookingDataView.AutoGenerateColumns = false;
            BookingDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingDataView.Columns.AddRange(new DataGridViewColumn[] { bookingIdDataGridViewTextBoxColumn, guestIdDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn, guestDataGridViewTextBoxColumn, bookingRoomsDataGridViewTextBoxColumn, bookingServicesDataGridViewTextBoxColumn, paymentDataGridViewTextBoxColumn });
            BookingDataView.DataSource = bookingBindingSource1;
            BookingDataView.Location = new Point(32, 288);
            BookingDataView.Name = "BookingDataView";
            BookingDataView.ReadOnly = true;
            BookingDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingDataView.Size = new Size(843, 150);
            BookingDataView.TabIndex = 14;
            // 
            // bookingIdDataGridViewTextBoxColumn
            // 
            bookingIdDataGridViewTextBoxColumn.DataPropertyName = "BookingId";
            bookingIdDataGridViewTextBoxColumn.HeaderText = "BookingId";
            bookingIdDataGridViewTextBoxColumn.Name = "bookingIdDataGridViewTextBoxColumn";
            bookingIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestIdDataGridViewTextBoxColumn
            // 
            guestIdDataGridViewTextBoxColumn.DataPropertyName = "GuestId";
            guestIdDataGridViewTextBoxColumn.HeaderText = "GuestId";
            guestIdDataGridViewTextBoxColumn.Name = "guestIdDataGridViewTextBoxColumn";
            guestIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            checkInDataGridViewTextBoxColumn.HeaderText = "CheckIn";
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            checkOutDataGridViewTextBoxColumn.HeaderText = "CheckOut";
            checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestDataGridViewTextBoxColumn
            // 
            guestDataGridViewTextBoxColumn.DataPropertyName = "Guest";
            guestDataGridViewTextBoxColumn.HeaderText = "Guest";
            guestDataGridViewTextBoxColumn.Name = "guestDataGridViewTextBoxColumn";
            guestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingRoomsDataGridViewTextBoxColumn
            // 
            bookingRoomsDataGridViewTextBoxColumn.DataPropertyName = "BookingRooms";
            bookingRoomsDataGridViewTextBoxColumn.HeaderText = "BookingRooms";
            bookingRoomsDataGridViewTextBoxColumn.Name = "bookingRoomsDataGridViewTextBoxColumn";
            bookingRoomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingServicesDataGridViewTextBoxColumn
            // 
            bookingServicesDataGridViewTextBoxColumn.DataPropertyName = "BookingServices";
            bookingServicesDataGridViewTextBoxColumn.HeaderText = "BookingServices";
            bookingServicesDataGridViewTextBoxColumn.Name = "bookingServicesDataGridViewTextBoxColumn";
            bookingServicesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingBindingSource1
            // 
            bookingBindingSource1.DataSource = typeof(Models.Booking);
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(901, 450);
            Controls.Add(BookingDataView);
            Controls.Add(ServiceBox);
            Controls.Add(AvailableRoomBox);
            Controls.Add(BookButton);
            Controls.Add(ServiceLabel);
            Controls.Add(AvailableRooms);
            Controls.Add(SearchButton);
            Controls.Add(CheckOutDatePicker);
            Controls.Add(CheckOutDate);
            Controls.Add(CheckInDatePicker);
            Controls.Add(CheckInDate);
            Controls.Add(GuestBox);
            Controls.Add(Guest);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingRoomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookingDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Guest;
        private ComboBox GuestBox;
        private Label CheckInDate;
        private DateTimePicker CheckInDatePicker;
        private Label CheckOutDate;
        private DateTimePicker CheckOutDatePicker;
        private Button SearchButton;
        private Label AvailableRooms;
        private Button BookButton;
        private Label ServiceLabel;
        private BindingSource bookingBindingSource;
        private BindingSource bookingRoomBindingSource;
        private ComboBox AvailableRoomBox;
        private ComboBox ServiceBox;
        private BindingSource bookingServiceBindingSource;
        private DataGridView BookingDataView;
        private DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn guestIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn guestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingRoomsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingServicesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private BindingSource bookingBindingSource1;
    }
}
