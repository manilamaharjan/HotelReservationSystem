namespace HotelReservationSystem
{
    partial class LoginForm
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
            panel1 = new Panel();
            pictureBox = new PictureBox();
            LoginButton = new Button();
            ShowPasswordBox = new CheckBox();
            PasswordBox = new TextBox();
            Password = new Label();
            UsernameBox = new TextBox();
            Username = new Label();
            Login = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(ShowPasswordBox);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(UsernameBox);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(Login);
            panel1.Location = new Point(83, 59);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 336);
            panel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImage = Properties.Resources.loginnnn;
            pictureBox.Image = Properties.Resources.loginnnn;
            pictureBox.Location = new Point(171, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 86);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.RoyalBlue;
            LoginButton.Location = new Point(55, 281);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(164, 36);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ShowPasswordBox
            // 
            ShowPasswordBox.AutoSize = true;
            ShowPasswordBox.BackColor = Color.White;
            ShowPasswordBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordBox.Location = new Point(171, 219);
            ShowPasswordBox.Name = "ShowPasswordBox";
            ShowPasswordBox.Size = new Size(108, 19);
            ShowPasswordBox.TabIndex = 5;
            ShowPasswordBox.Text = "Show Password";
            ShowPasswordBox.UseVisualStyleBackColor = false;
            ShowPasswordBox.CheckedChanged += ShowPasswordBox_CheckedChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(17, 176);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(178, 29);
            PasswordBox.TabIndex = 4;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(13, 148);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(12, 104);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(183, 29);
            UsernameBox.TabIndex = 2;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(13, 65);
            Username.Name = "Username";
            Username.Size = new Size(81, 21);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(65, 25);
            Login.Margin = new Padding(4, 0, 4, 0);
            Login.Name = "Login";
            Login.Size = new Size(58, 21);
            Login.TabIndex = 0;
            Login.Text = "Login!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(440, 440);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Password;
        private TextBox UsernameBox;
        private Label Username;
        private Label Login;
        private PictureBox pictureBox;
        private Button LoginButton;
        private CheckBox ShowPasswordBox;
        private TextBox PasswordBox;
    }
}