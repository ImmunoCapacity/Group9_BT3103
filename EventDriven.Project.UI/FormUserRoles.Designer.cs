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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(540, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 140);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(401, 359);
            label1.Name = "label1";
            label1.Size = new Size(660, 46);
            label1.TabIndex = 1;
            label1.Text = "WELCOME. PLEASE CHOOSE YOUR ROLE";
            // 
            // Adminbtn
            // 
            Adminbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Adminbtn.FlatAppearance.BorderSize = 3;
            Adminbtn.FlatStyle = FlatStyle.Flat;
            Adminbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adminbtn.ForeColor = Color.FromArgb(64, 64, 64);
            Adminbtn.Location = new Point(443, 493);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(151, 60);
            Adminbtn.TabIndex = 2;
            Adminbtn.Text = "ADMIN";
            Adminbtn.UseVisualStyleBackColor = true;
            Adminbtn.Click += this.Adminbtn_Click_1;
            // 
            // Cashierbtn
            // 
            Cashierbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Cashierbtn.FlatAppearance.BorderSize = 3;
            Cashierbtn.FlatStyle = FlatStyle.Flat;
            Cashierbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashierbtn.ForeColor = Color.FromArgb(64, 64, 64);
            Cashierbtn.Location = new Point(664, 493);
            Cashierbtn.Name = "Cashierbtn";
            Cashierbtn.Size = new Size(151, 60);
            Cashierbtn.TabIndex = 3;
            Cashierbtn.Text = "CASHIER";
            Cashierbtn.UseVisualStyleBackColor = true;
            // 
            // Regstrarbtn
            // 
            Regstrarbtn.FlatAppearance.BorderColor = Color.Firebrick;
            Regstrarbtn.FlatAppearance.BorderSize = 3;
            Regstrarbtn.FlatStyle = FlatStyle.Flat;
            Regstrarbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Regstrarbtn.ForeColor = Color.FromArgb(64, 64, 64);
            Regstrarbtn.Location = new Point(867, 493);
            Regstrarbtn.Name = "Regstrarbtn";
            Regstrarbtn.RightToLeft = RightToLeft.No;
            Regstrarbtn.Size = new Size(151, 60);
            Regstrarbtn.TabIndex = 4;
            Regstrarbtn.Text = "REGISTRAR";
            Regstrarbtn.UseVisualStyleBackColor = true;
            // 
            // FormUserRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1482, 853);
            Controls.Add(Regstrarbtn);
            Controls.Add(Cashierbtn);
            Controls.Add(Adminbtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormUserRoles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUserRoles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button Adminbtn;
        private Button Cashierbtn;
        private Button Regstrarbtn;
    }
}