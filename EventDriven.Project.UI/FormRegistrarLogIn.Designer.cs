namespace EventDriven.Project.UI
{
    partial class FormRegistrarLogIn
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
            RegistrarBackbtn = new Button();
            panel1 = new Panel();
            RegistrarLoginbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            RegistrarinputPassword = new TextBox();
            RegistrarinputUser = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RegistrarBackbtn
            // 
            RegistrarBackbtn.FlatAppearance.BorderColor = Color.Firebrick;
            RegistrarBackbtn.FlatAppearance.BorderSize = 3;
            RegistrarBackbtn.FlatStyle = FlatStyle.Flat;
            RegistrarBackbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrarBackbtn.ForeColor = Color.FromArgb(64, 64, 64);
            RegistrarBackbtn.Location = new Point(45, 774);
            RegistrarBackbtn.Name = "RegistrarBackbtn";
            RegistrarBackbtn.Size = new Size(107, 49);
            RegistrarBackbtn.TabIndex = 11;
            RegistrarBackbtn.Text = "BACK";
            RegistrarBackbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(RegistrarLoginbtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RegistrarinputPassword);
            panel1.Controls.Add(RegistrarinputUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(364, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 360);
            panel1.TabIndex = 10;
            // 
            // RegistrarLoginbtn
            // 
            RegistrarLoginbtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RegistrarLoginbtn.FlatAppearance.BorderSize = 3;
            RegistrarLoginbtn.FlatStyle = FlatStyle.Flat;
            RegistrarLoginbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrarLoginbtn.ForeColor = Color.Firebrick;
            RegistrarLoginbtn.Location = new Point(313, 289);
            RegistrarLoginbtn.Name = "RegistrarLoginbtn";
            RegistrarLoginbtn.Size = new Size(129, 52);
            RegistrarLoginbtn.TabIndex = 2;
            RegistrarLoginbtn.Text = "LOGIN";
            RegistrarLoginbtn.UseVisualStyleBackColor = true;
            RegistrarLoginbtn.Click += RegistrarLoginbtn_Click;
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
            // RegistrarinputPassword
            // 
            RegistrarinputPassword.Location = new Point(92, 190);
            RegistrarinputPassword.Name = "RegistrarinputPassword";
            RegistrarinputPassword.Size = new Size(546, 27);
            RegistrarinputPassword.TabIndex = 3;
            // 
            // RegistrarinputUser
            // 
            RegistrarinputUser.Location = new Point(92, 104);
            RegistrarinputUser.Name = "RegistrarinputUser";
            RegistrarinputUser.Size = new Size(546, 27);
            RegistrarinputUser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(246, 29);
            label1.Name = "label1";
            label1.Size = new Size(260, 38);
            label1.TabIndex = 2;
            label1.Text = "REGISTRAR LOGIN";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(541, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 135);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormRegistrarLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1482, 853);
            Controls.Add(RegistrarBackbtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormRegistrarLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarLogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button RegistrarBackbtn;
        private Panel panel1;
        private Button RegistrarLoginbtn;
        private Label label3;
        private Label label2;
        private TextBox RegistrarinputPassword;
        private TextBox RegistrarinputUser;
        private Label label1;
        private PictureBox pictureBox1;
    }
}