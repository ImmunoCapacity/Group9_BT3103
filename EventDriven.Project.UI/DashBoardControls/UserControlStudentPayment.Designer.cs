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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudentPayment));
            splitContainerPayment = new SplitContainer();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            //ColEdit = new DataGridViewImageColumn();
            //ColDelete = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnSearchStuIn = new Button();
            txtSearch = new TextBox();
            btnPrint = new Button();
            label1 = new Label();
            btnSave = new Button();
            btnPay = new Button();
            lblBalance = new Label();
            label8 = new Label();
            lblChange = new Label();
            label7 = new Label();
            txtPaymentReceived = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainerPayment).BeginInit();
            splitContainerPayment.Panel1.SuspendLayout();
            splitContainerPayment.Panel2.SuspendLayout();
            splitContainerPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainerPayment.Panel2.Controls.Add(btnPrint);
            splitContainerPayment.Panel2.Controls.Add(label1);
            splitContainerPayment.Panel2.Controls.Add(btnSave);
            splitContainerPayment.Panel2.Controls.Add(btnPay);
            splitContainerPayment.Panel2.Controls.Add(lblBalance);
            splitContainerPayment.Panel2.Controls.Add(label8);
            splitContainerPayment.Panel2.Controls.Add(lblChange);
            splitContainerPayment.Panel2.Controls.Add(label7);
            splitContainerPayment.Panel2.Controls.Add(txtPaymentReceived);
            splitContainerPayment.Panel2.Controls.Add(label6);
            splitContainerPayment.Panel2.Controls.Add(label5);
            splitContainerPayment.Panel2.Controls.Add(label4);
            splitContainerPayment.Panel2.Controls.Add(label3);
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
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5});
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
            dataGridView1.Size = new Size(856, 911);
            dataGridView1.TabIndex = 149;
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
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Contact";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 91;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Grade Level";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 122;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Date of Birth";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 128;
            // 
            // ColEdit
            // 
            //ColEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //ColEdit.HeaderText = "";
            //ColEdit.Image = (Image)resources.GetObject("ColEdit.Image");
            //ColEdit.MinimumWidth = 6;
            //ColEdit.Name = "ColEdit";
            //ColEdit.ReadOnly = true;
            //ColEdit.Width = 6;
            // 
            // ColDelete
            // 
            //ColDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //ColDelete.HeaderText = "";
            //ColDelete.Image = (Image)resources.GetObject("ColDelete.Image");
            //ColDelete.MinimumWidth = 6;
            //ColDelete.Name = "ColDelete";
            //ColDelete.ReadOnly = true;
            //ColDelete.Width = 6;
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
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.SteelBlue;
            btnPrint.Location = new Point(326, 862);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 45);
            btnPrint.TabIndex = 161;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
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
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.SteelBlue;
            btnSave.Location = new Point(154, 862);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 45);
            btnSave.TabIndex = 160;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.White;
            btnPay.FlatStyle = FlatStyle.System;
            btnPay.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.SteelBlue;
            btnPay.Location = new Point(394, 533);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(120, 45);
            btnPay.TabIndex = 159;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.SeaShell;
            lblBalance.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(85, 754);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(150, 29);
            lblBalance.TabIndex = 158;
            lblBalance.Text = "Balance (int):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SeaShell;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(85, 701);
            label8.Name = "label8";
            label8.Size = new Size(211, 29);
            label8.TabIndex = 157;
            label8.Text = "Remaining Balance:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.BackColor = Color.SeaShell;
            lblChange.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(85, 643);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(146, 29);
            lblChange.TabIndex = 156;
            lblChange.Text = "Change (int):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SeaShell;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(85, 589);
            label7.Name = "label7";
            label7.Size = new Size(94, 29);
            label7.TabIndex = 155;
            label7.Text = "Change:";
            // 
            // txtPaymentReceived
            // 
            txtPaymentReceived.Location = new Point(85, 543);
            txtPaymentReceived.Margin = new Padding(3, 3, 10, 3);
            txtPaymentReceived.Name = "txtPaymentReceived";
            txtPaymentReceived.Size = new Size(277, 27);
            txtPaymentReceived.TabIndex = 154;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 498);
            label6.Name = "label6";
            label6.Size = new Size(200, 29);
            label6.TabIndex = 153;
            label6.Text = "Payment Received:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(207, 281);
            label5.Name = "label5";
            label5.Size = new Size(337, 29);
            label5.TabIndex = 152;
            label5.Text = "Full Payment or Partial Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 281);
            label4.Name = "label4";
            label4.Size = new Size(175, 29);
            label4.TabIndex = 151;
            label4.Text = "Payment Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 229);
            label3.Name = "label3";
            label3.Size = new Size(115, 29);
            label3.TabIndex = 150;
            label3.Text = "Full Name";
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
            panel3.Location = new Point(47, 453);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 510);
            panel3.TabIndex = 162;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerPayment;
        private TextBox txtSearch;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn ColEdit;
        private DataGridViewImageColumn ColDelete;
        private Button btnSearchStuIn;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label lblChange;
        private Label label7;
        private TextBox txtPaymentReceived;
        private Label label6;
        private Button btnPay;
        private Label lblBalance;
        private Label label8;
        private Button btnSave;
        private Button btnPrint;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
    }
}