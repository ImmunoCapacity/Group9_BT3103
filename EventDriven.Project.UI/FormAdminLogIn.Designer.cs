namespace EventDriven.Project.UI
{
    partial class FormAdminLogIn
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
            AdminLoginbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            AdmininputPassword = new TextBox();
            AdmininputUser = new TextBox();
            label1 = new Label();
            AdminBackbtn = new Button();
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(AdminLoginbtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AdmininputPassword);
            panel1.Controls.Add(AdmininputUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(361, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 360);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // AdminLoginbtn
            // 
            AdminLoginbtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            AdminLoginbtn.FlatAppearance.BorderSize = 3;
            AdminLoginbtn.FlatStyle = FlatStyle.Flat;
            AdminLoginbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminLoginbtn.ForeColor = Color.Firebrick;
            AdminLoginbtn.Location = new Point(313, 289);
            AdminLoginbtn.Name = "AdminLoginbtn";
            AdminLoginbtn.Size = new Size(129, 52);
            AdminLoginbtn.TabIndex = 2;
            AdminLoginbtn.Text = "LOGIN";
            AdminLoginbtn.UseVisualStyleBackColor = true;
            AdminLoginbtn.Click += button1_Click;
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
            label2.Click += label2_Click;
            // 
            // AdmininputPassword
            // 
            AdmininputPassword.Location = new Point(92, 190);
            AdmininputPassword.Name = "AdmininputPassword";
            AdmininputPassword.Size = new Size(546, 27);
            AdmininputPassword.TabIndex = 3;
            // 
            // AdmininputUser
            // 
            AdmininputUser.Location = new Point(92, 104);
            AdmininputUser.Name = "AdmininputUser";
            AdmininputUser.Size = new Size(546, 27);
            AdmininputUser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(269, 30);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 2;
            label1.Text = "ADMIN LOGIN";
            label1.Click += label1_Click;
            // 
            // AdminBackbtn
            // 
            AdminBackbtn.FlatAppearance.BorderColor = Color.Firebrick;
            AdminBackbtn.FlatAppearance.BorderSize = 3;
            AdminBackbtn.FlatStyle = FlatStyle.Flat;
            AdminBackbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminBackbtn.ForeColor = Color.FromArgb(64, 64, 64);
            AdminBackbtn.Location = new Point(42, 779);
            AdminBackbtn.Name = "AdminBackbtn";
            AdminBackbtn.Size = new Size(107, 49);
            AdminBackbtn.TabIndex = 5;
            AdminBackbtn.Text = "BACK";
            AdminBackbtn.UseVisualStyleBackColor = true;
            // 
            // FormAdminLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1482, 853);
            Controls.Add(AdminBackbtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormAdminLogIn";
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
        private Label label1;
        private Label label2;
        private TextBox AdmininputPassword;
        private TextBox AdmininputUser;
        private Button AdminLoginbtn;
        private Label label3;
        private Button AdminBackbtn;
    }
}