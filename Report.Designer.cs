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
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ReportType
            // 
            ReportType.AutoSize = true;
            ReportType.Location = new Point(41, 48);
            ReportType.Name = "ReportType";
            ReportType.Size = new Size(70, 15);
            ReportType.TabIndex = 0;
            ReportType.Text = "Report Type";
            // 
            // ReportTypeBox
            // 
            ReportTypeBox.FormattingEnabled = true;
            ReportTypeBox.Location = new Point(180, 48);
            ReportTypeBox.Name = "ReportTypeBox";
            ReportTypeBox.Size = new Size(121, 23);
            ReportTypeBox.TabIndex = 1;
            // 
            // StartDate
            // 
            StartDate.AutoSize = true;
            StartDate.Location = new Point(39, 111);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(56, 15);
            StartDate.TabIndex = 2;
            StartDate.Text = "Start Date";
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(172, 110);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(200, 21);
            StartDatePicker.TabIndex = 3;
            // 
            // EndDate
            // 
            EndDate.AutoSize = true;
            EndDate.Location = new Point(39, 162);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(52, 15);
            EndDate.TabIndex = 4;
            EndDate.Text = "End Date";
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(173, 165);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(200, 21);
            EndDatePicker.TabIndex = 5;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(64, 218);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(75, 23);
            GenerateButton.TabIndex = 6;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Models.Service);
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
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
    }
}