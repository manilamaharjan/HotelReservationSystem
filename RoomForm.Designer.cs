namespace HotelReservationSystem
{
    partial class RoomForm
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
            RoomNumber = new Label();
            RoomType = new Label();
            PricePerNight = new Label();
            AvailabilityStatus = new Label();
            RoomNumberBox = new ComboBox();
            RoomTypeBox = new ComboBox();
            PriceBox = new TextBox();
            AvailabilityBox = new ComboBox();
            AddButton = new Button();
            EditButton = new Button();
            RoomDataView = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            roomTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            roomBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)RoomDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            SuspendLayout();
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Location = new Point(40, 50);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(78, 15);
            RoomNumber.TabIndex = 0;
            RoomNumber.Text = "Room Number";
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Location = new Point(40, 91);
            RoomType.Name = "RoomType";
            RoomType.Size = new Size(65, 15);
            RoomType.TabIndex = 1;
            RoomType.Text = "Room Type";
            // 
            // PricePerNight
            // 
            PricePerNight.AutoSize = true;
            PricePerNight.Location = new Point(40, 139);
            PricePerNight.Name = "PricePerNight";
            PricePerNight.Size = new Size(80, 15);
            PricePerNight.TabIndex = 2;
            PricePerNight.Text = "Price Per Night";
            // 
            // AvailabilityStatus
            // 
            AvailabilityStatus.AutoSize = true;
            AvailabilityStatus.Location = new Point(40, 181);
            AvailabilityStatus.Name = "AvailabilityStatus";
            AvailabilityStatus.Size = new Size(96, 15);
            AvailabilityStatus.TabIndex = 3;
            AvailabilityStatus.Text = "Availability Status";
            // 
            // RoomNumberBox
            // 
            RoomNumberBox.FormattingEnabled = true;
            RoomNumberBox.Location = new Point(177, 42);
            RoomNumberBox.Name = "RoomNumberBox";
            RoomNumberBox.Size = new Size(121, 23);
            RoomNumberBox.TabIndex = 4;
            RoomNumberBox.SelectedIndexChanged += RoomNumberBox_SelectedIndexChanged;
            // 
            // RoomTypeBox
            // 
            RoomTypeBox.FormattingEnabled = true;
            RoomTypeBox.Location = new Point(177, 88);
            RoomTypeBox.Name = "RoomTypeBox";
            RoomTypeBox.Size = new Size(121, 23);
            RoomTypeBox.TabIndex = 5;
            RoomTypeBox.SelectedIndexChanged += RoomTypeBox_SelectedIndexChanged;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(177, 133);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(121, 21);
            PriceBox.TabIndex = 6;
            PriceBox.TextChanged += PriceBox_TextChanged;
            // 
            // AvailabilityBox
            // 
            AvailabilityBox.FormattingEnabled = true;
            AvailabilityBox.Location = new Point(177, 173);
            AvailabilityBox.Name = "AvailabilityBox";
            AvailabilityBox.Size = new Size(121, 23);
            AvailabilityBox.TabIndex = 7;
            AvailabilityBox.SelectedIndexChanged += AvailabilityBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SkyBlue;
            AddButton.Location = new Point(73, 216);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(143, 39);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.SkyBlue;
            EditButton.Location = new Point(379, 216);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(137, 39);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // RoomDataView
            // 
            RoomDataView.AllowUserToDeleteRows = false;
            RoomDataView.AutoGenerateColumns = false;
            RoomDataView.BackgroundColor = Color.AliceBlue;
            RoomDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomDataView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, roomTypeDataGridViewTextBoxColumn, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            RoomDataView.DataSource = roomBindingSource;
            RoomDataView.Location = new Point(12, 261);
            RoomDataView.Name = "RoomDataView";
            RoomDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RoomDataView.Size = new Size(533, 150);
            RoomDataView.TabIndex = 10;
            RoomDataView.CellContentClick += RoomDataView_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "RoomId";
            dataGridViewTextBoxColumn2.HeaderText = "RoomId";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "RoomNumber";
            dataGridViewTextBoxColumn3.HeaderText = "RoomNumber";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "PricePerNight";
            dataGridViewTextBoxColumn4.HeaderText = "PricePerNight";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Availability";
            dataGridViewTextBoxColumn5.HeaderText = "Availability";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Models.Room);
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(599, 422);
            Controls.Add(RoomDataView);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(AvailabilityBox);
            Controls.Add(PriceBox);
            Controls.Add(RoomTypeBox);
            Controls.Add(RoomNumberBox);
            Controls.Add(AvailabilityStatus);
            Controls.Add(PricePerNight);
            Controls.Add(RoomType);
            Controls.Add(RoomNumber);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "RoomForm";
            Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)RoomDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoomNumber;
        private Label RoomType;
        private Label PricePerNight;
        private Label AvailabilityStatus;
        private ComboBox RoomNumberBox;
        private ComboBox RoomTypeBox;
        private TextBox PriceBox;
        private ComboBox AvailabilityBox;
        private Button AddButton;
        private Button EditButton;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerNightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private DataGridView RoomDataView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource roomBindingSource;
    }
}