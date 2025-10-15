namespace EventDriven.Project.UI
{
    partial class FormDashboard
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnStudentInfo = new Button();
            btnHistory = new Button();
            btnStudentReg = new Button();
            btnPayments = new Button();
            btnAssessment = new Button();
            btnReports = new Button();
            btnAdminDashboardLogout = new Button();
            btnAdminDashboardBack = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btnAdminDashboardLogout);
            panel1.Controls.Add(btnAdminDashboardBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 808);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnStudentInfo);
            flowLayoutPanel1.Controls.Add(btnStudentReg);
            flowLayoutPanel1.Controls.Add(btnHistory);
            flowLayoutPanel1.Controls.Add(btnPayments);
            flowLayoutPanel1.Controls.Add(btnAssessment);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Location = new Point(24, 171);
            flowLayoutPanel1.Margin = new Padding(101, 100, 101, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(411, 541);
            flowLayoutPanel1.TabIndex = 10;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnStudentInfo
            // 
            btnStudentInfo.FlatAppearance.BorderColor = Color.Firebrick;
            btnStudentInfo.FlatStyle = FlatStyle.Flat;
            btnStudentInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentInfo.ForeColor = Color.FromArgb(64, 64, 64);
            btnStudentInfo.Location = new Point(3, 3);
            btnStudentInfo.Name = "btnStudentInfo";
            btnStudentInfo.Size = new Size(386, 53);
            btnStudentInfo.TabIndex = 8;
            btnStudentInfo.Text = "Student Information";
            btnStudentInfo.UseVisualStyleBackColor = true;
            btnStudentInfo.Visible = false;
            btnStudentInfo.Click += btnStudentReg_Click;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderColor = Color.Firebrick;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(64, 64, 64);
            btnHistory.Location = new Point(3, 173);
            btnHistory.Margin = new Padding(3, 29, 3, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(386, 53);
            btnHistory.TabIndex = 12;
            btnHistory.Text = "Payment History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Visible = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnStudentReg
            // 
            btnStudentReg.FlatAppearance.BorderColor = Color.Firebrick;
            btnStudentReg.FlatStyle = FlatStyle.Flat;
            btnStudentReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentReg.ForeColor = Color.FromArgb(64, 64, 64);
            btnStudentReg.Location = new Point(3, 88);
            btnStudentReg.Margin = new Padding(3, 29, 3, 3);
            btnStudentReg.Name = "btnStudentReg";
            btnStudentReg.Size = new Size(386, 53);
            btnStudentReg.TabIndex = 9;
            btnStudentReg.Text = "Student Registration";
            btnStudentReg.UseVisualStyleBackColor = true;
            btnStudentReg.Visible = false;
            btnStudentReg.Click += btnStudentReg_Click_1;
            // 
            // btnPayments
            // 
            btnPayments.FlatAppearance.BorderColor = Color.Firebrick;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.FromArgb(64, 64, 64);
            btnPayments.Location = new Point(3, 258);
            btnPayments.Margin = new Padding(3, 29, 3, 3);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(386, 53);
            btnPayments.TabIndex = 11;
            btnPayments.Text = "Payment";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Visible = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnAssessment
            // 
            btnAssessment.FlatAppearance.BorderColor = Color.Firebrick;
            btnAssessment.FlatStyle = FlatStyle.Flat;
            btnAssessment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssessment.ForeColor = Color.FromArgb(64, 64, 64);
            btnAssessment.Location = new Point(3, 343);
            btnAssessment.Margin = new Padding(3, 29, 3, 3);
            btnAssessment.Name = "btnAssessment";
            btnAssessment.Size = new Size(386, 53);
            btnAssessment.TabIndex = 10;
            btnAssessment.Text = "Assessment";
            btnAssessment.UseVisualStyleBackColor = true;
            btnAssessment.Visible = false;
            btnAssessment.Click += btnAssessment_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderColor = Color.Firebrick;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.FromArgb(64, 64, 64);
            btnReports.Location = new Point(3, 428);
            btnReports.Margin = new Padding(3, 29, 3, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(386, 53);
            btnReports.TabIndex = 13;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Visible = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnAdminDashboardLogout
            // 
            btnAdminDashboardLogout.FlatAppearance.BorderColor = Color.Firebrick;
            btnAdminDashboardLogout.FlatStyle = FlatStyle.Flat;
            btnAdminDashboardLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminDashboardLogout.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdminDashboardLogout.Location = new Point(261, 740);
            btnAdminDashboardLogout.Name = "btnAdminDashboardLogout";
            btnAdminDashboardLogout.Size = new Size(150, 53);
            btnAdminDashboardLogout.TabIndex = 9;
            btnAdminDashboardLogout.Text = "LOG OUT";
            btnAdminDashboardLogout.UseVisualStyleBackColor = true;
            btnAdminDashboardLogout.Click += btnAdminDashboardLogout_Click;
            // 
            // btnAdminDashboardBack
            // 
            btnAdminDashboardBack.FlatAppearance.BorderColor = Color.Firebrick;
            btnAdminDashboardBack.FlatStyle = FlatStyle.Flat;
            btnAdminDashboardBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminDashboardBack.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdminDashboardBack.Location = new Point(24, 740);
            btnAdminDashboardBack.Name = "btnAdminDashboardBack";
            btnAdminDashboardBack.Size = new Size(150, 53);
            btnAdminDashboardBack.TabIndex = 8;
            btnAdminDashboardBack.Text = "BACK";
            btnAdminDashboardBack.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(433, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 808);
            panel2.TabIndex = 1;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1483, 808);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDashboard";
            Text = "FormAdminDashboard";
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnAdminDashboardLogout;
        private Button btnAdminDashboardBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnReports;
        private Button btnStudentInfo;
        private Button btnHistory;
        private Button btnStudentReg;
        private Button btnPayments;
        private Button btnAssessment;
        private Panel panel2;
    }
}