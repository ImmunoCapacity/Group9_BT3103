namespace EventDriven.Project.UI
{
    partial class FormUserRoles
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
            label1 = new Label();
            Adminbtn = new Button();
            Cashierbtn = new Button();
            Regstrarbtn = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left ;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(450, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 140);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left ;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(310, 233);
            label1.Name = "label1";
            label1.Size = new Size(717, 49);
            label1.TabIndex = 4;
            label1.Text = "WELCOME. PLEASE CHOOSE YOUR ROLE";
            // 
            // Adminbtn
            // 
            Adminbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left ;
            Adminbtn.Cursor = Cursors.Hand;
            Adminbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Adminbtn.FlatAppearance.BorderSize = 3;
            Adminbtn.FlatStyle = FlatStyle.System;
            Adminbtn.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adminbtn.ForeColor = Color.FromArgb(64, 64, 64);
            Adminbtn.Location = new Point(109, 648);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(151, 60);
            Adminbtn.TabIndex = 1;
            Adminbtn.Text = "Admin";
            Adminbtn.UseVisualStyleBackColor = true;
            Adminbtn.Click += Adminbtn_Click;
            // 
            // Cashierbtn
            // 
            Cashierbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left ;
            Cashierbtn.Cursor = Cursors.Hand;
            Cashierbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Cashierbtn.FlatAppearance.BorderSize = 3;
            Cashierbtn.FlatStyle = FlatStyle.System;
            Cashierbtn.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashierbtn.ForeColor = Color.FromArgb(64, 64, 64);
            Cashierbtn.Location = new Point(598, 648);
            Cashierbtn.Name = "Cashierbtn";
            Cashierbtn.Size = new Size(151, 60);
            Cashierbtn.TabIndex = 2;
            Cashierbtn.Text = "Cashier";
            Cashierbtn.UseVisualStyleBackColor = true;
            Cashierbtn.Click += Cashierbtn_Click;
            // 
            // Regstrarbtn
            // 
            Regstrarbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left ;
            Regstrarbtn.Cursor = Cursors.Hand;
            Regstrarbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Regstrarbtn.FlatAppearance.BorderSize = 3;
            Regstrarbtn.FlatStyle = FlatStyle.System;
            Regstrarbtn.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Regstrarbtn.ForeColor = Color.FromArgb(64, 64, 64);
            Regstrarbtn.Location = new Point(1033, 648);
            Regstrarbtn.Name = "Regstrarbtn";
            Regstrarbtn.RightToLeft = RightToLeft.No;
            Regstrarbtn.Size = new Size(151, 60);
            Regstrarbtn.TabIndex = 3;
            Regstrarbtn.Text = "Registrar";
            Regstrarbtn.UseVisualStyleBackColor = true;
            Regstrarbtn.Click += Regstrarbtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left ;
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(Regstrarbtn);
            panel1.Controls.Add(Cashierbtn);
            panel1.Controls.Add(Adminbtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(313, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 756);
            panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left ;
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(48, 368);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(268, 265);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left ;
            pictureBox5.Image = Properties.Resources.registered;
            pictureBox5.Location = new Point(966, 368);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(268, 265);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left ;
            pictureBox4.Image = Properties.Resources.cash_machine;
            pictureBox4.Location = new Point(533, 368);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(268, 265);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1919, 112);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(340, 30);
            label3.Name = "label3";
            label3.Size = new Size(275, 49);
            label3.TabIndex = 6;
            label3.Text = "ACADEMY INC.";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left ;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(3, -14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 126);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(119, 30);
            label2.Name = "label2";
            label2.Size = new Size(234, 49);
            label2.TabIndex = 0;
            label2.Text = "ROSEWOOD ";
            // 
            // FormUserRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUserRoles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUserRoles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button Adminbtn;
        private Button Cashierbtn;
        private Button Regstrarbtn;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
    }
}