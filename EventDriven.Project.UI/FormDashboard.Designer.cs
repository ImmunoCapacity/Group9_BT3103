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
            panel2 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btnAdminDashboardLogout);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 941);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnStudentInfo);
            flowLayoutPanel1.Controls.Add(btnHistory);
            flowLayoutPanel1.Controls.Add(btnStudentReg);
            flowLayoutPanel1.Controls.Add(btnPayments);
            flowLayoutPanel1.Controls.Add(btnAssessment);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Location = new Point(23, 104);
            flowLayoutPanel1.Margin = new Padding(101, 100, 101, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(391, 484);
            flowLayoutPanel1.TabIndex = 10;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnStudentInfo
            // 
            btnStudentInfo.Cursor = Cursors.Hand;
            btnStudentInfo.FlatAppearance.BorderColor = Color.Firebrick;
            btnStudentInfo.FlatStyle = FlatStyle.System;
            btnStudentInfo.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderColor = Color.Firebrick;
            btnHistory.FlatStyle = FlatStyle.System;
            btnHistory.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(64, 64, 64);
            btnHistory.Location = new Point(3, 88);
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
            btnStudentReg.Cursor = Cursors.Hand;
            btnStudentReg.FlatAppearance.BorderColor = Color.Firebrick;
            btnStudentReg.FlatStyle = FlatStyle.System;
            btnStudentReg.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentReg.ForeColor = Color.FromArgb(64, 64, 64);
            btnStudentReg.Location = new Point(3, 173);
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
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.FlatAppearance.BorderColor = Color.Firebrick;
            btnPayments.FlatStyle = FlatStyle.System;
            btnPayments.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnAssessment.Cursor = Cursors.Hand;
            btnAssessment.FlatAppearance.BorderColor = Color.Firebrick;
            btnAssessment.FlatStyle = FlatStyle.System;
            btnAssessment.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderColor = Color.Firebrick;
            btnReports.FlatStyle = FlatStyle.System;
            btnReports.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnAdminDashboardLogout.Cursor = Cursors.Hand;
            btnAdminDashboardLogout.FlatAppearance.BorderColor = Color.Firebrick;
            btnAdminDashboardLogout.FlatStyle = FlatStyle.System;
            btnAdminDashboardLogout.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminDashboardLogout.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdminDashboardLogout.Location = new Point(26, 835);
            btnAdminDashboardLogout.Name = "btnAdminDashboardLogout";
            btnAdminDashboardLogout.Size = new Size(388, 53);
            btnAdminDashboardLogout.TabIndex = 9;
            btnAdminDashboardLogout.Text = "Log Out";
            btnAdminDashboardLogout.UseVisualStyleBackColor = true;
            btnAdminDashboardLogout.Click += btnAdminDashboardLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1902, 92);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(340, 20);
            label3.Name = "label3";
            label3.Size = new Size(275, 49);
            label3.TabIndex = 6;
            label3.Text = "ACADEMY INC.";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 105);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(116, 21);
            label2.Name = "label2";
            label2.Size = new Size(234, 49);
            label2.TabIndex = 0;
            label2.Text = "ROSEWOOD ";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDashboard";
            Text = "FormAdminDashboard";
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdminDashboardLogout;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnReports;
        private Button btnStudentInfo;
        private Button btnHistory;
        private Button btnStudentReg;
        private Button btnPayments;
        private Button btnAssessment;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label2;
    }
}