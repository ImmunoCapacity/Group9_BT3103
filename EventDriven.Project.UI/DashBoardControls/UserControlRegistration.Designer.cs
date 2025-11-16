namespace EventDriven.Project.UI.DashBoardControls
{
    partial class UserControlRegistration
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
            txtMiddleName = new TextBox();
            label21 = new Label();
            txtLastName = new TextBox();
            label20 = new Label();
            btnPrint = new Button();
            btnSave = new Button();
            cbOld = new CheckBox();
            cbTransferee = new CheckBox();
            cbNew = new CheckBox();
            cmbSection = new ComboBox();
            label19 = new Label();
            cmbGradeLevel = new ComboBox();
            txtEmail = new TextBox();
            txtGuardian = new TextBox();
            label14 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbSuffix = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            txtContactNo = new TextBox();
            txtAddress = new TextBox();
            txtFirstname = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSearchStudentIn = new TextBox();
            btnSearch = new Button();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtMiddleName
            // 
            txtMiddleName.AccessibleRole = AccessibleRole.IpAddress;
            txtMiddleName.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtMiddleName.Location = new Point(1023, 213);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(183, 29);
            txtMiddleName.TabIndex = 94;
            // 
            // label21
            // 
            label21.AccessibleRole = AccessibleRole.IpAddress;
            label21.AutoSize = true;
            label21.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label21.Location = new Point(888, 215);
            label21.Name = "label21";
            label21.Size = new Size(128, 24);
            label21.TabIndex = 93;
            label21.Text = "Middle Name:";
            // 
            // txtLastName
            // 
            txtLastName.AccessibleRole = AccessibleRole.IpAddress;
            txtLastName.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtLastName.Location = new Point(681, 213);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 29);
            txtLastName.TabIndex = 92;
            // 
            // label20
            // 
            label20.AccessibleRole = AccessibleRole.IpAddress;
            label20.AutoSize = true;
            label20.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label20.Location = new Point(572, 215);
            label20.Name = "label20";
            label20.Size = new Size(105, 24);
            label20.TabIndex = 91;
            label20.Text = "Last Name:";
            // 
            // btnPrint
            // 
            btnPrint.AccessibleRole = AccessibleRole.IpAddress;
            btnPrint.Anchor = AnchorStyles.Left;
            btnPrint.FlatAppearance.BorderColor = Color.Firebrick;
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnPrint.ForeColor = Color.FromArgb(64, 64, 64);
            btnPrint.Location = new Point(791, 851);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(178, 56);
            btnPrint.TabIndex = 90;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSave
            // 
            btnSave.AccessibleRole = AccessibleRole.IpAddress;
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.FlatAppearance.BorderColor = Color.Firebrick;
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(64, 64, 64);
            btnSave.Location = new Point(521, 851);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 56);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbOld
            // 
            cbOld.AccessibleRole = AccessibleRole.IpAddress;
            cbOld.AutoSize = true;
            cbOld.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            cbOld.Location = new Point(709, 542);
            cbOld.Name = "cbOld";
            cbOld.Size = new Size(61, 28);
            cbOld.TabIndex = 89;
            cbOld.Text = "Old";
            cbOld.UseVisualStyleBackColor = true;
            // 
            // cbTransferee
            // 
            cbTransferee.AccessibleRole = AccessibleRole.IpAddress;
            cbTransferee.AutoSize = true;
            cbTransferee.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            cbTransferee.Location = new Point(548, 542);
            cbTransferee.Name = "cbTransferee";
            cbTransferee.Size = new Size(122, 28);
            cbTransferee.TabIndex = 88;
            cbTransferee.Text = "Transferee";
            cbTransferee.UseVisualStyleBackColor = true;
            // 
            // cbNew
            // 
            cbNew.AccessibleRole = AccessibleRole.IpAddress;
            cbNew.AutoSize = true;
            cbNew.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            cbNew.Location = new Point(441, 542);
            cbNew.Name = "cbNew";
            cbNew.Size = new Size(69, 28);
            cbNew.TabIndex = 87;
            cbNew.Text = "New";
            cbNew.UseVisualStyleBackColor = true;
            // 
            // cmbSection
            // 
            cmbSection.AccessibleRole = AccessibleRole.IpAddress;
            cmbSection.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "7-A", "7-B", "7-C", "8-A", "8-B", "8-C", "9-A", "9-B", "9-C", "10-A", "10-B", "10-C" });
            cmbSection.Location = new Point(877, 488);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(329, 32);
            cmbSection.TabIndex = 86;
            // 
            // label19
            // 
            label19.AccessibleRole = AccessibleRole.IpAddress;
            label19.AutoSize = true;
            label19.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label19.Location = new Point(794, 491);
            label19.Name = "label19";
            label19.Size = new Size(77, 24);
            label19.TabIndex = 85;
            label19.Text = "Section:\r\n";
            // 
            // cmbGradeLevel
            // 
            cmbGradeLevel.AccessibleRole = AccessibleRole.IpAddress;
            cmbGradeLevel.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            cmbGradeLevel.FormattingEnabled = true;
            cmbGradeLevel.Items.AddRange(new object[] { "Grade 7", "Grade 8", "Grade 9", "Grade 10" });
            cmbGradeLevel.Location = new Point(441, 492);
            cmbGradeLevel.Name = "cmbGradeLevel";
            cmbGradeLevel.Size = new Size(332, 32);
            cmbGradeLevel.TabIndex = 84;
            // 
            // txtEmail
            // 
            txtEmail.AccessibleRole = AccessibleRole.IpAddress;
            txtEmail.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtEmail.Location = new Point(857, 380);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 29);
            txtEmail.TabIndex = 76;
            // 
            // txtGuardian
            // 
            txtGuardian.AccessibleRole = AccessibleRole.IpAddress;
            txtGuardian.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtGuardian.Location = new Point(340, 439);
            txtGuardian.Name = "txtGuardian";
            txtGuardian.Size = new Size(433, 29);
            txtGuardian.TabIndex = 75;
            // 
            // label14
            // 
            label14.AccessibleRole = AccessibleRole.IpAddress;
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label14.Location = new Point(791, 382);
            label14.Name = "label14";
            label14.Size = new Size(65, 24);
            label14.TabIndex = 69;
            label14.Text = "Email:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleRole = AccessibleRole.IpAddress;
            dateTimePicker1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(370, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(403, 29);
            dateTimePicker1.TabIndex = 68;
            // 
            // cmbGender
            // 
            cmbGender.AccessibleRole = AccessibleRole.IpAddress;
            cmbGender.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(879, 266);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(108, 32);
            cmbGender.TabIndex = 67;
            // 
            // cmbSuffix
            // 
            cmbSuffix.AccessibleRole = AccessibleRole.IpAddress;
            cmbSuffix.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            cmbSuffix.FormattingEnabled = true;
            cmbSuffix.Location = new Point(1110, 265);
            cmbSuffix.Name = "cmbSuffix";
            cmbSuffix.Size = new Size(96, 32);
            cmbSuffix.TabIndex = 66;
            // 
            // label13
            // 
            label13.AccessibleRole = AccessibleRole.IpAddress;
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label13.Location = new Point(794, 269);
            label13.Name = "label13";
            label13.Size = new Size(76, 24);
            label13.TabIndex = 65;
            label13.Text = "Gender:";
            // 
            // label12
            // 
            label12.AccessibleRole = AccessibleRole.IpAddress;
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label12.Location = new Point(1019, 268);
            label12.Name = "label12";
            label12.Size = new Size(67, 24);
            label12.TabIndex = 64;
            label12.Text = "Suffix:";
            // 
            // txtContactNo
            // 
            txtContactNo.AccessibleRole = AccessibleRole.IpAddress;
            txtContactNo.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtContactNo.Location = new Point(367, 382);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(406, 29);
            txtContactNo.TabIndex = 63;
            // 
            // txtAddress
            // 
            txtAddress.AccessibleRole = AccessibleRole.IpAddress;
            txtAddress.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtAddress.Location = new Point(331, 327);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(875, 29);
            txtAddress.TabIndex = 62;
            // 
            // txtFirstname
            // 
            txtFirstname.AccessibleRole = AccessibleRole.IpAddress;
            txtFirstname.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtFirstname.Location = new Point(356, 213);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(196, 29);
            txtFirstname.TabIndex = 53;
            // 
            // label11
            // 
            label11.AccessibleRole = AccessibleRole.IpAddress;
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label11.Location = new Point(310, 542);
            label11.Name = "label11";
            label11.Size = new Size(121, 24);
            label11.TabIndex = 61;
            label11.Text = "Sudent Type:";
            // 
            // label10
            // 
            label10.AccessibleRole = AccessibleRole.IpAddress;
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label10.Location = new Point(242, 492);
            label10.Name = "label10";
            label10.Size = new Size(194, 24);
            label10.TabIndex = 60;
            label10.Text = "Grade Level to Enroll:";
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.IpAddress;
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label7.Location = new Point(242, 441);
            label7.Name = "label7";
            label7.Size = new Size(95, 24);
            label7.TabIndex = 57;
            label7.Text = "Guardian:";
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.IpAddress;
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label4.Location = new Point(242, 381);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 54;
            label4.Text = "Contact No. :";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.IpAddress;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label3.Location = new Point(242, 326);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 51;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.IpAddress;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label2.Location = new Point(242, 269);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 50;
            label2.Text = "Date of Birth:";
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.IpAddress;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label1.Location = new Point(242, 212);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 49;
            label1.Text = "First Name:";
            // 
            // txtSearchStudentIn
            // 
            txtSearchStudentIn.AccessibleRole = AccessibleRole.IpAddress;
            txtSearchStudentIn.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtSearchStudentIn.Location = new Point(602, 138);
            txtSearchStudentIn.Margin = new Padding(3, 3, 10, 3);
            txtSearchStudentIn.Name = "txtSearchStudentIn";
            txtSearchStudentIn.Size = new Size(483, 29);
            txtSearchStudentIn.TabIndex = 96;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleRole = AccessibleRole.IpAddress;
            btnSearch.FlatAppearance.BorderColor = Color.Firebrick;
            btnSearch.FlatStyle = FlatStyle.System;
            btnSearch.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(64, 64, 64);
            btnSearch.Location = new Point(1098, 130);
            btnSearch.Margin = new Padding(3, 3, 10, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 47);
            btnSearch.TabIndex = 97;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 946);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 100;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(242, 112);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(359, 83);
            flowLayoutPanel1.TabIndex = 101;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_friend;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Margin = new Padding(3, 3, 50, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 69);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.edit;
            pictureBox3.Location = new Point(122, 3);
            pictureBox3.Margin = new Padding(3, 3, 50, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 69);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bin;
            pictureBox4.Location = new Point(241, 3);
            pictureBox4.Margin = new Padding(3, 3, 50, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 69);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.IpAddress;
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label8.Location = new Point(297, 592);
            label8.Name = "label8";
            label8.Size = new Size(133, 24);
            label8.TabIndex = 284;
            label8.Text = "Requirements:";
            // 
            // label9
            // 
            label9.AccessibleRole = AccessibleRole.IpAddress;
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label9.Location = new Point(771, 592);
            label9.Name = "label9";
            label9.Size = new Size(163, 24);
            label9.TabIndex = 285;
            label9.Text = "Mode of Payment:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Good Moral", "Form 137", "Birth Certificate" });
            checkedListBox1.Location = new Point(436, 592);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(159, 70);
            checkedListBox1.TabIndex = 286;
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Partial", "Full" });
            checkedListBox2.Location = new Point(940, 592);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(179, 70);
            checkedListBox2.TabIndex = 287;
            // 
            // UserControlRegistration
            // 
            AccessibleRole = AccessibleRole.IpAddress;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(txtSearchStudentIn);
            Controls.Add(btnSearch);
            Controls.Add(txtMiddleName);
            Controls.Add(label21);
            Controls.Add(txtLastName);
            Controls.Add(label20);
            Controls.Add(btnPrint);
            Controls.Add(btnSave);
            Controls.Add(cbOld);
            Controls.Add(cbTransferee);
            Controls.Add(cbNew);
            Controls.Add(cmbSection);
            Controls.Add(label19);
            Controls.Add(cmbGradeLevel);
            Controls.Add(txtEmail);
            Controls.Add(txtGuardian);
            Controls.Add(label14);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbGender);
            Controls.Add(cmbSuffix);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtContactNo);
            Controls.Add(txtAddress);
            Controls.Add(txtFirstname);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlRegistration";
            Size = new Size(1470, 973);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMiddleName;
        private Label label21;
        private TextBox txtLastName;
        private Label label20;
        private Button btnPrint;
        public Button btnSave;
        private CheckBox cbOld;
        private CheckBox cbTransferee;
        private CheckBox cbNew;
        private ComboBox cmbSection;
        private Label label19;
        private ComboBox cmbGradeLevel;
        private TextBox txtEmail;
        private TextBox txtGuardian;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbGender;
        private ComboBox cmbSuffix;
        private Label label13;
        private Label label12;
        private TextBox txtContactNo;
        private TextBox txtAddress;
        private TextBox txtFirstname;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtSearchStudentIn;
        private Button btnSearch;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label8;
        private Label label9;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        //private Label label25;
    }
}

