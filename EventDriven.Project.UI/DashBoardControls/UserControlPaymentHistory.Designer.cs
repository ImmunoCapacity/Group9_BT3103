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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            lbId = new Label();
            label5 = new Label();
            label1 = new Label();
            lbName = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnPrint = new Button();
            lbTotal = new Label();
            label3 = new Label();
            lbStatus = new Label();
            lbBalance = new Label();
            label8 = new Label();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).BeginInit();
            splitContainerPayment.Panel1.SuspendLayout();
            splitContainerPayment.Panel2.SuspendLayout();
            splitContainerPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerPayment
            // 
            splitContainerPayment.Dock = DockStyle.Fill;
            splitContainerPayment.Location = new Point(0, 0);
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
            splitContainerPayment.Panel2.Controls.Add(lbId);
            splitContainerPayment.Panel2.Controls.Add(label5);
            splitContainerPayment.Panel2.Controls.Add(label1);
            splitContainerPayment.Panel2.Controls.Add(lbName);
            splitContainerPayment.Panel2.Controls.Add(label2);
            splitContainerPayment.Panel2.Controls.Add(panel2);
            splitContainerPayment.Panel2.Controls.Add(panel3);
            splitContainerPayment.Size = new Size(1452, 988);
            splitContainerPayment.SplitterDistance = 856;
            splitContainerPayment.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.SeaShell;
            dataGridViewCellStyle5.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SeaShell;
            dataGridViewCellStyle6.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PaymentId, StudentName, DatePaid, PaymentType, AmountPaid, RemainingBalance, studentID });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.SeaShell;
            dataGridViewCellStyle7.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SeaShell;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.SeaShell;
            dataGridViewCellStyle8.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(856, 911);
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
            PaymentId.Width = 52;
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
            DatePaid.Width = 105;
            // 
            // PaymentType
            // 
            PaymentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PaymentType.HeaderText = "Type";
            PaymentType.MinimumWidth = 6;
            PaymentType.Name = "PaymentType";
            PaymentType.ReadOnly = true;
            PaymentType.Width = 71;
            // 
            // AmountPaid
            // 
            AmountPaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            AmountPaid.HeaderText = "Amount Paid";
            AmountPaid.MinimumWidth = 6;
            AmountPaid.Name = "AmountPaid";
            AmountPaid.ReadOnly = true;
            AmountPaid.Width = 127;
            // 
            // RemainingBalance
            // 
            RemainingBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            RemainingBalance.HeaderText = "Remaining Balance";
            RemainingBalance.MinimumWidth = 6;
            RemainingBalance.Name = "RemainingBalance";
            RemainingBalance.ReadOnly = true;
            RemainingBalance.Width = 170;
            // 
            // studentID
            // 
            studentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            studentID.HeaderText = "StudentID";
            studentID.MinimumWidth = 6;
            studentID.Name = "studentID";
            studentID.ReadOnly = true;
            studentID.Visible = false;
            studentID.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchStuIn);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 77);
            panel1.TabIndex = 148;
            // 
            // btnSearchStuIn
            // 
            btnSearchStuIn.BackColor = Color.White;
            btnSearchStuIn.FlatStyle = FlatStyle.System;
            btnSearchStuIn.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStuIn.ForeColor = Color.SteelBlue;
            btnSearchStuIn.Location = new Point(686, 16);
            btnSearchStuIn.Margin = new Padding(3, 4, 3, 4);
            btnSearchStuIn.Name = "btnSearchStuIn";
            btnSearchStuIn.Size = new Size(120, 45);
            btnSearchStuIn.TabIndex = 148;
            btnSearchStuIn.Text = "Search";
            btnSearchStuIn.UseVisualStyleBackColor = false;
            btnSearchStuIn.Click += btnSearchStuIn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(174, 26);
            txtSearch.Margin = new Padding(3, 3, 10, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(499, 27);
            txtSearch.TabIndex = 147;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbId.Location = new Point(107, 271);
            lbId.Name = "lbId";
            lbId.Size = new Size(26, 29);
            lbId.TabIndex = 164;
            lbId.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 271);
            label5.Name = "label5";
            label5.Size = new Size(50, 29);
            label5.TabIndex = 163;
            label5.Text = "ID: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 169);
            label1.Name = "label1";
            label1.Size = new Size(268, 33);
            label1.TabIndex = 0;
            label1.Text = "Payment Information:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(107, 229);
            lbName.Name = "lbName";
            lbName.Size = new Size(115, 29);
            lbName.TabIndex = 150;
            lbName.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 229);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 122);
            panel2.TabIndex = 149;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(317, 40);
            label10.Name = "label10";
            label10.Size = new Size(275, 49);
            label10.TabIndex = 165;
            label10.Text = "ACADEMY INC.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(107, 40);
            label9.Name = "label9";
            label9.Size = new Size(234, 49);
            label9.TabIndex = 164;
            label9.Text = "ROSEWOOD ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 121);
            pictureBox1.TabIndex = 163;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(lbTotal);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lbStatus);
            panel3.Controls.Add(lbBalance);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(47, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 625);
            panel3.TabIndex = 162;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.SteelBlue;
            btnPrint.Location = new Point(191, 540);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 45);
            btnPrint.TabIndex = 161;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.SeaShell;
            lbTotal.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(253, 110);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(58, 29);
            lbTotal.TabIndex = 165;
            lbTotal.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 110);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 164;
            label3.Text = "Total Paid:";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatus.Location = new Point(209, 258);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(0, 29);
            lbStatus.TabIndex = 163;
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.BackColor = Color.SeaShell;
            lbBalance.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBalance.Location = new Point(253, 175);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(58, 29);
            lbBalance.TabIndex = 162;
            lbBalance.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SeaShell;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(36, 175);
            label8.Name = "label8";
            label8.Size = new Size(211, 29);
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
            Column6.Width = 125;
            // 
            // UserControlPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerPayment);
            Name = "UserControlPaymentHistory";
            Size = new Size(1452, 988);
            splitContainerPayment.Panel1.ResumeLayout(false);
            splitContainerPayment.Panel2.ResumeLayout(false);
            splitContainerPayment.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).EndInit();
            splitContainerPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel2;
        private Label lbName;
        private Label label2;
        private Label label1;
        private Label label8;
        private Button btnPrint;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
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
    }
}