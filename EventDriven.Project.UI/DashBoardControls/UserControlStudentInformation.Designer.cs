namespace EventDriven.Project.UI
{
    partial class UserControlStudentInformation
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
            txtGWA = new TextBox();
            label18 = new Label();
            txtLastGrade = new TextBox();
            txtLastSchool = new TextBox();
            txtRelationship = new TextBox();
            txtMotherContact = new TextBox();
            txtFatherContactNo = new TextBox();
            txtEmail = new TextBox();
            txtGuardian = new TextBox();
            txtMotherName = new TextBox();
            txtFatherName = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbSuffix = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            txtContactNo = new TextBox();
            txtAddress = new TextBox();
            txtFullname = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddStudInfo = new Button();
            btnEditStudInfo = new Button();
            btnDeleteStudInfo = new Button();
            txtSearchStudentIn = new TextBox();
            btnSearchStudInfo = new Button();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(819, 134);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(183, 27);
            txtMiddleName.TabIndex = 94;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(684, 136);
            label21.Name = "label21";
            label21.Size = new Size(129, 25);
            label21.TabIndex = 93;
            label21.Text = "Middle Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(477, 134);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 27);
            txtLastName.TabIndex = 92;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(368, 136);
            label20.Name = "label20";
            label20.Size = new Size(103, 25);
            label20.TabIndex = 91;
            label20.Text = "Last Name:";
            // 
            // btnPrint
            // 
            btnPrint.FlatAppearance.BorderColor = Color.Firebrick;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.FromArgb(64, 64, 64);
            btnPrint.Location = new Point(587, 708);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(178, 56);
            btnPrint.TabIndex = 90;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.Firebrick;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(64, 64, 64);
            btnSave.Location = new Point(293, 708);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 56);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbOld
            // 
            cbOld.AutoSize = true;
            cbOld.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbOld.Location = new Point(505, 656);
            cbOld.Name = "cbOld";
            cbOld.Size = new Size(64, 29);
            cbOld.TabIndex = 89;
            cbOld.Text = "Old";
            cbOld.UseVisualStyleBackColor = true;
            cbOld.Click += cbOld_CheckedChanged;
            // 
            // cbTransferee
            // 
            cbTransferee.AutoSize = true;
            cbTransferee.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTransferee.Location = new Point(344, 656);
            cbTransferee.Name = "cbTransferee";
            cbTransferee.Size = new Size(121, 29);
            cbTransferee.TabIndex = 88;
            cbTransferee.Text = "Transferee";
            cbTransferee.UseVisualStyleBackColor = true;
            cbTransferee.Click += cbTransferee_CheckedChanged;
            // 
            // cbNew
            // 
            cbNew.AutoSize = true;
            cbNew.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbNew.Location = new Point(237, 656);
            cbNew.Name = "cbNew";
            cbNew.Size = new Size(72, 29);
            cbNew.TabIndex = 87;
            cbNew.Text = "New";
            cbNew.UseVisualStyleBackColor = true;
            cbNew.Click += cbNew_CheckedChanged;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(673, 602);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(329, 28);
            cmbSection.TabIndex = 86;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(590, 605);
            label19.Name = "label19";
            label19.Size = new Size(78, 25);
            label19.TabIndex = 85;
            label19.Text = "Section:\r\n";
            // 
            // cmbGradeLevel
            // 
            cmbGradeLevel.FormattingEnabled = true;
            cmbGradeLevel.Location = new Point(237, 606);
            cmbGradeLevel.Name = "cmbGradeLevel";
            cmbGradeLevel.Size = new Size(332, 28);
            cmbGradeLevel.TabIndex = 84;
            // 
            // txtGWA
            // 
            txtGWA.Location = new Point(650, 558);
            txtGWA.Name = "txtGWA";
            txtGWA.Size = new Size(352, 27);
            txtGWA.TabIndex = 83;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(587, 560);
            label18.Name = "label18";
            label18.Size = new Size(57, 25);
            label18.TabIndex = 82;
            label18.Text = "GWA:\r\n";
            // 
            // txtLastGrade
            // 
            txtLastGrade.Location = new Point(245, 561);
            txtLastGrade.Name = "txtLastGrade";
            txtLastGrade.Size = new Size(324, 27);
            txtLastGrade.TabIndex = 81;
            // 
            // txtLastSchool
            // 
            txtLastSchool.Location = new Point(237, 516);
            txtLastSchool.Name = "txtLastSchool";
            txtLastSchool.Size = new Size(765, 27);
            txtLastSchool.TabIndex = 80;
            // 
            // txtRelationship
            // 
            txtRelationship.Location = new Point(712, 459);
            txtRelationship.Name = "txtRelationship";
            txtRelationship.Size = new Size(290, 27);
            txtRelationship.TabIndex = 79;
            // 
            // txtMotherContact
            // 
            txtMotherContact.Location = new Point(673, 405);
            txtMotherContact.Name = "txtMotherContact";
            txtMotherContact.Size = new Size(329, 27);
            txtMotherContact.TabIndex = 78;
            // 
            // txtFatherContactNo
            // 
            txtFatherContactNo.Location = new Point(673, 355);
            txtFatherContactNo.Name = "txtFatherContactNo";
            txtFatherContactNo.Size = new Size(329, 27);
            txtFatherContactNo.TabIndex = 77;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(653, 301);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 27);
            txtEmail.TabIndex = 76;
            // 
            // txtGuardian
            // 
            txtGuardian.Location = new Point(136, 459);
            txtGuardian.Name = "txtGuardian";
            txtGuardian.Size = new Size(433, 27);
            txtGuardian.TabIndex = 75;
            // 
            // txtMotherName
            // 
            txtMotherName.Location = new Point(188, 407);
            txtMotherName.Name = "txtMotherName";
            txtMotherName.Size = new Size(381, 27);
            txtMotherName.TabIndex = 74;
            // 
            // txtFatherName
            // 
            txtFatherName.Location = new Point(175, 357);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new Size(394, 27);
            txtFatherName.TabIndex = 73;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(587, 461);
            label17.Name = "label17";
            label17.Size = new Size(119, 25);
            label17.TabIndex = 72;
            label17.Text = "Relationship:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(587, 407);
            label16.Name = "label16";
            label16.Size = new Size(80, 25);
            label16.TabIndex = 71;
            label16.Text = "Contact:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(587, 357);
            label15.Name = "label15";
            label15.Size = new Size(80, 25);
            label15.TabIndex = 70;
            label15.Text = "Contact:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(587, 303);
            label14.Name = "label14";
            label14.Size = new Size(60, 25);
            label14.TabIndex = 69;
            label14.Text = "Email:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(403, 27);
            dateTimePicker1.TabIndex = 68;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(675, 187);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(108, 28);
            cmbGender.TabIndex = 67;
            // 
            // cmbSuffix
            // 
            cmbSuffix.FormattingEnabled = true;
            cmbSuffix.Location = new Point(906, 186);
            cmbSuffix.Name = "cmbSuffix";
            cmbSuffix.Size = new Size(96, 28);
            cmbSuffix.TabIndex = 66;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(590, 190);
            label13.Name = "label13";
            label13.Size = new Size(79, 25);
            label13.TabIndex = 65;
            label13.Text = "Gender:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(815, 189);
            label12.Name = "label12";
            label12.Size = new Size(63, 25);
            label12.TabIndex = 64;
            label12.Text = "Suffix:";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(163, 303);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(406, 27);
            txtContactNo.TabIndex = 63;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(127, 248);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(875, 27);
            txtAddress.TabIndex = 62;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(152, 134);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(196, 27);
            txtFullname.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(62, 660);
            label11.Name = "label11";
            label11.Size = new Size(120, 25);
            label11.TabIndex = 61;
            label11.Text = "Sudent Type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(38, 606);
            label10.Name = "label10";
            label10.Size = new Size(190, 25);
            label10.TabIndex = 60;
            label10.Text = "Grade Level to Enroll:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 560);
            label9.Name = "label9";
            label9.Size = new Size(201, 25);
            label9.TabIndex = 59;
            label9.Text = "Last Grade Completed:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 515);
            label8.Name = "label8";
            label8.Size = new Size(193, 25);
            label8.TabIndex = 58;
            label8.Text = "Last School Attended:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 461);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 57;
            label7.Text = "Guardian:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 407);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 56;
            label6.Text = "Mother's Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 357);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 55;
            label5.Text = "Father's Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 302);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 54;
            label4.Text = "Contact No. :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 247);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 51;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 190);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 50;
            label2.Text = "Date of Birth:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 133);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 49;
            label1.Text = "First Name:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddStudInfo);
            flowLayoutPanel1.Controls.Add(btnEditStudInfo);
            flowLayoutPanel1.Controls.Add(btnDeleteStudInfo);
            flowLayoutPanel1.Location = new Point(3, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(402, 75);
            flowLayoutPanel1.TabIndex = 95;
            // 
            // btnAddStudInfo
            // 
            btnAddStudInfo.FlatAppearance.BorderColor = Color.Firebrick;
            btnAddStudInfo.FlatStyle = FlatStyle.Flat;
            btnAddStudInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudInfo.ForeColor = Color.FromArgb(64, 64, 64);
            btnAddStudInfo.Location = new Point(3, 3);
            btnAddStudInfo.Margin = new Padding(3, 3, 10, 3);
            btnAddStudInfo.Name = "btnAddStudInfo";
            btnAddStudInfo.Size = new Size(118, 56);
            btnAddStudInfo.TabIndex = 5;
            btnAddStudInfo.Text = "Add";
            btnAddStudInfo.UseVisualStyleBackColor = true;
            btnAddStudInfo.Click += BtnAddStudInfo_Click;
            // 
            // btnEditStudInfo
            // 
            btnEditStudInfo.FlatAppearance.BorderColor = Color.Firebrick;
            btnEditStudInfo.FlatStyle = FlatStyle.Flat;
            btnEditStudInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditStudInfo.ForeColor = Color.FromArgb(64, 64, 64);
            btnEditStudInfo.Location = new Point(134, 3);
            btnEditStudInfo.Margin = new Padding(3, 3, 10, 3);
            btnEditStudInfo.Name = "btnEditStudInfo";
            btnEditStudInfo.Size = new Size(118, 56);
            btnEditStudInfo.TabIndex = 6;
            btnEditStudInfo.Text = "Edit";
            btnEditStudInfo.UseVisualStyleBackColor = true;
            btnEditStudInfo.Click += BtnEditStudInfo_Click;
            // 
            // btnDeleteStudInfo
            // 
            btnDeleteStudInfo.FlatAppearance.BorderColor = Color.Firebrick;
            btnDeleteStudInfo.FlatStyle = FlatStyle.Flat;
            btnDeleteStudInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStudInfo.ForeColor = Color.FromArgb(64, 64, 64);
            btnDeleteStudInfo.Location = new Point(265, 3);
            btnDeleteStudInfo.Margin = new Padding(3, 3, 10, 3);
            btnDeleteStudInfo.Name = "btnDeleteStudInfo";
            btnDeleteStudInfo.Size = new Size(118, 56);
            btnDeleteStudInfo.TabIndex = 7;
            btnDeleteStudInfo.Text = "Delete";
            btnDeleteStudInfo.UseVisualStyleBackColor = true;
            btnDeleteStudInfo.Click += BtnDeleteStudInfo_Click;
            // 
            // txtSearchStudentIn
            // 
            txtSearchStudentIn.Location = new Point(411, 26);
            txtSearchStudentIn.Margin = new Padding(3, 3, 10, 3);
            txtSearchStudentIn.Name = "txtSearchStudentIn";
            txtSearchStudentIn.Size = new Size(447, 27);
            txtSearchStudentIn.TabIndex = 96;
            // 
            // btnSearchStudInfo
            // 
            btnSearchStudInfo.FlatAppearance.BorderColor = Color.Firebrick;
            btnSearchStudInfo.FlatStyle = FlatStyle.Flat;
            btnSearchStudInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStudInfo.ForeColor = Color.FromArgb(64, 64, 64);
            btnSearchStudInfo.Location = new Point(871, 26);
            btnSearchStudInfo.Margin = new Padding(3, 3, 10, 3);
            btnSearchStudInfo.Name = "btnSearchStudInfo";
            btnSearchStudInfo.Size = new Size(108, 45);
            btnSearchStudInfo.TabIndex = 97;
            btnSearchStudInfo.Text = "Search";
            btnSearchStudInfo.UseVisualStyleBackColor = true;
            btnSearchStudInfo.Click += BtnSearchStudInfo_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            // 
            // UserControlStudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearchStudentIn);
            Controls.Add(btnSearchStudInfo);
            Controls.Add(flowLayoutPanel1);
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
            Controls.Add(txtGWA);
            Controls.Add(label18);
            Controls.Add(txtLastGrade);
            Controls.Add(txtLastSchool);
            Controls.Add(txtRelationship);
            Controls.Add(txtMotherContact);
            Controls.Add(txtFatherContactNo);
            Controls.Add(txtEmail);
            Controls.Add(txtGuardian);
            Controls.Add(txtMotherName);
            Controls.Add(txtFatherName);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbGender);
            Controls.Add(cmbSuffix);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtContactNo);
            Controls.Add(txtAddress);
            Controls.Add(txtFullname);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlStudentInformation";
            Size = new Size(1470, 1035);
            Load += UserControlStudentInfo_Load;
            flowLayoutPanel1.ResumeLayout(false);
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
        private TextBox txtGWA;
        private Label label18;
        private TextBox txtLastGrade;
        private TextBox txtLastSchool;
        private TextBox txtRelationship;
        private TextBox txtMotherContact;
        private TextBox txtFatherContactNo;
        private TextBox txtEmail;
        private TextBox txtGuardian;
        private TextBox txtMotherName;
        private TextBox txtFatherName;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbGender;
        private ComboBox cmbSuffix;
        private Label label13;
        private Label label12;
        private TextBox txtContactNo;
        private TextBox txtAddress;
        private TextBox txtFullname;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAddStudInfo;
        private Button btnEditStudInfo;
        private Button btnDeleteStudInfo;
        public TextBox txtSearchStudentIn;
        private Button btnSearchStudInfo;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
