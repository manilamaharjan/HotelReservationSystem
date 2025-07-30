namespace HotelReservationSystem
{
    partial class Report
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
            ReportType = new Label();
            ReportTypeBox = new ComboBox();
            StartDate = new Label();
            StartDatePicker = new DateTimePicker();
            EndDate = new Label();
            EndDatePicker = new DateTimePicker();
            GenerateButton = new Button();
            serviceBindingSource = new BindingSource(components);
            SummaryDataView = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SummaryDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ReportType
            // 
            ReportType.AutoSize = true;
            ReportType.Location = new Point(41, 48);
            ReportType.Name = "ReportType";
            ReportType.Size = new Size(81, 17);
            ReportType.TabIndex = 0;
            ReportType.Text = "Report Type";
            // 
            // ReportTypeBox
            // 
            ReportTypeBox.FormattingEnabled = true;
            ReportTypeBox.Location = new Point(172, 48);
            ReportTypeBox.Name = "ReportTypeBox";
            ReportTypeBox.Size = new Size(121, 25);
            ReportTypeBox.TabIndex = 1;
            // 
            // StartDate
            // 
            StartDate.AutoSize = true;
            StartDate.Location = new Point(39, 111);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(69, 17);
            StartDate.TabIndex = 2;
            StartDate.Text = "Start Date";
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(172, 110);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(237, 25);
            StartDatePicker.TabIndex = 3;
            // 
            // EndDate
            // 
            EndDate.AutoSize = true;
            EndDate.Location = new Point(39, 162);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(64, 17);
            EndDate.TabIndex = 4;
            EndDate.Text = "End Date";
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(172, 162);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(237, 25);
            EndDatePicker.TabIndex = 5;
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.SkyBlue;
            GenerateButton.Location = new Point(143, 209);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(115, 35);
            GenerateButton.TabIndex = 6;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Models.Service);
            // 
            // SummaryDataView
            // 
            SummaryDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SummaryDataView.BackgroundColor = Color.AliceBlue;
            SummaryDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SummaryDataView.Location = new Point(12, 250);
            SummaryDataView.Name = "SummaryDataView";
            SummaryDataView.ReadOnly = true;
            SummaryDataView.RowHeadersWidth = 51;
            SummaryDataView.Size = new Size(464, 188);
            SummaryDataView.TabIndex = 7;
            SummaryDataView.CellContentClick += SummaryDataView_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_07_26_072905;
            pictureBox1.Location = new Point(417, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(554, 450);
            Controls.Add(pictureBox1);
            Controls.Add(SummaryDataView);
            Controls.Add(GenerateButton);
            Controls.Add(EndDatePicker);
            Controls.Add(EndDate);
            Controls.Add(StartDatePicker);
            Controls.Add(StartDate);
            Controls.Add(ReportTypeBox);
            Controls.Add(ReportType);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Report";
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)SummaryDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReportType;
        private ComboBox ReportTypeBox;
        private Label StartDate;
        private DateTimePicker StartDatePicker;
        private Label EndDate;
        private DateTimePicker EndDatePicker;
        private Button GenerateButton;
        private BindingSource serviceBindingSource;
        private DataGridView SummaryDataView;
        private PictureBox pictureBox1;
    }
}