namespace EventDriven.Project.UI
{
    partial class FormAdminDashboard
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
            pictureBox1 = new PictureBox();
            btnStudentInfo = new Button();
            btnStudentReg = new Button();
            btnAssessment = new Button();
            btnPayments = new Button();
            btnHistory = new Button();
            btnAdminReports = new Button();
            btnAdminDashboardBack = new Button();
            btnAdminDashboardLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnAdminDashboardLogout);
            panel1.Controls.Add(btnAdminDashboardBack);
            panel1.Controls.Add(btnAdminReports);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnAssessment);
            panel1.Controls.Add(btnStudentReg);
            panel1.Controls.Add(btnStudentInfo);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 808);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo3;
            pictureBox1.Location = new Point(24, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 131);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnStudentInfo
            // 
            btnStudentInfo.FlatAppearance.BorderColor = Color.Firebrick;
            btnStudentInfo.FlatStyle = FlatStyle.Flat;
            btnStudentInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentInfo.ForeColor = Color.FromArgb(64, 64, 64);
            btnStudentInfo.Location = new Point(24, 174);
            btnStudentInfo.Name = "btnStudentInfo";
            btnStudentInfo.Size = new Size(386, 54);
            btnStudentInfo.TabIndex = 2;
            btnStudentInfo.Text = "Student Information";
            btnStudentInfo.UseVisualStyleBackColor = true;
            // 
            // btnStudentReg
            // 
            btnStudentReg.FlatAppearance.BorderColor = Color.Firebrick;
            btnStudentReg.FlatStyle = FlatStyle.Flat;
            btnStudentReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentReg.ForeColor = Color.FromArgb(64, 64, 64);
            btnStudentReg.Location = new Point(24, 257);
            btnStudentReg.Name = "btnStudentReg";
            btnStudentReg.Size = new Size(386, 54);
            btnStudentReg.TabIndex = 3;
            btnStudentReg.Text = "Student Registration";
            btnStudentReg.UseVisualStyleBackColor = true;
            btnStudentReg.Click += button2_Click;
            // 
            // btnAssessment
            // 
            btnAssessment.FlatAppearance.BorderColor = Color.Firebrick;
            btnAssessment.FlatStyle = FlatStyle.Flat;
            btnAssessment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssessment.ForeColor = Color.FromArgb(64, 64, 64);
            btnAssessment.Location = new Point(24, 341);
            btnAssessment.Name = "btnAssessment";
            btnAssessment.Size = new Size(386, 54);
            btnAssessment.TabIndex = 4;
            btnAssessment.Text = "Assessment";
            btnAssessment.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.FlatAppearance.BorderColor = Color.Firebrick;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.FromArgb(64, 64, 64);
            btnPayments.Location = new Point(24, 429);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(386, 54);
            btnPayments.TabIndex = 5;
            btnPayments.Text = "Payment";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderColor = Color.Firebrick;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(64, 64, 64);
            btnHistory.Location = new Point(24, 515);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(386, 54);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "Payment History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnAdminReports
            // 
            btnAdminReports.FlatAppearance.BorderColor = Color.Firebrick;
            btnAdminReports.FlatStyle = FlatStyle.Flat;
            btnAdminReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminReports.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdminReports.Location = new Point(24, 602);
            btnAdminReports.Name = "btnAdminReports";
            btnAdminReports.Size = new Size(386, 54);
            btnAdminReports.TabIndex = 7;
            btnAdminReports.Text = "Reports";
            btnAdminReports.UseVisualStyleBackColor = true;
            // 
            // btnAdminDashboardBack
            // 
            btnAdminDashboardBack.FlatAppearance.BorderColor = Color.Firebrick;
            btnAdminDashboardBack.FlatStyle = FlatStyle.Flat;
            btnAdminDashboardBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminDashboardBack.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdminDashboardBack.Location = new Point(24, 740);
            btnAdminDashboardBack.Name = "btnAdminDashboardBack";
            btnAdminDashboardBack.Size = new Size(150, 54);
            btnAdminDashboardBack.TabIndex = 8;
            btnAdminDashboardBack.Text = "BACK";
            btnAdminDashboardBack.UseVisualStyleBackColor = true;
            // 
            // btnAdminDashboardLogout
            // 
            btnAdminDashboardLogout.FlatAppearance.BorderColor = Color.Firebrick;
            btnAdminDashboardLogout.FlatStyle = FlatStyle.Flat;
            btnAdminDashboardLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminDashboardLogout.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdminDashboardLogout.Location = new Point(260, 740);
            btnAdminDashboardLogout.Name = "btnAdminDashboardLogout";
            btnAdminDashboardLogout.Size = new Size(150, 54);
            btnAdminDashboardLogout.TabIndex = 9;
            btnAdminDashboardLogout.Text = "LOG OUT";
            btnAdminDashboardLogout.UseVisualStyleBackColor = true;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1464, 806);
            Controls.Add(panel1);
            Name = "FormAdminDashboard";
            Text = "FormAdminDashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnStudentReg;
        private Button btnStudentInfo;
        private PictureBox pictureBox1;
        private Button btnAdminDashboardLogout;
        private Button btnAdminDashboardBack;
        private Button btnAdminReports;
        private Button btnHistory;
        private Button btnPayments;
        private Button btnAssessment;
    }
}