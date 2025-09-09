namespace EventDriven.Project.UI
{
    partial class FormCashierLogIn
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
            CashierBackbtn = new Button();
            panel1 = new Panel();
            CashierLoginbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            CashierinputPassword = new TextBox();
            CashierinputUser = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CashierBackbtn
            // 
            CashierBackbtn.FlatAppearance.BorderColor = Color.Firebrick;
            CashierBackbtn.FlatAppearance.BorderSize = 3;
            CashierBackbtn.FlatStyle = FlatStyle.Flat;
            CashierBackbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashierBackbtn.ForeColor = Color.FromArgb(64, 64, 64);
            CashierBackbtn.Location = new Point(43, 775);
            CashierBackbtn.Name = "CashierBackbtn";
            CashierBackbtn.Size = new Size(107, 49);
            CashierBackbtn.TabIndex = 8;
            CashierBackbtn.Text = "BACK";
            CashierBackbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(CashierLoginbtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CashierinputPassword);
            panel1.Controls.Add(CashierinputUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(362, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 360);
            panel1.TabIndex = 7;
            // 
            // CashierLoginbtn
            // 
            CashierLoginbtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            CashierLoginbtn.FlatAppearance.BorderSize = 3;
            CashierLoginbtn.FlatStyle = FlatStyle.Flat;
            CashierLoginbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashierLoginbtn.ForeColor = Color.Firebrick;
            CashierLoginbtn.Location = new Point(313, 289);
            CashierLoginbtn.Name = "CashierLoginbtn";
            CashierLoginbtn.Size = new Size(129, 52);
            CashierLoginbtn.TabIndex = 2;
            CashierLoginbtn.Text = "LOGIN";
            CashierLoginbtn.UseVisualStyleBackColor = true;
            CashierLoginbtn.Click += CashierLoginbtn_Click;
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
            // CashierinputPassword
            // 
            CashierinputPassword.Location = new Point(92, 190);
            CashierinputPassword.Name = "CashierinputPassword";
            CashierinputPassword.Size = new Size(546, 27);
            CashierinputPassword.TabIndex = 3;
            CashierinputPassword.TextChanged += AdmininputPassword_TextChanged;
            // 
            // CashierinputUser
            // 
            CashierinputUser.Location = new Point(92, 104);
            CashierinputUser.Name = "CashierinputUser";
            CashierinputUser.Size = new Size(546, 27);
            CashierinputUser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(269, 30);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 2;
            label1.Text = "CASHIER LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(539, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 135);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormCashierLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1482, 853);
            Controls.Add(CashierBackbtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormCashierLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCashierLogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CashierBackbtn;
        private Panel panel1;
        private Button CashierLoginbtn;
        private Label label3;
        private Label label2;
        private TextBox CashierinputPassword;
        private TextBox CashierinputUser;
        private Label label1;
        private PictureBox pictureBox1;
    }
}