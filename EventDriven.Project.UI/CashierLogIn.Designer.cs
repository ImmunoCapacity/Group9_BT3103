namespace EventDriven.Project.UI
{
    partial class CashierLogIn
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
            CashierbtnLogin = new Button();
            label2 = new Label();
            CashierInputPassword = new TextBox();
            Username = new Label();
            label1 = new Label();
            CashierInputUser = new TextBox();
            pictureBox1 = new PictureBox();
            CashierbtnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(CashierbtnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CashierInputPassword);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CashierInputUser);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(263, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 338);
            panel1.TabIndex = 3;
            // 
            // CashierbtnLogin
            // 
            CashierbtnLogin.FlatAppearance.BorderColor = Color.Firebrick;
            CashierbtnLogin.FlatAppearance.BorderSize = 2;
            CashierbtnLogin.FlatStyle = FlatStyle.Flat;
            CashierbtnLogin.ForeColor = Color.Gray;
            CashierbtnLogin.Location = new Point(280, 263);
            CashierbtnLogin.Name = "CashierbtnLogin";
            CashierbtnLogin.Size = new Size(118, 54);
            CashierbtnLogin.TabIndex = 2;
            CashierbtnLogin.Text = "Login";
            CashierbtnLogin.UseVisualStyleBackColor = true;
            CashierbtnLogin.Click += CashierbtnLogin_Click;
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
            // 
            // CashierInputPassword
            // 
            CashierInputPassword.BackColor = Color.LightGray;
            CashierInputPassword.Location = new Point(71, 149);
            CashierInputPassword.Name = "CashierInputPassword";
            CashierInputPassword.Size = new Size(542, 34);
            CashierInputPassword.TabIndex = 3;
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
            label1.Location = new Point(229, 27);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 1;
            label1.Text = "CASHIER LOGIN";
            // 
            // CashierInputUser
            // 
            CashierInputUser.BackColor = Color.LightGray;
            CashierInputUser.Location = new Point(71, 77);
            CashierInputUser.Name = "CashierInputUser";
            CashierInputUser.Size = new Size(542, 34);
            CashierInputUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_09_07_155916_removebg_preview;
            pictureBox1.Location = new Point(436, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 127);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CashierbtnBack
            // 
            CashierbtnBack.FlatAppearance.BorderColor = Color.Firebrick;
            CashierbtnBack.FlatAppearance.BorderSize = 2;
            CashierbtnBack.FlatStyle = FlatStyle.Flat;
            CashierbtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashierbtnBack.ForeColor = Color.White;
            CashierbtnBack.Location = new Point(76, 668);
            CashierbtnBack.Name = "CashierbtnBack";
            CashierbtnBack.Size = new Size(118, 54);
            CashierbtnBack.TabIndex = 5;
            CashierbtnBack.Text = "Back";
            CashierbtnBack.UseVisualStyleBackColor = true;
            // 
            // CashierLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1182, 753);
            Controls.Add(CashierbtnBack);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "CashierLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierLogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CashierbtnLogin;
        private Label label2;
        private TextBox CashierInputPassword;
        private Label Username;
        private Label label1;
        private TextBox CashierInputUser;
        private PictureBox pictureBox1;
        private Button CashierbtnBack;
    }
}