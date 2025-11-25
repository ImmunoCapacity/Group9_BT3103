namespace EventDriven.Project.UI.DashBoardControls
{
    partial class UserControlAssessment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            txtSearchStudentIn = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lbFullName = new Label();
            lbId = new Label();
            label4 = new Label();
            btnPrint = new Button();
            btnSave = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbStatus = new ComboBox();
            lbGrade = new Label();
            label10 = new Label();
            lbSection = new Label();
            label12 = new Label();
            dataGridViewSubject = new DataGridView();
            dataGridViewSchedule = new DataGridView();
            dataGridViewPayment = new DataGridView();
            lbYear = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayment).BeginInit();
            SuspendLayout();
            // 
            // txtSearchStudentIn
            // 
            txtSearchStudentIn.AccessibleRole = AccessibleRole.IpAddress;
            txtSearchStudentIn.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtSearchStudentIn.Location = new Point(420, 34);
            txtSearchStudentIn.Margin = new Padding(3, 3, 10, 3);
            txtSearchStudentIn.Name = "txtSearchStudentIn";
            txtSearchStudentIn.Size = new Size(483, 29);
            txtSearchStudentIn.TabIndex = 102;
            txtSearchStudentIn.KeyDown += txtSearchStudentIn_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleRole = AccessibleRole.IpAddress;
            btnSearch.FlatAppearance.BorderColor = Color.Firebrick;
            btnSearch.FlatStyle = FlatStyle.System;
            btnSearch.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(64, 64, 64);
            btnSearch.Location = new Point(916, 26);
            btnSearch.Margin = new Padding(3, 3, 10, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 47);
            btnSearch.TabIndex = 103;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(txtSearchStudentIn);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 100);
            panel1.TabIndex = 105;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label1.Location = new Point(119, 141);
            label1.Name = "label1";
            label1.Size = new Size(78, 29);
            label1.TabIndex = 106;
            label1.Text = "Name:";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            lbFullName.Location = new Point(219, 141);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(112, 29);
            lbFullName.TabIndex = 107;
            lbFullName.Text = "Full name";
            lbFullName.Click += label2_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            lbId.Location = new Point(219, 170);
            lbId.Name = "lbId";
            lbId.Size = new Size(26, 29);
            lbId.TabIndex = 109;
            lbId.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label4.Location = new Point(119, 170);
            label4.Name = "label4";
            label4.Size = new Size(41, 29);
            label4.TabIndex = 108;
            label4.Text = "Id:";
            // 
            // btnPrint
            // 
            btnPrint.AccessibleRole = AccessibleRole.IpAddress;
            btnPrint.Anchor = AnchorStyles.Left;
            btnPrint.FlatAppearance.BorderColor = Color.Firebrick;
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnPrint.ForeColor = Color.FromArgb(64, 64, 64);
            btnPrint.Location = new Point(-220, 885);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(236, 57);
            btnPrint.TabIndex = 111;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSave
            // 
            btnSave.AccessibleRole = AccessibleRole.IpAddress;
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderColor = Color.Firebrick;
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(64, 64, 64);
            btnSave.Location = new Point(576, 885);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(236, 57);
            btnSave.TabIndex = 110;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label5.Location = new Point(103, 296);
            label5.Name = "label5";
            label5.Size = new Size(96, 29);
            label5.TabIndex = 112;
            label5.Text = "Subjects";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label6.Location = new Point(656, 296);
            label6.Name = "label6";
            label6.Size = new Size(102, 29);
            label6.TabIndex = 113;
            label6.Text = "Schedule";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label7.Location = new Point(1171, 296);
            label7.Name = "label7";
            label7.Size = new Size(99, 29);
            label7.TabIndex = 114;
            label7.Text = "Payment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label8.Location = new Point(884, 141);
            label8.Name = "label8";
            label8.Size = new Size(75, 29);
            label8.TabIndex = 115;
            label8.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "New", "Old", "Transferee", "Graduated", "Inactive", "Dropout" });
            cbStatus.Location = new Point(830, 199);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(183, 28);
            cbStatus.TabIndex = 116;
            cbStatus.SelectedValueChanged += cbStatus_SelectedValueChanged;
            // 
            // lbGrade
            // 
            lbGrade.AutoSize = true;
            lbGrade.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            lbGrade.Location = new Point(219, 199);
            lbGrade.Name = "lbGrade";
            lbGrade.Size = new Size(24, 29);
            lbGrade.TabIndex = 118;
            lbGrade.Text = "7";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label10.Location = new Point(119, 199);
            label10.Name = "label10";
            label10.Size = new Size(80, 29);
            label10.TabIndex = 117;
            label10.Text = "Grade:";
            // 
            // lbSection
            // 
            lbSection.AutoSize = true;
            lbSection.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            lbSection.Location = new Point(219, 228);
            lbSection.Name = "lbSection";
            lbSection.Size = new Size(44, 29);
            lbSection.TabIndex = 120;
            lbSection.Text = "1-A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label12.Location = new Point(119, 228);
            label12.Name = "label12";
            label12.Size = new Size(94, 29);
            label12.TabIndex = 119;
            label12.Text = "Section:";
            // 
            // dataGridViewSubject
            // 
            dataGridViewSubject.AllowUserToAddRows = false;
            dataGridViewSubject.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSubject.BackgroundColor = Color.SeaShell;
            dataGridViewSubject.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewSubject.CausesValidation = false;
            dataGridViewSubject.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSubject.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSubject.ColumnHeadersHeight = 30;
            dataGridViewSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewSubject.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSubject.EnableHeadersVisualStyles = false;
            dataGridViewSubject.GridColor = Color.SeaShell;
            dataGridViewSubject.Location = new Point(0, 343);
            dataGridViewSubject.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSubject.Name = "dataGridViewSubject";
            dataGridViewSubject.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SeaShell;
            dataGridViewCellStyle4.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSubject.RowHeadersVisible = false;
            dataGridViewSubject.RowHeadersWidth = 51;
            dataGridViewSubject.Size = new Size(382, 459);
            dataGridViewSubject.TabIndex = 121;
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.AllowUserToAddRows = false;
            dataGridViewSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSchedule.BackgroundColor = Color.SeaShell;
            dataGridViewSchedule.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewSchedule.CausesValidation = false;
            dataGridViewSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SeaShell;
            dataGridViewCellStyle6.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewSchedule.ColumnHeadersHeight = 30;
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.SeaShell;
            dataGridViewCellStyle7.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewSchedule.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewSchedule.EnableHeadersVisualStyles = false;
            dataGridViewSchedule.GridColor = Color.SeaShell;
            dataGridViewSchedule.Location = new Point(388, 343);
            dataGridViewSchedule.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.SeaShell;
            dataGridViewCellStyle8.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewSchedule.RowHeadersVisible = false;
            dataGridViewSchedule.RowHeadersWidth = 51;
            dataGridViewSchedule.Size = new Size(593, 459);
            dataGridViewSchedule.TabIndex = 122;
            // 
            // dataGridViewPayment
            // 
            dataGridViewPayment.AllowUserToAddRows = false;
            dataGridViewPayment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewPayment.BackgroundColor = Color.SeaShell;
            dataGridViewPayment.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewPayment.CausesValidation = false;
            dataGridViewPayment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPayment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.SeaShell;
            dataGridViewCellStyle10.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewPayment.ColumnHeadersHeight = 30;
            dataGridViewPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.SeaShell;
            dataGridViewCellStyle11.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridViewPayment.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewPayment.EnableHeadersVisualStyles = false;
            dataGridViewPayment.GridColor = Color.SeaShell;
            dataGridViewPayment.Location = new Point(987, 343);
            dataGridViewPayment.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPayment.Name = "dataGridViewPayment";
            dataGridViewPayment.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.SeaShell;
            dataGridViewCellStyle12.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewPayment.RowHeadersVisible = false;
            dataGridViewPayment.RowHeadersWidth = 51;
            dataGridViewPayment.Size = new Size(438, 459);
            dataGridViewPayment.TabIndex = 123;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            lbYear.Location = new Point(219, 257);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(119, 29);
            lbYear.TabIndex = 125;
            lbYear.Text = "2000-2001";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label3.Location = new Point(119, 257);
            label3.Name = "label3";
            label3.Size = new Size(65, 29);
            label3.TabIndex = 124;
            label3.Text = "Year:";
            // 
            // UserControlAssessment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(lbYear);
            Controls.Add(label3);
            Controls.Add(dataGridViewPayment);
            Controls.Add(dataGridViewSchedule);
            Controls.Add(dataGridViewSubject);
            Controls.Add(lbSection);
            Controls.Add(label12);
            Controls.Add(lbGrade);
            Controls.Add(label10);
            Controls.Add(cbStatus);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnPrint);
            Controls.Add(btnSave);
            Controls.Add(lbId);
            Controls.Add(label4);
            Controls.Add(lbFullName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UserControlAssessment";
            Size = new Size(1470, 973);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtSearchStudentIn;
        private Button btnSearch;
        private Panel panel1;
        private Label label1;
        private Label lbFullName;
        private Label lbId;
        private Label label4;
        private Button btnPrint;
        public Button btnSave;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbStatus;
        private Label lbGrade;
        private Label label10;
        private Label lbSection;
        private Label label12;
        private DataGridView dataGridViewSubject;
        private DataGridView dataGridViewSchedule;
        private DataGridView dataGridViewPayment;
        private Label lbYear;
        private Label label3;
    }
}
