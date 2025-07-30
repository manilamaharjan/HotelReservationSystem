namespace HotelReservationSystem
{
    partial class GuestForm
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
            FirstName = new Label();
            LastName = new Label();
            Email = new Label();
            PhoneNumber = new Label();
            Address = new Label();
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            EmailBox = new TextBox();
            PhoneNumberBox = new TextBox();
            AddressBox = new TextBox();
            Add = new Button();
            GuestDataView = new DataGridView();
            guestIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GuestDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(32, 56);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(74, 17);
            FirstName.TabIndex = 0;
            FirstName.Text = "First Name";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(32, 99);
            LastName.Name = "LastName";
            LastName.Size = new Size(74, 17);
            LastName.TabIndex = 1;
            LastName.Text = "Last Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(32, 138);
            Email.Name = "Email";
            Email.Size = new Size(41, 17);
            Email.TabIndex = 2;
            Email.Text = "Email";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(32, 179);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(97, 17);
            PhoneNumber.TabIndex = 3;
            PhoneNumber.Text = "Phone Number";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(32, 225);
            Address.Name = "Address";
            Address.Size = new Size(57, 17);
            Address.TabIndex = 4;
            Address.Text = "Address";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(153, 53);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(218, 25);
            FirstNameBox.TabIndex = 5;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(153, 93);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(218, 25);
            LastNameBox.TabIndex = 6;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(153, 135);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(218, 25);
            EmailBox.TabIndex = 7;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(153, 173);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(218, 25);
            PhoneNumberBox.TabIndex = 8;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(153, 225);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(218, 25);
            AddressBox.TabIndex = 9;
            // 
            // Add
            // 
            Add.BackColor = Color.SkyBlue;
            Add.Location = new Point(371, 274);
            Add.Name = "Add";
            Add.Size = new Size(125, 31);
            Add.TabIndex = 10;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // GuestDataView
            // 
            GuestDataView.AllowUserToDeleteRows = false;
            GuestDataView.AutoGenerateColumns = false;
            GuestDataView.BackgroundColor = Color.AliceBlue;
            GuestDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GuestDataView.Columns.AddRange(new DataGridViewColumn[] { guestIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            GuestDataView.DataSource = guestBindingSource;
            GuestDataView.Location = new Point(3, 327);
            GuestDataView.Name = "GuestDataView";
            GuestDataView.ReadOnly = true;
            GuestDataView.RowHeadersWidth = 51;
            GuestDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GuestDataView.Size = new Size(807, 150);
            GuestDataView.TabIndex = 11;
            GuestDataView.CellContentClick += GuestDataView_CellContentClick;
            // 
            // guestIdDataGridViewTextBoxColumn
            // 
            guestIdDataGridViewTextBoxColumn.DataPropertyName = "GuestId";
            guestIdDataGridViewTextBoxColumn.HeaderText = "GuestId";
            guestIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            guestIdDataGridViewTextBoxColumn.Name = "guestIdDataGridViewTextBoxColumn";
            guestIdDataGridViewTextBoxColumn.ReadOnly = true;
            guestIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // guestBindingSource
            // 
            guestBindingSource.DataSource = typeof(Models.Guest);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_07_26_072905;
            pictureBox1.Location = new Point(611, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(822, 489);
            Controls.Add(pictureBox1);
            Controls.Add(GuestDataView);
            Controls.Add(Add);
            Controls.Add(AddressBox);
            Controls.Add(PhoneNumberBox);
            Controls.Add(EmailBox);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(Address);
            Controls.Add(PhoneNumber);
            Controls.Add(Email);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "GuestForm";
            Text = "GuestForm";
            ((System.ComponentModel.ISupportInitialize)GuestDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstName;
        private Label LastName;
        private Label Email;
        private Label PhoneNumber;
        private Label Address;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private TextBox EmailBox;
        private TextBox PhoneNumberBox;
        private TextBox AddressBox;
        private Button Add;
        private DataGridView GuestDataView;
        private DataGridViewTextBoxColumn guestIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource guestBindingSource;
        private PictureBox pictureBox1;
    }
}