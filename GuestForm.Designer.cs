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
            ((System.ComponentModel.ISupportInitialize)GuestDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(32, 56);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(61, 15);
            FirstName.TabIndex = 0;
            FirstName.Text = "First Name";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(32, 99);
            LastName.Name = "LastName";
            LastName.Size = new Size(59, 15);
            LastName.TabIndex = 1;
            LastName.Text = "Last Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(32, 138);
            Email.Name = "Email";
            Email.Size = new Size(34, 15);
            Email.TabIndex = 2;
            Email.Text = "Email";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(32, 179);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(79, 15);
            PhoneNumber.TabIndex = 3;
            PhoneNumber.Text = "Phone Number";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(32, 225);
            Address.Name = "Address";
            Address.Size = new Size(47, 15);
            Address.TabIndex = 4;
            Address.Text = "Address";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(153, 53);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(100, 21);
            FirstNameBox.TabIndex = 5;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(153, 93);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(100, 21);
            LastNameBox.TabIndex = 6;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(153, 135);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(100, 21);
            EmailBox.TabIndex = 7;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(153, 173);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(100, 21);
            PhoneNumberBox.TabIndex = 8;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(153, 225);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(100, 21);
            AddressBox.TabIndex = 9;
            // 
            // Add
            // 
            Add.BackColor = Color.SkyBlue;
            Add.Location = new Point(292, 268);
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
            GuestDataView.Location = new Point(12, 327);
            GuestDataView.Name = "GuestDataView";
            GuestDataView.ReadOnly = true;
            GuestDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GuestDataView.Size = new Size(644, 150);
            GuestDataView.TabIndex = 11;
            GuestDataView.CellContentClick += GuestDataView_CellContentClick;
            // 
            // guestIdDataGridViewTextBoxColumn
            // 
            guestIdDataGridViewTextBoxColumn.DataPropertyName = "GuestId";
            guestIdDataGridViewTextBoxColumn.HeaderText = "GuestId";
            guestIdDataGridViewTextBoxColumn.Name = "guestIdDataGridViewTextBoxColumn";
            guestIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestBindingSource
            // 
            guestBindingSource.DataSource = typeof(Models.Guest);
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(678, 450);
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
    }
}