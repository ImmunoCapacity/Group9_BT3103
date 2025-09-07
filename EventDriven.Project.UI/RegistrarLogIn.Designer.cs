namespace EventDriven.Project.UI
{
    partial class RegistrarLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLogIn));
            panel1 = new Panel();
            RegistrarbtnLogin = new Button();
            label2 = new Label();
            RegistrarInputPassword = new TextBox();
            Username = new Label();
            label1 = new Label();
            RegistrarInputUser = new TextBox();
            pictureBox1 = new PictureBox();
            RegistrarbtnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(RegistrarbtnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RegistrarInputPassword);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(RegistrarInputUser);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(260, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 338);
            panel1.TabIndex = 5;
            // 
            // RegistrarbtnLogin
            // 
            RegistrarbtnLogin.FlatAppearance.BorderColor = Color.Firebrick;
            RegistrarbtnLogin.FlatAppearance.BorderSize = 2;
            RegistrarbtnLogin.FlatStyle = FlatStyle.Flat;
            RegistrarbtnLogin.ForeColor = Color.Gray;
            RegistrarbtnLogin.Location = new Point(280, 263);
            RegistrarbtnLogin.Name = "RegistrarbtnLogin";
            RegistrarbtnLogin.Size = new Size(118, 54);
            RegistrarbtnLogin.TabIndex = 2;
            RegistrarbtnLogin.Text = "Login";
            RegistrarbtnLogin.UseVisualStyleBackColor = true;
            RegistrarbtnLogin.Click += RegistrarbtnLogin_Click;
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
            // RegistrarInputPassword
            // 
            RegistrarInputPassword.BackColor = Color.LightGray;
            RegistrarInputPassword.Location = new Point(71, 149);
            RegistrarInputPassword.Name = "RegistrarInputPassword";
            RegistrarInputPassword.Size = new Size(542, 34);
            RegistrarInputPassword.TabIndex = 3;
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
            label1.Location = new Point(212, 22);
            label1.Name = "label1";
            label1.Size = new Size(260, 38);
            label1.TabIndex = 1;
            label1.Text = "REGISTRAR LOGIN";
            // 
            // RegistrarInputUser
            // 
            RegistrarInputUser.BackColor = Color.LightGray;
            RegistrarInputUser.Location = new Point(71, 77);
            RegistrarInputUser.Name = "RegistrarInputUser";
            RegistrarInputUser.Size = new Size(542, 34);
            RegistrarInputUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 127);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // RegistrarbtnBack
            // 
            RegistrarbtnBack.FlatAppearance.BorderColor = Color.Firebrick;
            RegistrarbtnBack.FlatAppearance.BorderSize = 2;
            RegistrarbtnBack.FlatStyle = FlatStyle.Flat;
            RegistrarbtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrarbtnBack.ForeColor = Color.White;
            RegistrarbtnBack.Location = new Point(71, 669);
            RegistrarbtnBack.Name = "RegistrarbtnBack";
            RegistrarbtnBack.Size = new Size(118, 54);
            RegistrarbtnBack.TabIndex = 5;
            RegistrarbtnBack.Text = "Back";
            RegistrarbtnBack.UseVisualStyleBackColor = true;
            // 
            // RegistrarLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1182, 753);
            Controls.Add(RegistrarbtnBack);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "RegistrarLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarLogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button RegistrarbtnLogin;
        private Label label2;
        private TextBox RegistrarInputPassword;
        private Label Username;
        private Label label1;
        private TextBox RegistrarInputUser;
        private PictureBox pictureBox1;
        private Button RegistrarbtnBack;
    }
}