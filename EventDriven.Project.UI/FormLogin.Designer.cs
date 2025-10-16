
namespace EventDriven.Project.UI
{
    partial class FormLogin
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
            showBtn = new Button();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            TBPassword = new TextBox();
            TBUsername = new TextBox();
            lblLogin = new Label();
            btnBack = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(53, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 135);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(showBtn);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TBPassword);
            panel1.Controls.Add(TBUsername);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(429, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 516);
            panel1.TabIndex = 1;
            // 
            // showBtn
            // 
            showBtn.BackColor = Color.Transparent;
            showBtn.FlatStyle = FlatStyle.System;
            showBtn.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBtn.ForeColor = Color.Firebrick;
            showBtn.Location = new Point(544, 337);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(94, 29);
            showBtn.TabIndex = 3;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = false;
            showBtn.Click += showBtn_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatAppearance.BorderSize = 3;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Firebrick;
            btnLogin.Location = new Point(307, 427);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 52);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += Loginbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(325, 376);
            label3.Name = "label3";
            label3.Size = new Size(97, 26);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(325, 296);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(92, 339);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(546, 27);
            TBPassword.TabIndex = 2;
            TBPassword.TextChanged += TBPassword_TextChanged;
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(92, 257);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(546, 27);
            TBUsername.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Firebrick;
            lblLogin.Location = new Point(279, 203);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(188, 39);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Admin Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.Firebrick;
            btnBack.FlatAppearance.BorderSize = 3;
            btnBack.FlatStyle = FlatStyle.System;
            btnBack.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(64, 64, 64);
            btnBack.Location = new Point(33, 1019);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 49);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Backbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1919, 112);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(340, 30);
            label1.Name = "label1";
            label1.Size = new Size(275, 49);
            label1.TabIndex = 6;
            label1.Text = "ACADEMY INC.";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, -14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 126);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(119, 30);
            label4.Name = "label4";
            label4.Size = new Size(234, 49);
            label4.TabIndex = 0;
            label4.Text = "ROSEWOOD ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(126, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(481, 154);
            panel3.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdminLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblLogin;
        private Label label2;
        private TextBox TBPassword;
        private TextBox TBUsername;
        private Button btnLogin;
        private Label label3;
        private Button btnBack;
        private Button showBtn;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel3;
    }
}