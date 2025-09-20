namespace EventDriven.Project.UI
{
    partial class FormStudentRegistration
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
            btnSave = new Button();
            btnPrint = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            cmbSearch = new ComboBox();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmbEnroll = new ComboBox();
            cmbSection = new ComboBox();
            label12 = new Label();
            txtBoxLastGrade = new PlaceholderTextBox();
            label13 = new Label();
            txtBoxGwa = new PlaceholderTextBox();
            txtBoxLastSchool = new PlaceholderTextBox();
            txtBoxGuardian = new PlaceholderTextBox();
            txtBoxMotherName = new PlaceholderTextBox();
            txtBoxFatherName = new PlaceholderTextBox();
            txtBoxStudentCont = new PlaceholderTextBox();
            txtBoxAddress = new PlaceholderTextBox();
            txtBoxFirst = new PlaceholderTextBox();
            dateBirth = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            cmbSuffix = new ComboBox();
            label19 = new Label();
            cmbGender = new ComboBox();
            txtBoxEmail = new PlaceholderTextBox();
            txtBoxFatherContact = new PlaceholderTextBox();
            txtBoxMotherContact = new PlaceholderTextBox();
            txtBoxRelationship = new PlaceholderTextBox();
            txtBoxLast = new PlaceholderTextBox();
            txtBoxMiddleName = new PlaceholderTextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(174, 617);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(540, 617);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(cmbSearch);
            flowLayoutPanel1.Controls.Add(btnSearch);
            flowLayoutPanel1.Location = new Point(22, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(974, 45);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImageLayout = ImageLayout.None;
            btnEdit.Location = new Point(150, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Location = new Point(297, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbSearch
            // 
            cmbSearch.AllowDrop = true;
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "coll", "fo", "hio ", "test" });
            cmbSearch.Location = new Point(444, 3);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(368, 28);
            cmbSearch.Sorted = true;
            cmbSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.Location = new Point(818, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(25, 94);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 8;
            label1.Text = "Full Name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(25, 137);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(25, 224);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 11;
            label3.Text = "Contact No.:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(25, 181);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "Address:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(25, 398);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 15;
            label5.Text = "Last School Attended:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(25, 355);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 14;
            label6.Text = "Guardian:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(25, 311);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 13;
            label7.Text = "Mother's Name:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(25, 268);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 12;
            label8.Text = "Father's Name:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(25, 525);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 18;
            label9.Text = "Student Type:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(25, 481);
            label10.Name = "label10";
            label10.Size = new Size(150, 20);
            label10.TabIndex = 17;
            label10.Text = "Grade Level to Enroll:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(25, 438);
            label11.Name = "label11";
            label11.Size = new Size(160, 20);
            label11.TabIndex = 16;
            label11.Text = "Last Grade Completed:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(167, 521);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 24);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "New";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(271, 521);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 24);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "Transferee";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(422, 521);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(55, 24);
            checkBox3.TabIndex = 21;
            checkBox3.Text = "Old";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // cmbEnroll
            // 
            cmbEnroll.FormattingEnabled = true;
            cmbEnroll.Location = new Point(174, 481);
            cmbEnroll.Name = "cmbEnroll";
            cmbEnroll.Size = new Size(421, 28);
            cmbEnroll.TabIndex = 22;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(668, 481);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(313, 28);
            cmbSection.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.Location = new Point(601, 484);
            label12.Name = "label12";
            label12.Size = new Size(61, 20);
            label12.TabIndex = 24;
            label12.Text = "Section:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxLastGrade
            // 
            txtBoxLastGrade.Location = new Point(191, 435);
            txtBoxLastGrade.Name = "txtBoxLastGrade";
            txtBoxLastGrade.Size = new Size(428, 27);
            txtBoxLastGrade.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(625, 438);
            label13.Name = "label13";
            label13.Size = new Size(45, 20);
            label13.TabIndex = 26;
            label13.Text = "GWA:";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxGwa
            // 
            txtBoxGwa.Location = new Point(676, 438);
            txtBoxGwa.Name = "txtBoxGwa";
            txtBoxGwa.Size = new Size(305, 27);
            txtBoxGwa.TabIndex = 27;
            // 
            // txtBoxLastSchool
            // 
            txtBoxLastSchool.Location = new Point(184, 395);
            txtBoxLastSchool.Name = "txtBoxLastSchool";
            txtBoxLastSchool.Size = new Size(797, 27);
            txtBoxLastSchool.TabIndex = 28;
            // 
            // txtBoxGuardian
            // 
            txtBoxGuardian.Location = new Point(103, 355);
            txtBoxGuardian.Name = "txtBoxGuardian";
            txtBoxGuardian.Size = new Size(492, 27);
            txtBoxGuardian.TabIndex = 30;
            // 
            // txtBoxMotherName
            // 
            txtBoxMotherName.Location = new Point(142, 308);
            txtBoxMotherName.Name = "txtBoxMotherName";
            txtBoxMotherName.Size = new Size(453, 27);
            txtBoxMotherName.TabIndex = 31;
            // 
            // txtBoxFatherName
            // 
            txtBoxFatherName.Location = new Point(136, 265);
            txtBoxFatherName.Name = "txtBoxFatherName";
            txtBoxFatherName.Size = new Size(459, 27);
            txtBoxFatherName.TabIndex = 32;
            // 
            // txtBoxStudentCont
            // 
            txtBoxStudentCont.Location = new Point(121, 221);
            txtBoxStudentCont.Name = "txtBoxStudentCont";
            txtBoxStudentCont.Size = new Size(474, 27);
            txtBoxStudentCont.TabIndex = 33;
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.Location = new Point(96, 178);
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(885, 27);
            txtBoxAddress.TabIndex = 34;
            // 
            // txtBoxFirst
            // 
            txtBoxFirst.Location = new Point(103, 94);
            txtBoxFirst.Name = "txtBoxFirst";
            txtBoxFirst.Size = new Size(319, 27);
            txtBoxFirst.TabIndex = 36;
            // 
            // dateBirth
            // 
            dateBirth.Location = new Point(120, 132);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(475, 27);
            dateBirth.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ImageAlign = ContentAlignment.MiddleLeft;
            label14.Location = new Point(625, 355);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 41;
            label14.Text = "Relationship:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ImageAlign = ContentAlignment.MiddleLeft;
            label15.Location = new Point(625, 311);
            label15.Name = "label15";
            label15.Size = new Size(63, 20);
            label15.TabIndex = 40;
            label15.Text = "Contact:";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ImageAlign = ContentAlignment.MiddleLeft;
            label16.Location = new Point(625, 268);
            label16.Name = "label16";
            label16.Size = new Size(63, 20);
            label16.TabIndex = 39;
            label16.Text = "Contact:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ImageAlign = ContentAlignment.MiddleLeft;
            label17.Location = new Point(625, 224);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 38;
            label17.Text = "Email:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ImageAlign = ContentAlignment.MiddleLeft;
            label18.Location = new Point(782, 94);
            label18.Name = "label18";
            label18.Size = new Size(49, 20);
            label18.TabIndex = 42;
            label18.Text = "Suffix:";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbSuffix
            // 
            cmbSuffix.FormattingEnabled = true;
            cmbSuffix.Location = new Point(834, 94);
            cmbSuffix.Name = "cmbSuffix";
            cmbSuffix.Size = new Size(147, 28);
            cmbSuffix.TabIndex = 43;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ImageAlign = ContentAlignment.MiddleLeft;
            label19.Location = new Point(628, 139);
            label19.Name = "label19";
            label19.Size = new Size(60, 20);
            label19.TabIndex = 44;
            label19.Text = "Gender:";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(694, 136);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(287, 28);
            cmbGender.TabIndex = 45;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(682, 221);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(299, 27);
            txtBoxEmail.TabIndex = 46;
            // 
            // txtBoxFatherContact
            // 
            txtBoxFatherContact.Location = new Point(694, 265);
            txtBoxFatherContact.Name = "txtBoxFatherContact";
            txtBoxFatherContact.Size = new Size(287, 27);
            txtBoxFatherContact.TabIndex = 47;
            // 
            // txtBoxMotherContact
            // 
            txtBoxMotherContact.Location = new Point(694, 308);
            txtBoxMotherContact.Name = "txtBoxMotherContact";
            txtBoxMotherContact.Size = new Size(287, 27);
            txtBoxMotherContact.TabIndex = 48;
            // 
            // txtBoxRelationship
            // 
            txtBoxRelationship.Location = new Point(718, 355);
            txtBoxRelationship.Name = "txtBoxRelationship";
            txtBoxRelationship.Size = new Size(263, 27);
            txtBoxRelationship.TabIndex = 49;
            // 
            // txtBoxLast
            // 
            txtBoxLast.Location = new Point(530, 94);
            txtBoxLast.Name = "txtBoxLast";
            txtBoxLast.Size = new Size(246, 27);
            txtBoxLast.TabIndex = 50;
            // 
            // txtBoxMiddleName
            // 
            txtBoxMiddleName.Location = new Point(428, 94);
            txtBoxMiddleName.Name = "txtBoxMiddleName";
            txtBoxMiddleName.Size = new Size(94, 27);
            txtBoxMiddleName.TabIndex = 51;
            // 
            // FormStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtBoxMiddleName);
            Controls.Add(txtBoxLast);
            Controls.Add(txtBoxRelationship);
            Controls.Add(txtBoxMotherContact);
            Controls.Add(txtBoxFatherContact);
            Controls.Add(txtBoxEmail);
            Controls.Add(cmbGender);
            Controls.Add(label19);
            Controls.Add(cmbSuffix);
            Controls.Add(label18);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(dateBirth);
            Controls.Add(txtBoxFirst);
            Controls.Add(txtBoxAddress);
            Controls.Add(txtBoxStudentCont);
            Controls.Add(txtBoxFatherName);
            Controls.Add(txtBoxMotherName);
            Controls.Add(txtBoxGuardian);
            Controls.Add(txtBoxLastSchool);
            Controls.Add(txtBoxGwa);
            Controls.Add(label13);
            Controls.Add(txtBoxLastGrade);
            Controls.Add(label12);
            Controls.Add(cmbSection);
            Controls.Add(cmbEnroll);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnPrint);
            Controls.Add(btnSave);
            Name = "FormStudentRegistration";
            Size = new Size(1011, 829);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Button btnPrint;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ComboBox cmbSearch;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbEnroll;
        private ComboBox cmbSection;
        private Label label12;
        private PlaceholderTextBox txtBoxLastGrade;
        private Label label13;
        private PlaceholderTextBox txtBoxGwa;
        private PlaceholderTextBox txtBoxLastSchool;
        private PlaceholderTextBox txtBoxGuardian;
        private PlaceholderTextBox txtBoxMotherName;
        private PlaceholderTextBox txtBoxFatherName;
        private PlaceholderTextBox txtBoxStudentCont;
        private PlaceholderTextBox txtBoxAddress;
        private PlaceholderTextBox txtBoxFirst;
        private DateTimePicker dateBirth;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private ComboBox cmbSuffix;
        private Label label19;
        private ComboBox cmbGender;
        private PlaceholderTextBox txtBoxEmail;
        private PlaceholderTextBox txtBoxFatherContact;
        private PlaceholderTextBox txtBoxMotherContact;
        private PlaceholderTextBox txtBoxRelationship;
        private PlaceholderTextBox txtBoxLast;
        private PlaceholderTextBox txtBoxMiddleName;
    }
}
