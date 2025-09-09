namespace EventDriven.Project.UI
{
    partial class UserRoles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Adminbtn = new Button();
            Cashierbtn = new Button();
            Registrarbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 274);
            label1.Name = "label1";
            label1.Size = new Size(747, 54);
            label1.TabIndex = 0;
            label1.Text = "WELCOME. PLEASE SELECT YOUR ROLE";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_09_07_155916_removebg_preview;
            pictureBox1.Location = new Point(406, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 131);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Adminbtn
            // 
            Adminbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Adminbtn.FlatAppearance.BorderSize = 2;
            Adminbtn.FlatStyle = FlatStyle.Flat;
            Adminbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adminbtn.ForeColor = Color.WhiteSmoke;
            Adminbtn.Location = new Point(268, 398);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(168, 93);
            Adminbtn.TabIndex = 2;
            Adminbtn.Text = "ADMIN";
            Adminbtn.UseVisualStyleBackColor = true;
            Adminbtn.Click += Adminbtn_Click;
            // 
            // Cashierbtn
            // 
            Cashierbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Cashierbtn.FlatAppearance.BorderSize = 2;
            Cashierbtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight;
            Cashierbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            Cashierbtn.FlatStyle = FlatStyle.Flat;
            Cashierbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashierbtn.ForeColor = Color.WhiteSmoke;
            Cashierbtn.Location = new Point(509, 398);
            Cashierbtn.Name = "Cashierbtn";
            Cashierbtn.Size = new Size(169, 93);
            Cashierbtn.TabIndex = 3;
            Cashierbtn.Text = "CASHIER";
            Cashierbtn.UseVisualStyleBackColor = true;
            Cashierbtn.Click += Cashierbtn_Click;
            // 
            // Registrarbtn
            // 
            Registrarbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Registrarbtn.FlatAppearance.BorderSize = 2;
            Registrarbtn.FlatStyle = FlatStyle.Flat;
            Registrarbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrarbtn.ForeColor = Color.WhiteSmoke;
            Registrarbtn.Location = new Point(747, 398);
            Registrarbtn.Name = "Registrarbtn";
            Registrarbtn.Size = new Size(170, 93);
            Registrarbtn.TabIndex = 4;
            Registrarbtn.Text = "REGISTRAR";
            Registrarbtn.UseVisualStyleBackColor = true;
            Registrarbtn.Click += button3_Click;
            // 
            // UserRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1182, 753);
            Controls.Add(Registrarbtn);
            Controls.Add(Cashierbtn);
            Controls.Add(Adminbtn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "UserRoles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserRoles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button Adminbtn;
        private Button Cashierbtn;
        private Button Registrarbtn;
    }
}
