namespace EventDriven.Project.UI
{
    partial class AdminLogIn
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            AdminbtnLogin = new Button();
            label2 = new Label();
            AdminInputPassword = new TextBox();
            Username = new Label();
            label1 = new Label();
            AdminInputUser = new TextBox();
            AdminbtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_09_07_155916_removebg_preview;
            pictureBox1.Location = new Point(418, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 127);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(AdminbtnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AdminInputPassword);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AdminInputUser);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.WindowText;
            panel1.Location = new Point(260, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 338);
            panel1.TabIndex = 1;
            // 
            // AdminbtnLogin
            // 
            AdminbtnLogin.FlatAppearance.BorderColor = Color.Firebrick;
            AdminbtnLogin.FlatAppearance.BorderSize = 2;
            AdminbtnLogin.FlatStyle = FlatStyle.Flat;
            AdminbtnLogin.ForeColor = Color.Gray;
            AdminbtnLogin.Location = new Point(280, 263);
            AdminbtnLogin.Name = "AdminbtnLogin";
            AdminbtnLogin.Size = new Size(118, 54);
            AdminbtnLogin.TabIndex = 2;
            AdminbtnLogin.Text = "Login";
            AdminbtnLogin.UseVisualStyleBackColor = true;
            AdminbtnLogin.Click += AdminbtnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(291, 186);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // AdminInputPassword
            // 
            AdminInputPassword.BackColor = Color.LightGray;
            AdminInputPassword.Location = new Point(71, 149);
            AdminInputPassword.Name = "AdminInputPassword";
            AdminInputPassword.Size = new Size(542, 34);
            AdminInputPassword.TabIndex = 3;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.Gray;
            Username.Location = new Point(291, 114);
            Username.Name = "Username";
            Username.Size = new Size(97, 25);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(243, 24);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 1;
            label1.Text = "ADMIN LOGIN";
            // 
            // AdminInputUser
            // 
            AdminInputUser.BackColor = Color.LightGray;
            AdminInputUser.Location = new Point(71, 77);
            AdminInputUser.Name = "AdminInputUser";
            AdminInputUser.Size = new Size(542, 34);
            AdminInputUser.TabIndex = 0;
            // 
            // AdminbtnBack
            // 
            AdminbtnBack.FlatAppearance.BorderColor = Color.Firebrick;
            AdminbtnBack.FlatAppearance.BorderSize = 2;
            AdminbtnBack.FlatStyle = FlatStyle.Flat;
            AdminbtnBack.Location = new Point(67, 675);
            AdminbtnBack.Name = "AdminbtnBack";
            AdminbtnBack.Size = new Size(118, 54);
            AdminbtnBack.TabIndex = 5;
            AdminbtnBack.Text = "Back";
            AdminbtnBack.UseVisualStyleBackColor = true;
            // 
            // AdminLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1182, 753);
            Controls.Add(AdminbtnBack);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "AdminLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox AdminInputUser;
        private TextBox AdminInputPassword;
        private Label Username;
        private Label label2;
        private Button AdminbtnLogin;
        private Button AdminbtnBack;
    }
}