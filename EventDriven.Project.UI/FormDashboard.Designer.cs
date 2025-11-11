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
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            btnAdminDashboardLogout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnStudentInfo = new Button();
            btnHistory = new Button();
            btnStudentReg = new Button();
            btnPayments = new Button();
            btnAssessment = new Button();
            btnReports = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 107);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(330, 26);
            label3.Name = "label3";
            label3.Size = new Size(275, 49);
            label3.TabIndex = 6;
            label3.Text = "ACADEMY INC.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(106, 27);
            label2.Name = "label2";
            label2.Size = new Size(234, 49);
            label2.TabIndex = 0;
            label2.Text = "ROSEWOOD ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 130);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(btnAdminDashboardLogout);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(0, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 926);
            panel3.TabIndex = 8;
            // 
            // btnAdminDashboardLogout
            // 
            btnAdminDashboardLogout.Cursor = Cursors.Hand;
            btnAdminDashboardLogout.FlatAppearance.BorderColor = Color.Firebrick;
            btnAdminDashboardLogout.FlatStyle = FlatStyle.System;
            btnAdminDashboardLogout.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminDashboardLogout.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdminDashboardLogout.Location = new Point(26, 764);
            btnAdminDashboardLogout.Name = "btnAdminDashboardLogout";
            btnAdminDashboardLogout.Size = new Size(388, 53);
            btnAdminDashboardLogout.TabIndex = 12;
            btnAdminDashboardLogout.Text = "Log Out";
            btnAdminDashboardLogout.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnStudentInfo);
            flowLayoutPanel1.Controls.Add(btnHistory);
            flowLayoutPanel1.Controls.Add(btnStudentReg);
            flowLayoutPanel1.Controls.Add(btnPayments);
            flowLayoutPanel1.Controls.Add(btnAssessment);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Location = new Point(23, 88);
            flowLayoutPanel1.Margin = new Padding(101, 100, 101, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(391, 484);
            flowLayoutPanel1.TabIndex = 11;
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
            btnStudentInfo.Click += btnStudentInfo_Click;
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
            btnHistory.TabIndex = 8;
            btnHistory.Text = "Payment History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Visible = false;
            btnHistory.Click += btnHistory_Click_1;
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
            btnPayments.Click += btnPayments_Click_1;
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
            // 
            // panel1
            // 
            panel1.Location = new Point(450, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 943);
            panel1.TabIndex = 9;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDashboard";
            Text = "FormAdminDashboard";
            Load += FormDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel3;
        private Button btnAdminDashboardLogout;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnStudentInfo;
        private Button btnHistory;
        private Button btnStudentReg;
        private Button btnPayments;
        private Button btnAssessment;
        private Button btnReports;
        private Panel panel1;
    }
}