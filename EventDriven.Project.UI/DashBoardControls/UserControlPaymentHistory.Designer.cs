namespace EventDriven.Project.UI.DashBoardControls
{
    partial class UserControlPaymentHistory
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainerPayment = new SplitContainer();
            dataGridView1 = new DataGridView();
            PaymentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            DatePaid = new DataGridViewTextBoxColumn();
            PaymentType = new DataGridViewTextBoxColumn();
            AmountPaid = new DataGridViewTextBoxColumn();
            RemainingBalance = new DataGridViewTextBoxColumn();
            studentID = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnSearchStuIn = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            lbId = new Label();
            lbTotal = new Label();
            label5 = new Label();
            label3 = new Label();
            lbName = new Label();
            label2 = new Label();
            lbStatus = new Label();
            lbBalance = new Label();
            label8 = new Label();
            Column6 = new DataGridViewTextBoxColumn();
            academicYearModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).BeginInit();
            splitContainerPayment.Panel1.SuspendLayout();
            splitContainerPayment.Panel2.SuspendLayout();
            splitContainerPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)academicYearModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainerPayment
            // 
            splitContainerPayment.Dock = DockStyle.Fill;
            splitContainerPayment.Location = new Point(0, 0);
            splitContainerPayment.Margin = new Padding(3, 2, 3, 2);
            splitContainerPayment.Name = "splitContainerPayment";
            // 
            // splitContainerPayment.Panel1
            // 
            splitContainerPayment.Panel1.BackColor = Color.BurlyWood;
            splitContainerPayment.Panel1.Controls.Add(dataGridView1);
            splitContainerPayment.Panel1.Controls.Add(panel1);
            // 
            // splitContainerPayment.Panel2
            // 
            splitContainerPayment.Panel2.BackColor = Color.BurlyWood;
            splitContainerPayment.Panel2.Controls.Add(panel2);
            splitContainerPayment.Panel2.Controls.Add(panel3);
            splitContainerPayment.Size = new Size(1270, 741);
            splitContainerPayment.SplitterDistance = 748;
            splitContainerPayment.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PaymentId, StudentName, DatePaid, PaymentType, AmountPaid, RemainingBalance, studentID });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SeaShell;
            dataGridView1.Location = new Point(0, 58);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SeaShell;
            dataGridViewCellStyle4.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(749, 683);
            dataGridView1.TabIndex = 149;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // PaymentId
            // 
            PaymentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PaymentId.HeaderText = "Id";
            PaymentId.MinimumWidth = 6;
            PaymentId.Name = "PaymentId";
            PaymentId.ReadOnly = true;
            PaymentId.Width = 42;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 280;
            // 
            // DatePaid
            // 
            DatePaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DatePaid.HeaderText = "Date Paid";
            DatePaid.MinimumWidth = 6;
            DatePaid.Name = "DatePaid";
            DatePaid.ReadOnly = true;
            DatePaid.Width = 83;
            // 
            // PaymentType
            // 
            PaymentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PaymentType.HeaderText = "Type";
            PaymentType.MinimumWidth = 6;
            PaymentType.Name = "PaymentType";
            PaymentType.ReadOnly = true;
            PaymentType.Width = 59;
            // 
            // AmountPaid
            // 
            AmountPaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            AmountPaid.HeaderText = "Amount Paid";
            AmountPaid.MinimumWidth = 6;
            AmountPaid.Name = "AmountPaid";
            AmountPaid.ReadOnly = true;
            AmountPaid.Width = 103;
            // 
            // RemainingBalance
            // 
            RemainingBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            RemainingBalance.HeaderText = "Remaining Balance";
            RemainingBalance.MinimumWidth = 6;
            RemainingBalance.Name = "RemainingBalance";
            RemainingBalance.ReadOnly = true;
            RemainingBalance.Width = 137;
            // 
            // studentID
            // 
            studentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            studentID.HeaderText = "StudentID";
            studentID.MinimumWidth = 6;
            studentID.Name = "studentID";
            studentID.ReadOnly = true;
            studentID.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchStuIn);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 58);
            panel1.TabIndex = 148;
            // 
            // btnSearchStuIn
            // 
            btnSearchStuIn.BackColor = Color.White;
            btnSearchStuIn.FlatStyle = FlatStyle.System;
            btnSearchStuIn.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStuIn.ForeColor = Color.SteelBlue;
            btnSearchStuIn.Location = new Point(617, 12);
            btnSearchStuIn.Name = "btnSearchStuIn";
            btnSearchStuIn.Size = new Size(105, 34);
            btnSearchStuIn.TabIndex = 148;
            btnSearchStuIn.Text = "Search";
            btnSearchStuIn.UseVisualStyleBackColor = false;
            btnSearchStuIn.Click += btnSearchStuIn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(169, 20);
            txtSearch.Margin = new Padding(3, 2, 9, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(437, 23);
            txtSearch.TabIndex = 147;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(24, 11);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 38);
            panel2.TabIndex = 166;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(110, 7);
            label4.Name = "label4";
            label4.Size = new Size(221, 28);
            label4.TabIndex = 0;
            label4.Text = "Payment Information:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(lbId);
            panel3.Controls.Add(lbTotal);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lbName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lbStatus);
            panel3.Controls.Add(lbBalance);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(41, 58);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 650);
            panel3.TabIndex = 162;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbId.Location = new Point(82, 46);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 23);
            lbId.TabIndex = 164;
            lbId.Text = "0";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.SeaShell;
            lbTotal.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(142, 110);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(57, 23);
            lbTotal.TabIndex = 165;
            lbTotal.Text = "₱0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 46);
            label5.Name = "label5";
            label5.Size = new Size(40, 23);
            label5.TabIndex = 163;
            label5.Text = "ID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 110);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 164;
            label3.Text = "Total Paid:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(82, 15);
            lbName.Name = "lbName";
            lbName.Size = new Size(92, 23);
            lbName.TabIndex = 150;
            lbName.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatus.Location = new Point(183, 194);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(0, 23);
            lbStatus.TabIndex = 163;
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.BackColor = Color.SeaShell;
            lbBalance.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBalance.Location = new Point(221, 131);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(57, 23);
            lbBalance.TabIndex = 162;
            lbBalance.Text = "₱0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SeaShell;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 131);
            label8.Name = "label8";
            label8.Size = new Size(168, 23);
            label8.TabIndex = 157;
            label8.Text = "Remaining Balance:";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Date of Birth";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // academicYearModelBindingSource
            // 
            academicYearModelBindingSource.DataSource = typeof(Model.AcademicYearModel);
            // 
            // UserControlPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerPayment);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlPaymentHistory";
            Size = new Size(1270, 741);
            splitContainerPayment.Panel1.ResumeLayout(false);
            splitContainerPayment.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).EndInit();
            splitContainerPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)academicYearModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        private SplitContainer splitContainerPayment;
        private TextBox txtSearch;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn ColEdit;
        private DataGridViewImageColumn ColDelete;
        private Button btnSearchStuIn;
        private Label lbName;
        private Label label2;
        private Label label8;
        private Panel panel3;
        private Label lbBalance;
        private Label lbTotal;
        private Label label3;
        private Label lbStatus;
        private Label lbId;
        private Label label5;
        private DataGridViewTextBoxColumn PaymentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn DatePaid;
        private DataGridViewTextBoxColumn PaymentType;
        private DataGridViewTextBoxColumn AmountPaid;
        private DataGridViewTextBoxColumn RemainingBalance;
        private DataGridViewTextBoxColumn studentID;
        private Panel panel2;
        private Label label4;
        private BindingSource academicYearModelBindingSource;
    }
}