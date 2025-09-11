
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(538, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 135);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(showBtn);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TBPassword);
            panel1.Controls.Add(TBUsername);
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(361, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 360);
            panel1.TabIndex = 1;
            // 
            // showBtn
            // 
            showBtn.BackColor = Color.Transparent;
            showBtn.FlatStyle = FlatStyle.Popup;
            showBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBtn.ForeColor = Color.Firebrick;
            showBtn.Location = new Point(544, 188);
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
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Firebrick;
            btnLogin.Location = new Point(313, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 52);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += Loginbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(330, 220);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(325, 134);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(92, 190);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(546, 27);
            TBPassword.TabIndex = 2;
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(92, 104);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(546, 27);
            TBUsername.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Firebrick;
            lblLogin.Location = new Point(269, 30);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(209, 38);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "ADMIN LOGIN";
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.Firebrick;
            btnBack.FlatAppearance.BorderSize = 3;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(64, 64, 64);
            btnBack.Location = new Point(42, 779);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 49);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Backbtn_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1482, 853);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdminLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}