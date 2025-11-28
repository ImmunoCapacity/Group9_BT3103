namespace EventDriven.Project.UI.DashBoardControls
{
    partial class UserControlStudentPayment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainerPayment = new SplitContainer();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            panel1 = new Panel();
            cmbIfPay = new ComboBox();
            btnSearchStuIn = new Button();
            txtSearch = new TextBox();
            btnSOA = new Button();
            panel2 = new Panel();
            label1 = new Label();
            lbId = new Label();
            label3 = new Label();
            lbName = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            lbBalance = new Label();
            lbChange = new Label();
            rbPartialPayment = new RadioButton();
            btnPrint = new Button();
            rbFullPayment = new RadioButton();
            label4 = new Label();
            label6 = new Label();
            txtPaymentReceived = new TextBox();
            btnPay = new Button();
            label8 = new Label();
            label7 = new Label();
            Column6 = new DataGridViewTextBoxColumn();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).BeginInit();
            splitContainerPayment.Panel1.SuspendLayout();
            splitContainerPayment.Panel2.SuspendLayout();
            splitContainerPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            splitContainerPayment.Panel1.Controls.Add(dataGridView2);
            splitContainerPayment.Panel1.Controls.Add(label5);
            splitContainerPayment.Panel1.Controls.Add(panel1);
            // 
            // splitContainerPayment.Panel2
            // 
            splitContainerPayment.Panel2.BackColor = Color.BurlyWood;
            splitContainerPayment.Panel2.Controls.Add(btnSOA);
            splitContainerPayment.Panel2.Controls.Add(panel2);
            splitContainerPayment.Panel2.Controls.Add(lbId);
            splitContainerPayment.Panel2.Controls.Add(label3);
            splitContainerPayment.Panel2.Controls.Add(lbName);
            splitContainerPayment.Panel2.Controls.Add(label2);
            splitContainerPayment.Panel2.Controls.Add(panel3);
            splitContainerPayment.Size = new Size(1270, 741);
            splitContainerPayment.SplitterDistance = 747;
            splitContainerPayment.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.BackgroundColor = Color.SeaShell;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column11, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column8, Column9, Column10 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.SeaShell;
            dataGridView2.Location = new Point(0, 85);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SeaShell;
            dataGridViewCellStyle4.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(856, 841);
            dataGridView2.TabIndex = 150;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 200;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 262;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "Grade Level";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 96;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "TuitionFee";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 92;
            // 
            // Column11
            // 
            Column11.HeaderText = "Tuition";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.HeaderText = "TotalPaid";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 84;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.HeaderText = "Remaining Balance";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 137;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Due Date";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 80;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Description";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 96;
            // 
            // Column10
            // 
            Column10.HeaderText = "Type";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(337, 60);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 166;
            label5.Text = "Incoming";
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbIfPay);
            panel1.Controls.Add(btnSearchStuIn);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 58);
            panel1.TabIndex = 148;
            // 
            // cmbIfPay
            // 
            cmbIfPay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIfPay.FormattingEnabled = true;
            cmbIfPay.Items.AddRange(new object[] { "Unpaid", "Paid" });
            cmbIfPay.Location = new Point(24, 30);
            cmbIfPay.Name = "cmbIfPay";
            cmbIfPay.Size = new Size(171, 28);
            cmbIfPay.TabIndex = 152;
            cmbIfPay.SelectedIndexChanged += cmbIfPay_SelectedIndexChanged;
            // 
            // btnSearchStuIn
            // 
            btnSearchStuIn.BackColor = Color.White;
            btnSearchStuIn.FlatStyle = FlatStyle.System;
            btnSearchStuIn.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStuIn.ForeColor = Color.SteelBlue;
            btnSearchStuIn.Location = new Point(713, 19);
            btnSearchStuIn.Margin = new Padding(3, 4, 3, 4);
            btnSearchStuIn.Name = "btnSearchStuIn";
            btnSearchStuIn.Size = new Size(105, 34);
            btnSearchStuIn.TabIndex = 148;
            btnSearchStuIn.Text = "Search";
            btnSearchStuIn.UseVisualStyleBackColor = false;
            btnSearchStuIn.Click += btnSearchStuIn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(201, 30);
            txtSearch.Margin = new Padding(3, 3, 10, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(437, 23);
            txtSearch.TabIndex = 147;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSOA
            // 
            btnSOA.BackColor = Color.White;
            btnSOA.FlatStyle = FlatStyle.System;
            btnSOA.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSOA.ForeColor = Color.SteelBlue;
            btnSOA.Location = new Point(134, 895);
            btnSOA.Margin = new Padding(3, 4, 3, 4);
            btnSOA.Name = "btnSOA";
            btnSOA.Size = new Size(328, 45);
            btnSOA.TabIndex = 164;
            btnSOA.Text = "Print Statement of Account";
            btnSOA.UseVisualStyleBackColor = false;
            btnSOA.Click += btnSOA_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(24, 10);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 38);
            panel2.TabIndex = 165;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 7);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 0;
            label1.Text = "Payment Information:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbId.Location = new Point(117, 101);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 23);
            lbId.TabIndex = 164;
            lbId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 101);
            label3.Name = "label3";
            label3.Size = new Size(35, 23);
            label3.TabIndex = 163;
            label3.Text = "ID:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(117, 67);
            lbName.Name = "lbName";
            lbName.Size = new Size(133, 29);
            lbName.TabIndex = 150;
            lbName.Text = "---------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 67);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lbBalance);
            panel3.Controls.Add(lbChange);
            panel3.Controls.Add(rbPartialPayment);
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(rbFullPayment);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtPaymentReceived);
            panel3.Controls.Add(btnPay);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(41, 144);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 660);
            panel3.TabIndex = 162;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(37, 114);
            label10.Name = "label10";
            label10.Size = new Size(19, 20);
            label10.TabIndex = 163;
            label10.Text = "₱";
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.BackColor = Color.SeaShell;
            lbBalance.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBalance.Location = new Point(242, 166);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(57, 23);
            lbBalance.TabIndex = 162;
            lbBalance.Text = "₱0.00";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.BackColor = Color.SeaShell;
            lbChange.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbChange.Location = new Point(136, 129);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(57, 23);
            lbChange.TabIndex = 161;
            lbChange.Text = "₱0.00";
            lbChange.Click += lbChange_Click;
            // 
            // rbPartialPayment
            // 
            rbPartialPayment.AutoSize = true;
            rbPartialPayment.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            rbPartialPayment.Location = new Point(53, 316);
            rbPartialPayment.Margin = new Padding(3, 2, 3, 2);
            rbPartialPayment.Name = "rbPartialPayment";
            rbPartialPayment.Size = new Size(157, 27);
            rbPartialPayment.TabIndex = 160;
            rbPartialPayment.Text = "Partial Payment";
            rbPartialPayment.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.SteelBlue;
            btnPrint.Location = new Point(147, 555);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(191, 34);
            btnPrint.TabIndex = 161;
            btnPrint.Text = "Print Receipt";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // rbFullPayment
            // 
            rbFullPayment.AutoSize = true;
            rbFullPayment.Checked = true;
            rbFullPayment.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            rbFullPayment.Location = new Point(53, 260);
            rbFullPayment.Margin = new Padding(3, 2, 3, 2);
            rbFullPayment.Name = "rbFullPayment";
            rbFullPayment.Size = new Size(134, 27);
            rbFullPayment.TabIndex = 0;
            rbFullPayment.TabStop = true;
            rbFullPayment.Text = "Full Payment";
            rbFullPayment.UseVisualStyleBackColor = true;
            rbFullPayment.CheckedChanged += rbFullPayment_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 228);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 151;
            label4.Text = "Payment Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 59);
            label6.Name = "label6";
            label6.Size = new Size(161, 23);
            label6.TabIndex = 153;
            label6.Text = "Payment Received:";
            // 
            // txtPaymentReceived
            // 
            txtPaymentReceived.Location = new Point(53, 83);
            txtPaymentReceived.Margin = new Padding(3, 2, 9, 2);
            txtPaymentReceived.Name = "txtPaymentReceived";
            txtPaymentReceived.Size = new Size(243, 23);
            txtPaymentReceived.TabIndex = 154;
            txtPaymentReceived.Text = "0.00";
            txtPaymentReceived.TextChanged += txtPaymentReceived_TextChanged;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.White;
            btnPay.FlatStyle = FlatStyle.System;
            btnPay.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.SteelBlue;
            btnPay.Location = new Point(147, 502);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(189, 34);
            btnPay.TabIndex = 159;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SeaShell;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(52, 166);
            label8.Name = "label8";
            label8.Size = new Size(168, 23);
            label8.TabIndex = 157;
            label8.Text = "Remaining Balance:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SeaShell;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 129);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 155;
            label7.Text = "Change:";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Date of Birth";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // UserControlStudentPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerPayment);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlStudentPayment";
            Size = new Size(1270, 741);
            splitContainerPayment.Panel1.ResumeLayout(false);
            splitContainerPayment.Panel1.PerformLayout();
            splitContainerPayment.Panel2.ResumeLayout(false);
            splitContainerPayment.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).EndInit();
            splitContainerPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerPayment;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn ColEdit;
        private DataGridViewImageColumn ColDelete;
        private Label lbName;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label7;
        private TextBox txtPaymentReceived;
        private Label label6;
        private Button btnPay;
        private Label label8;
        private Button btnPrint;
        private Panel panel3;
        private RadioButton rbFullPayment;
        private RadioButton rbPartialPayment;
        private Label lbBalance;
        private Label lbChange;
        private Label lbId;
        private Label label3;
        private Panel panel2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private Panel panel1;
        private Button btnSearchStuIn;
        private TextBox txtSearch;
        private Label label5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label10;
        private Button btnSOA;
        private ComboBox cmbIfPay;
    }
}