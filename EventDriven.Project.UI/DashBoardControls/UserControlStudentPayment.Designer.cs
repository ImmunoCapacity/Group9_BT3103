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
            panel2 = new Panel();
            label1 = new Label();
            lbId = new Label();
            label3 = new Label();
            lbName = new Label();
            label2 = new Label();
            panel3 = new Panel();
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
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearchStuIn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).BeginInit();
            splitContainerPayment.Panel1.SuspendLayout();
            splitContainerPayment.Panel2.SuspendLayout();
            splitContainerPayment.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            splitContainerPayment.Panel2.Controls.Add(panel2);
            splitContainerPayment.Panel2.Controls.Add(lbId);
            splitContainerPayment.Panel2.Controls.Add(label3);
            splitContainerPayment.Panel2.Controls.Add(lbName);
            splitContainerPayment.Panel2.Controls.Add(label2);
            splitContainerPayment.Panel2.Controls.Add(panel3);
            splitContainerPayment.Size = new Size(1452, 988);
            splitContainerPayment.SplitterDistance = 856;
            splitContainerPayment.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(27, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 50);
            panel2.TabIndex = 165;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 33);
            label1.TabIndex = 0;
            label1.Text = "Payment Information:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbId.Location = new Point(134, 135);
            lbId.Name = "lbId";
            lbId.Size = new Size(26, 29);
            lbId.TabIndex = 164;
            lbId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 135);
            label3.Name = "label3";
            label3.Size = new Size(44, 29);
            label3.TabIndex = 163;
            label3.Text = "ID:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(134, 89);
            lbName.Name = "lbName";
            lbName.Size = new Size(115, 29);
            lbName.TabIndex = 150;
            lbName.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
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
            panel3.Location = new Point(47, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 746);
            panel3.TabIndex = 162;
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.BackColor = Color.SeaShell;
            lbBalance.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBalance.Location = new Point(276, 221);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(58, 29);
            lbBalance.TabIndex = 162;
            lbBalance.Text = "0.00";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.BackColor = Color.SeaShell;
            lbChange.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbChange.Location = new Point(156, 172);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(58, 29);
            lbChange.TabIndex = 161;
            lbChange.Text = "0.00";
            // 
            // rbPartialPayment
            // 
            rbPartialPayment.AutoSize = true;
            rbPartialPayment.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            rbPartialPayment.Location = new Point(61, 422);
            rbPartialPayment.Name = "rbPartialPayment";
            rbPartialPayment.Size = new Size(193, 33);
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
            btnPrint.Location = new Point(147, 631);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(218, 45);
            btnPrint.TabIndex = 161;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // rbFullPayment
            // 
            rbFullPayment.AutoSize = true;
            rbFullPayment.Checked = true;
            rbFullPayment.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            rbFullPayment.Location = new Point(61, 346);
            rbFullPayment.Name = "rbFullPayment";
            rbFullPayment.Size = new Size(165, 33);
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
            label4.Location = new Point(51, 304);
            label4.Name = "label4";
            label4.Size = new Size(175, 29);
            label4.TabIndex = 151;
            label4.Text = "Payment Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 79);
            label6.Name = "label6";
            label6.Size = new Size(200, 29);
            label6.TabIndex = 153;
            label6.Text = "Payment Received:";
            // 
            // txtPaymentReceived
            // 
            txtPaymentReceived.Location = new Point(61, 111);
            txtPaymentReceived.Margin = new Padding(3, 3, 10, 3);
            txtPaymentReceived.Name = "txtPaymentReceived";
            txtPaymentReceived.Size = new Size(277, 27);
            txtPaymentReceived.TabIndex = 154;
            txtPaymentReceived.Text = "0.00";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.White;
            btnPay.FlatStyle = FlatStyle.System;
            btnPay.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.SteelBlue;
            btnPay.Location = new Point(147, 555);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(216, 45);
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
            label8.Location = new Point(59, 221);
            label8.Name = "label8";
            label8.Size = new Size(211, 29);
            label8.TabIndex = 157;
            label8.Text = "Remaining Balance:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SeaShell;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(61, 172);
            label7.Name = "label7";
            label7.Size = new Size(94, 29);
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
            Column6.Width = 125;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Remaining Balance";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 170;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "TotalPaid";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 103;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "TuitionFee";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 113;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Grade Level";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 122;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 200;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 54;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7 });
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
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
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
            dataGridView1.Size = new Size(856, 911);
            dataGridView1.TabIndex = 149;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(112, 26);
            txtSearch.Margin = new Padding(3, 3, 10, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(499, 27);
            txtSearch.TabIndex = 147;
            // 
            // btnSearchStuIn
            // 
            btnSearchStuIn.BackColor = Color.White;
            btnSearchStuIn.FlatStyle = FlatStyle.System;
            btnSearchStuIn.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStuIn.ForeColor = Color.SteelBlue;
            btnSearchStuIn.Location = new Point(624, 16);
            btnSearchStuIn.Margin = new Padding(3, 4, 3, 4);
            btnSearchStuIn.Name = "btnSearchStuIn";
            btnSearchStuIn.Size = new Size(120, 45);
            btnSearchStuIn.TabIndex = 148;
            btnSearchStuIn.Text = "Search";
            btnSearchStuIn.UseVisualStyleBackColor = false;
            btnSearchStuIn.Click += btnSearchStuIn_Click;
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
            // UserControlStudentPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerPayment);
            Name = "UserControlStudentPayment";
            Size = new Size(1452, 988);
            splitContainerPayment.Panel1.ResumeLayout(false);
            splitContainerPayment.Panel2.ResumeLayout(false);
            splitContainerPayment.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).EndInit();
            splitContainerPayment.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel1;
        private Button btnSearchStuIn;
        private TextBox txtSearch;
    }
}