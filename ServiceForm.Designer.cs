namespace HotelReservationSystem
{
    partial class ServiceForm
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
            ServiceName = new Label();
            Price = new Label();
            PriceBox = new TextBox();
            AddButton = new Button();
            serviceBindingSource = new BindingSource(components);
            ServiceTypeBox = new ComboBox();
            ServiceDataView = new DataGridView();
            serviceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // ServiceName
            // 
            ServiceName.AutoSize = true;
            ServiceName.Location = new Point(36, 75);
            ServiceName.Name = "ServiceName";
            ServiceName.Size = new Size(72, 15);
            ServiceName.TabIndex = 0;
            ServiceName.Text = "Service Name";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(46, 125);
            Price.Name = "Price";
            Price.Size = new Size(31, 15);
            Price.TabIndex = 2;
            Price.Text = "Price";
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(150, 122);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(121, 21);
            PriceBox.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SkyBlue;
            AddButton.Location = new Point(161, 167);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(121, 36);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Models.Service);
            // 
            // ServiceTypeBox
            // 
            ServiceTypeBox.FormattingEnabled = true;
            ServiceTypeBox.Location = new Point(150, 67);
            ServiceTypeBox.Name = "ServiceTypeBox";
            ServiceTypeBox.Size = new Size(121, 23);
            ServiceTypeBox.TabIndex = 6;
            // 
            // ServiceDataView
            // 
            ServiceDataView.AllowUserToDeleteRows = false;
            ServiceDataView.AutoGenerateColumns = false;
            ServiceDataView.BackgroundColor = Color.AliceBlue;
            ServiceDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceDataView.Columns.AddRange(new DataGridViewColumn[] { serviceIdDataGridViewTextBoxColumn, serviceNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            ServiceDataView.DataSource = serviceBindingSource1;
            ServiceDataView.Location = new Point(36, 221);
            ServiceDataView.Name = "ServiceDataView";
            ServiceDataView.ReadOnly = true;
            ServiceDataView.Size = new Size(343, 150);
            ServiceDataView.TabIndex = 7;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceBindingSource1
            // 
            serviceBindingSource1.DataSource = typeof(Models.Service);
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(448, 397);
            Controls.Add(ServiceDataView);
            Controls.Add(ServiceTypeBox);
            Controls.Add(AddButton);
            Controls.Add(PriceBox);
            Controls.Add(Price);
            Controls.Add(ServiceName);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ServiceForm";
            Text = "Service Form";
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ServiceName;
        private Label Price;
        private TextBox PriceBox;
        private Button AddButton;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource serviceBindingSource;
        private ComboBox ServiceTypeBox;
        private DataGridView ServiceDataView;
        private DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource serviceBindingSource1;
    }
}