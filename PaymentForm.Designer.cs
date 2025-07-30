namespace HotelReservationSystem
{
    partial class PaymentForm
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
            components = new System.ComponentModel.Container();
            Booking = new Label();
            BookingBox = new ComboBox();
            RoomTotal = new Label();
            ServiceTotal = new Label();
            TotalAmount = new Label();
            Calculate = new Button();
            Pay = new Button();
            paymentBindingSource = new BindingSource(components);
            PaymentMethod = new Label();
            PaymentMethodBox = new ComboBox();
            PaymentDataView = new DataGridView();
            paymentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDataView).BeginInit();
            SuspendLayout();
            // 
            // Booking
            // 
            Booking.AutoSize = true;
            Booking.Location = new Point(43, 42);
            Booking.Name = "Booking";
            Booking.Size = new Size(47, 15);
            Booking.TabIndex = 0;
            Booking.Text = "Booking";
            // 
            // BookingBox
            // 
            BookingBox.FormattingEnabled = true;
            BookingBox.Location = new Point(163, 42);
            BookingBox.Name = "BookingBox";
            BookingBox.Size = new Size(121, 23);
            BookingBox.TabIndex = 1;
            // 
            // RoomTotal
            // 
            RoomTotal.AutoSize = true;
            RoomTotal.Location = new Point(43, 89);
            RoomTotal.Name = "RoomTotal";
            RoomTotal.Size = new Size(64, 15);
            RoomTotal.TabIndex = 3;
            RoomTotal.Text = "Room Total";
            // 
            // ServiceTotal
            // 
            ServiceTotal.AutoSize = true;
            ServiceTotal.Location = new Point(43, 129);
            ServiceTotal.Name = "ServiceTotal";
            ServiceTotal.Size = new Size(69, 15);
            ServiceTotal.TabIndex = 4;
            ServiceTotal.Text = "Service Total";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.Location = new Point(43, 166);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(74, 15);
            TotalAmount.TabIndex = 5;
            TotalAmount.Text = "Total Amount";
            // 
            // Calculate
            // 
            Calculate.BackColor = Color.SkyBlue;
            Calculate.Location = new Point(43, 260);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(139, 43);
            Calculate.TabIndex = 6;
            Calculate.Text = "Calulate";
            Calculate.UseVisualStyleBackColor = false;
            Calculate.Click += Calculate_Click;
            // 
            // Pay
            // 
            Pay.BackColor = Color.SkyBlue;
            Pay.Location = new Point(260, 260);
            Pay.Name = "Pay";
            Pay.Size = new Size(142, 43);
            Pay.TabIndex = 7;
            Pay.Text = "Pay";
            Pay.UseVisualStyleBackColor = false;
            Pay.Click += Pay_Click;
            // 
            // paymentBindingSource
            // 
            paymentBindingSource.DataSource = typeof(Models.Payment);
            // 
            // PaymentMethod
            // 
            PaymentMethod.AutoSize = true;
            PaymentMethod.Location = new Point(43, 205);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(92, 15);
            PaymentMethod.TabIndex = 9;
            PaymentMethod.Text = "Payment Method";
            // 
            // PaymentMethodBox
            // 
            PaymentMethodBox.FormattingEnabled = true;
            PaymentMethodBox.Location = new Point(163, 197);
            PaymentMethodBox.Name = "PaymentMethodBox";
            PaymentMethodBox.Size = new Size(121, 23);
            PaymentMethodBox.TabIndex = 10;
            // 
            // PaymentDataView
            // 
            PaymentDataView.AllowUserToDeleteRows = false;
            PaymentDataView.AutoGenerateColumns = false;
            PaymentDataView.BackgroundColor = Color.AliceBlue;
            PaymentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDataView.Columns.AddRange(new DataGridViewColumn[] { paymentIdDataGridViewTextBoxColumn, bookingIdDataGridViewTextBoxColumn, totalAmountDataGridViewTextBoxColumn, paymentDateDataGridViewTextBoxColumn, paymentMethodDataGridViewTextBoxColumn, bookingDataGridViewTextBoxColumn });
            PaymentDataView.DataSource = paymentBindingSource;
            PaymentDataView.Location = new Point(21, 309);
            PaymentDataView.Name = "PaymentDataView";
            PaymentDataView.ReadOnly = true;
            PaymentDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PaymentDataView.Size = new Size(636, 150);
            PaymentDataView.TabIndex = 11;
            // 
            // paymentIdDataGridViewTextBoxColumn
            // 
            paymentIdDataGridViewTextBoxColumn.DataPropertyName = "PaymentId";
            paymentIdDataGridViewTextBoxColumn.HeaderText = "PaymentId";
            paymentIdDataGridViewTextBoxColumn.Name = "paymentIdDataGridViewTextBoxColumn";
            paymentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingIdDataGridViewTextBoxColumn
            // 
            bookingIdDataGridViewTextBoxColumn.DataPropertyName = "BookingId";
            bookingIdDataGridViewTextBoxColumn.HeaderText = "BookingId";
            bookingIdDataGridViewTextBoxColumn.Name = "bookingIdDataGridViewTextBoxColumn";
            bookingIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingDataGridViewTextBoxColumn
            // 
            bookingDataGridViewTextBoxColumn.DataPropertyName = "Booking";
            bookingDataGridViewTextBoxColumn.HeaderText = "Booking";
            bookingDataGridViewTextBoxColumn.Name = "bookingDataGridViewTextBoxColumn";
            bookingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(684, 450);
            Controls.Add(PaymentDataView);
            Controls.Add(PaymentMethodBox);
            Controls.Add(PaymentMethod);
            Controls.Add(Pay);
            Controls.Add(Calculate);
            Controls.Add(TotalAmount);
            Controls.Add(ServiceTotal);
            Controls.Add(RoomTotal);
            Controls.Add(BookingBox);
            Controls.Add(Booking);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Booking;
        private ComboBox BookingBox;
        private Label RoomTotal;
        private Label ServiceTotal;
        private Label TotalAmount;
        private Button Calculate;
        private Button Pay;
        private BindingSource paymentBindingSource;
        private Label PaymentMethod;
        private ComboBox PaymentMethodBox;
        private DataGridView PaymentDataView;
        private DataGridViewTextBoxColumn paymentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingDataGridViewTextBoxColumn;
    }
}