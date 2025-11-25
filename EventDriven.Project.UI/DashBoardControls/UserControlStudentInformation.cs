using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;
 

namespace EventDriven.Project.UI
{
    public partial class UserControlStudentInformation : UserControl
    {
        private readonly StudentController studentController;
        public int selectedStudentId = 0;
        string status = "";
        string action = "Add";
        MainForm main;
        private List<StudentModel> studentsToPrint = new List<StudentModel>();
        private int currentPrintIndex = 0;
        private UserModel authenticationKey;
        private AcademicYearController academicYearController;
        private AcademicYearModel academicYearModel;

        public UserControlStudentInformation(string role, MainForm main, UserModel authenticationKey)
        {
            InitializeComponent();
            //highlightButton(BtnAddStudInfo);
            highlightPicture(pictureBox1);
            studentController = new StudentController();
            this.authenticationKey = authenticationKey;
            academicYearController = new AcademicYearController();
            txtSearchStudentIn.KeyDown += txtSearchStudentIn_KeyDown;


            this.main = main;
            if (role != "Admin")
            {
                //btnDeleteStudInfo.Visible = false;
                pictureBox3.Visible = false;
            }
            getStudentsInSection();
        }

        int studentsInSection = 0;

        private async void getStudentsInSection()
        {
            try
            {
                academicYearModel = await academicYearController.GetActiveYearAsync(authenticationKey);
                string sectionName = cmbSection.Text;


                if (string.IsNullOrWhiteSpace(sectionName))
                {
                    lbStuInSec.Text = "0";
                    return;
                }

                if (string.IsNullOrWhiteSpace(academicYearModel.YearName))
                {
                    lbStuInSec.Text = "0";
                    return;
                }

                // Call the controller
                studentsInSection = await studentController
                    .GetStudentCountBySectionAndYearAsync(sectionName, academicYearModel.YearName, authenticationKey);

                // Update UI
                lbStuInSec.Text = studentsInSection.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateStudentForm()
        {
            bool isValid = true;

            void MarkInvalid(Control ctrl)
            {
                ctrl.BackColor = Color.MistyRose;
                isValid = false;
            }

            void MarkValid(Control ctrl)
            {
                ctrl.BackColor = Color.White;
            }

            // Required text fields
            if (string.IsNullOrWhiteSpace(txtFullname.Text)) MarkInvalid(txtFullname); else MarkValid(txtFullname);
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) MarkInvalid(txtLastName); else MarkValid(txtLastName);
            if (string.IsNullOrWhiteSpace(cmbGender.Text)) MarkInvalid(cmbGender); else MarkValid(cmbGender);
            if (string.IsNullOrWhiteSpace(cmbGradeLevel.Text)) MarkInvalid(cmbGradeLevel); else MarkValid(cmbGradeLevel);
            if (string.IsNullOrWhiteSpace(cmbSection.Text)) MarkInvalid(cmbSection); else MarkValid(cmbSection);

            // Newly added required fields
            if (string.IsNullOrWhiteSpace(txtAddress.Text)) MarkInvalid(txtAddress); else MarkValid(txtAddress);
            if (string.IsNullOrWhiteSpace(txtRelationship.Text)) MarkInvalid(txtRelationship); else MarkValid(txtRelationship);
            if (string.IsNullOrWhiteSpace(txtLastGrade.Text)) MarkInvalid(txtLastGrade); else MarkValid(txtLastGrade);

            // GWA required + numeric check
            if (string.IsNullOrWhiteSpace(txtGWA.Text) ||
                !decimal.TryParse(txtGWA.Text, out _))
            {
                MarkInvalid(txtGWA);
            }
            else
            {
                MarkValid(txtGWA);
            }

            // Parent or guardian must have at least 1 name
            if (string.IsNullOrWhiteSpace(txtFatherName.Text) &&
                string.IsNullOrWhiteSpace(txtMotherName.Text) &&
                string.IsNullOrWhiteSpace(txtGuardian.Text))
            {
                MarkInvalid(txtFatherName);
                MarkInvalid(txtMotherName);
                MarkInvalid(txtGuardian);
            }
            else
            {
                MarkValid(txtFatherName);
                MarkValid(txtMotherName);
                MarkValid(txtGuardian);
            }

            // Numeric-only fields
            if (!long.TryParse(txtContactNo.Text, out _)) MarkInvalid(txtContactNo); else MarkValid(txtContactNo);
            if (!long.TryParse(txtFatherContactNo.Text, out _)) MarkInvalid(txtFatherContactNo); else MarkValid(txtFatherContactNo);
            if (!long.TryParse(txtMotherContact.Text, out _)) MarkInvalid(txtMotherContact); else MarkValid(txtMotherContact);

            // ✔ At least one (New, Old, Transferee) must be checked
            if (!cbNew.Checked && !cbTransferee.Checked && !cbOld.Checked)
            {
                // highlight label or all three checkboxes
                cbNew.BackColor = Color.MistyRose;
                cbTransferee.BackColor = Color.MistyRose;
                cbOld.BackColor = Color.MistyRose;
                isValid = false;
            }
            else
            {
                cbNew.BackColor = Color.Transparent;
                cbTransferee.BackColor = Color.Transparent;
                cbOld.BackColor = Color.Transparent;
            }

            return isValid;
        }


        private StudentModel GetStudentFromForm()
        {

            return new StudentModel
            {
                FirstName = txtFullname.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                Suffix = cmbSuffix.Text,
                Status = status,
                BirthDate = dateTimePicker1.Value,
                GradeLevel = cmbGradeLevel.Text,
                Section = cmbSection.Text,
                Gender = cmbGender.Text,
                //Nationality = txtNationality.Text,
                Email = txtEmail.Text,
                LastSchool = txtLastSchool.Text,
                LastGrade = txtLastGrade.Text,
                GWA = decimal.TryParse(txtGWA.Text, out decimal gwa) ? gwa : (decimal?)null,
                Address = txtAddress.Text,
                Contact = txtContactNo.Text,
                FatherName = txtFatherName.Text,
                FatherContact = txtFatherContactNo.Text,
                MotherName = txtMotherName.Text,
                MotherContact = txtMotherContact.Text,
                //ParentAddress = txtParentAddress.Text,
                GuardianName = txtGuardian.Text,
                GuardianRelationship = txtRelationship.Text
                //,GuardianContact = txtGuardianContact.Text,
                //GuardianAddress = txtGuardianAddress.Text
            };
        }


        private void BtnAddStudInfo_Click(object sender, EventArgs e)
        {
            selectAdd();
        }


        private void BtnEditStudInfo_Click(object sender, EventArgs e)
        {
            selectEdit();
        }

        private async void BtnDeleteStudInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudentId <= 0) { MessageBox.Show("Please search and select a student first."); return; }

                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var result = await studentController.DeleteAsync(selectedStudentId, authenticationKey);
                    if (result != null)
                    {
                        MessageBox.Show("Student deleted successfully!");
                        ClearForm();
                    }
                    else
                        MessageBox.Show("Failed to delete student.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearchStudInfo_Click(object sender, EventArgs e)
        {
            search();
        }
        public async void search()
        {
            try
            {
                if (!int.TryParse(txtSearchStudentIn.Text, out int id)) { MessageBox.Show("Invalid ID."); return; }

                var student = await studentController.GetByIdAsync(id, authenticationKey);
                if (student == null) { MessageBox.Show("Student not found."); return; }
                ClearForm();
                selectedStudentId = student.Id;

                txtFullname.Text = student.FirstName;
                txtMiddleName.Text = student.MiddleName;
                txtLastName.Text = student.LastName;
                cmbSuffix.Text = student.Suffix;
                dateTimePicker1.Value = student.BirthDate;
                cmbGradeLevel.Text = student.GradeLevel;
                cmbSection.Text = student.Section;
                cmbGender.Text = student.Gender;
                //txtNationality.Text = student.Nationality;
                txtEmail.Text = student.Email;
                txtLastSchool.Text = student.LastSchool;
                txtLastGrade.Text = student.LastGrade;
                txtGWA.Text = student.GWA.ToString();
                txtAddress.Text = student.Address;
                txtContactNo.Text = student.Contact;
                txtFatherName.Text = student.FatherName;
                txtFatherContactNo.Text = student.FatherContact;
                txtMotherName.Text = student.MotherName;
                txtMotherContact.Text = student.MotherContact;
                //txtParentAddress.Text = student.ParentAddress;
                txtGuardian.Text = student.GuardianName;
                txtRelationship.Text = student.GuardianRelationship;
                //txtGuardianContact.Text = student.GuardianContact;
                //txtGuardianAddress.Text = student.GuardianAddress;

                switch (student.Status)
                {
                    case "New":
                        cbNew.Checked = true; cbTransferee.Checked = false; cbOld.Checked = false;
                        break;
                    case "Transferee":
                        cbTransferee.Checked = true; cbNew.Checked = false; cbOld.Checked = false;
                        break;
                    case "Old":
                        cbOld.Checked = true; cbNew.Checked = false; cbTransferee.Checked = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getStudentsInSection();
        }

        //private void highlightButton(Button selected)
        //{
        //    foreach (Control ctrl in flowLayoutPanel1.Controls)
        //    {
        //        if (ctrl is Button btn)
        //        {load
        //            btn.BackColor = flowLayoutPanel1.BackColor;
        //            btn.ForeColor = Color.FromArgb(64, 64, 64);
        //            btn.FlatStyle = FlatStyle.Flat;
        //            btn.FlatAppearance.BorderColor = Color.Firebrick;
        //            btn.UseVisualStyleBackColor = false;
        //        }
        //    }

        //    if (selected != null)
        //    {
        //        selected.BackColor = Color.LightGray;
        //        selected.ForeColor = Color.Firebrick;
        //        selected.FlatStyle = FlatStyle.Flat;
        //        selected.FlatAppearance.BorderColor = Color.Firebrick;
        //        selected.UseVisualStyleBackColor = false;
        //    }
        //}

        private void highlightPicture(PictureBox selected)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PictureBox pb)
                {
                    pb.BackColor = flowLayoutPanel1.BackColor;
                }
            }
            if (selected != null)
            {
                selected.BackColor = Color.Gray;
            }
        }


        public void ClearForm()
        {
            // Basic info
            txtFullname.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            cmbSuffix.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cmbGradeLevel.Text = "";
            cmbSection.Text = "";
            cmbGender.Text = "";

            // Contact info
            txtEmail.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();

            // Academic info
            txtLastSchool.Clear();
            txtLastGrade.Clear();
            txtGWA.Clear();

            // Parents
            txtFatherName.Clear();
            txtFatherContactNo.Clear();
            txtMotherName.Clear();
            txtMotherContact.Clear();
            //txtParentAddress.Clear(); 

            // Guardian
            txtGuardian.Clear();
            txtRelationship.Clear();
            //txtGuardianContact.Clear();
            //txtGuardianAddress.Clear();

            // Status checkboxes
            cbNew.Checked = false;
            cbTransferee.Checked = false;
            cbOld.Checked = false;

            // Reset selected student
            selectedStudentId = 0;
        }

        #region checked button
        private void cbNew_CheckedChanged(object sender, EventArgs e)
        {
            cbTransferee.Checked = false;
            cbOld.Checked = false;
            status = "New";
            if (!cbNew.Checked) status = "";
        }

        private void cbTransferee_CheckedChanged(object sender, EventArgs e)
        {
            cbNew.Checked = false;
            cbOld.Checked = false;
            status = "Transferee";
            if (!cbTransferee.Checked) status = "";
        }

        private void cbOld_CheckedChanged(object sender, EventArgs e)
        {
            cbTransferee.Checked = false;
            cbNew.Checked = false;
            status = "Old";
            if (!cbOld.Checked) status = "";
        }
        #endregion

        private void UserControlStudentInfo_Load(object sender, EventArgs e)
        {
            // Gender
            string[] genders = { "Male", "Female" };
            cmbGender.Items.AddRange(genders);

            // Grade Levels


            // Suffixes
            string[] suffixes = { "", "Jr.", "II", "III", "IV", "V" };
            cmbSuffix.Items.AddRange(suffixes);

            // Sections


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public async void Save()
        {
            if (!ValidateStudentForm())
            {
                MessageBox.Show("Please correct the highlighted fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get count of students in selected grade + section
            int countInSection = int.Parse(lbStuInSec.Text);

            bool isSectionFull = countInSection >= 30;

            // If full, apply role-based logic
            if (isSectionFull)
            {
                if (authenticationKey.Role != "Admin")
                {
                    MessageBox.Show("This section already reached the limit of 30 students.\n\n" +
                                    "Only admins can add students beyond the limit.",
                                    "Section Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var overrideResult = MessageBox.Show(
                        $"This section already has {countInSection} students.\n\n" +
                        "Do you want to add this student anyway?",
                        "Override Section Limit",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (overrideResult == DialogResult.No)
                    {
                        return; // Cancel the entire save
                    }
                }
            }
            switch (action)
            {
                case "Add":
                    try
                    {
                        var student = GetStudentFromForm();
                        var result = studentController.AddAsync(student, authenticationKey);
                        MessageBox.Show(result != null ? "Student added successfully!" : "Failed to add student.");
                        this.ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Edit":
                    try
                    {
                        if (selectedStudentId <= 0) { MessageBox.Show("Please search and select a student first."); return; }

                        var student = GetStudentFromForm();
                        student.Id = selectedStudentId;

                        var result = studentController.UpdateAsync(student, authenticationKey);
                        MessageBox.Show(result != null ? "Student updated successfully!" : "Failed to update student.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public void selectEdit()
        {
            action = "Edit";
            highlightPicture(pictureBox3);

        }
        public void selectAdd()
        {
            //highlightButton(btnAddStudInfo);
            action = "Add";
        }
        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudentId <= 0)
                {
                    MessageBox.Show("Please search and select a student first.");
                    return;
                }

                var student = await studentController.GetByIdAsync(selectedStudentId, authenticationKey);
                if (student == null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                studentsToPrint = new List<StudentModel> { student }; // Print only the selected student
                currentPrintIndex = 0; // Reset page index
                currentPage = 1; // Reset page number

                PrintPreviewDialog preview = new PrintPreviewDialog();
                PrintDocument printDoc = new PrintDocument();
                printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Set to A4 size (210mm x 297mm)
                printDoc.PrintPage += PrintDocument1_PrintPage;
                preview.Document = printDoc;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private int currentPage = 1;  // Add this variable at the class level to track the page number.

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (studentsToPrint.Count == 0) return;

            StudentModel student = studentsToPrint[0]; // Printing only the selected student

            int yPos = e.MarginBounds.Top;
            int leftMargin = e.MarginBounds.Left;
            int rightMargin = e.MarginBounds.Right;
            int bottomMargin = e.MarginBounds.Bottom;
            int pageWidth = rightMargin - leftMargin;

            // Fonts
            Font headerFont = new Font("Segoe UI", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 14, FontStyle.Bold); // Slightly larger for sections
            Font bodyFont = new Font("Segoe UI", 10);
            Font footerFont = new Font("Segoe UI", 8);

            // Brushes
            Brush headerBrush = Brushes.DarkRed; // School name in darker red
            Brush subHeaderBrush = Brushes.Black;
            Brush bodyBrush = Brushes.Black;

            // Pen for borders
            Pen borderPen = new Pen(Color.Black, 1);

            // Draw outer border for the entire report card
            Rectangle outerBorder = new Rectangle(leftMargin - 10, yPos - 10, pageWidth + 20, bottomMargin - yPos + 20);
            e.Graphics.DrawRectangle(borderPen, outerBorder);

            // Header Section with border
            int headerHeight = 100;
            Rectangle headerBox = new Rectangle(leftMargin, yPos, pageWidth, headerHeight + 10);
            e.Graphics.DrawRectangle(borderPen, headerBox);

            int innerY = yPos + 10;

            // Draw Logo (centered in header)
            try
            {
                var logo = Properties.Resources.logo; // Ensure logo.png is in Resources
                if (logo != null)
                {
                    int logoWidth = 120;
                    int logoHeight = 50;
                    int logoX = leftMargin + (pageWidth - logoWidth) / 2;
                    e.Graphics.DrawImage(logo, logoX, innerY, logoWidth, logoHeight);
                    innerY += logoHeight + 10;
                }
            }
            catch { }

            // Draw School Name (centered, darker red)
            string schoolName = "ROSEWOOD ACADEMY INC.";
            SizeF schoolSize = e.Graphics.MeasureString(schoolName, headerFont);
            e.Graphics.DrawString(schoolName, headerFont, headerBrush, (leftMargin + rightMargin - schoolSize.Width) / 2, innerY);
            innerY += (int)schoolSize.Height + 5;

            // Report Title (centered)
            string reportTitle = "Student Information";
            SizeF titleSize = e.Graphics.MeasureString(reportTitle, subHeaderFont);
            e.Graphics.DrawString(reportTitle, subHeaderFont, subHeaderBrush, (leftMargin + rightMargin - titleSize.Width) / 2, innerY);

            yPos += headerHeight + 50;

            // Student Info Section
            e.Graphics.DrawString("Student Information", subHeaderFont, subHeaderBrush, leftMargin, yPos);
            yPos += (int)e.Graphics.MeasureString("Student Information", subHeaderFont).Height + 10;

            string[] studentInfoLines = {
        $"Student ID: {student.Id}",
        $"Name: {student.FirstName} {student.MiddleName} {student.LastName} {student.Suffix}",
        $"Status: {student.Status}",
        $"Birth Date: {student.BirthDate:yyyy-MM-dd} | Gender: {student.Gender}"
    };
            int studentInfoHeight = CalculateSectionHeight(e.Graphics, studentInfoLines, bodyFont, 8);
            Rectangle infoBox = new Rectangle(leftMargin, yPos, pageWidth, studentInfoHeight + 20);
            e.Graphics.DrawRectangle(borderPen, infoBox);

            innerY = yPos + 10;
            foreach (string line in studentInfoLines)
            {
                e.Graphics.DrawString(line, bodyFont, bodyBrush, leftMargin + 10, innerY);
                innerY += (int)e.Graphics.MeasureString(line, bodyFont).Height + 8;
            }
            yPos += studentInfoHeight + 30;

            // Academic Info Section
            e.Graphics.DrawString("Academic Information", subHeaderFont, subHeaderBrush, leftMargin, yPos);
            yPos += (int)e.Graphics.MeasureString("Academic Information", subHeaderFont).Height + 10;

            string[] academicLines = {
        $"Grade Level: {student.GradeLevel} | Section: {student.Section}",
        $"Last School: {student.LastSchool}",
        $"Last Grade: {student.LastGrade} | GWA: {student.GWA?.ToString("0.00") ?? "N/A"}"
    };
            int academicHeight = CalculateSectionHeight(e.Graphics, academicLines, bodyFont, 8);
            Rectangle academicBox = new Rectangle(leftMargin, yPos, pageWidth, academicHeight + 20);
            e.Graphics.DrawRectangle(borderPen, academicBox);

            innerY = yPos + 10;
            foreach (string line in academicLines)
            {
                e.Graphics.DrawString(line, bodyFont, bodyBrush, leftMargin + 10, innerY);
                innerY += (int)e.Graphics.MeasureString(line, bodyFont).Height + 8;
            }
            yPos += academicHeight + 30;

            // Contact Info Section
            e.Graphics.DrawString("Contact Information", subHeaderFont, subHeaderBrush, leftMargin, yPos);
            yPos += (int)e.Graphics.MeasureString("Contact Information", subHeaderFont).Height + 10;

            string[] contactLines = {
        $"Email: {student.Email}",
        $"Address: {student.Address}",
        $"Contact: {student.Contact}"
    };
            int contactHeight = CalculateSectionHeight(e.Graphics, contactLines, bodyFont, 8);
            Rectangle contactBox = new Rectangle(leftMargin, yPos, pageWidth, contactHeight + 20);
            e.Graphics.DrawRectangle(borderPen, contactBox);

            innerY = yPos + 10;
            foreach (string line in contactLines)
            {
                e.Graphics.DrawString(line, bodyFont, bodyBrush, leftMargin + 10, innerY);
                innerY += (int)e.Graphics.MeasureString(line, bodyFont).Height + 8;
            }
            yPos += contactHeight + 30;

            // Parents & Guardian Section
            e.Graphics.DrawString("Parents and Guardian", subHeaderFont, subHeaderBrush, leftMargin, yPos);
            yPos += (int)e.Graphics.MeasureString("Parents and Guardian", subHeaderFont).Height + 10;

            string[] guardianLines = {
        $"Father: {student.FatherName} | Contact: {student.FatherContact}",
        $"Mother: {student.MotherName} | Contact: {student.MotherContact}",
        $"Guardian: {student.GuardianName} | Relationship: {student.GuardianRelationship}"
    };
            int guardianHeight = CalculateSectionHeight(e.Graphics, guardianLines, bodyFont, 8);
            Rectangle guardianBox = new Rectangle(leftMargin, yPos, pageWidth, guardianHeight + 20);
            e.Graphics.DrawRectangle(borderPen, guardianBox);

            innerY = yPos + 10;
            foreach (string line in guardianLines)
            {
                e.Graphics.DrawString(line, bodyFont, bodyBrush, leftMargin + 10, innerY);
                innerY += (int)e.Graphics.MeasureString(line, bodyFont).Height + 8;
            }
            yPos += guardianHeight + 40; // Extra space before footer

            // Signature Section
            int sigLineLength = 200;
            int sigSpacing = 40;
            // Student Signature (left)
            e.Graphics.DrawString("Student:", bodyFont, bodyBrush, leftMargin, yPos - 10);
            yPos += (int)e.Graphics.MeasureString("Student:", bodyFont).Height + 5;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + sigLineLength, yPos);
            yPos += 5;
            e.Graphics.DrawString($"{student.FirstName} {student.LastName}", bodyFont, bodyBrush, leftMargin, yPos);
            yPos += (int)e.Graphics.MeasureString($"{student.FirstName} {student.LastName}", bodyFont).Height + sigSpacing;
            // Parent/Guardian Signature (center)
            int parentX = leftMargin + (pageWidth - sigLineLength) / 2;
            yPos -= (int)e.Graphics.MeasureString("Parent/Guardian:", bodyFont).Height + 5 + sigSpacing; // Align with student
            e.Graphics.DrawString("Parent/Guardian:", bodyFont, bodyBrush, parentX, yPos - 10);
            yPos += (int)e.Graphics.MeasureString("Parent/Guardian:", bodyFont).Height + 5;
            e.Graphics.DrawLine(Pens.Black, parentX, yPos, parentX + sigLineLength, yPos);
            yPos += 5;
            e.Graphics.DrawString($"{student.GuardianName}", bodyFont, bodyBrush, parentX, yPos);
            yPos += (int)e.Graphics.MeasureString($"{student.GuardianName}", bodyFont).Height + sigSpacing;
            // Principal Signature (right)
            int principalX = rightMargin - sigLineLength;
            yPos -= (int)e.Graphics.MeasureString("Principal:", bodyFont).Height + 5 + sigSpacing; // Align with others
            e.Graphics.DrawString("Principal:", bodyFont, bodyBrush, principalX, yPos - 10);
            yPos += (int)e.Graphics.MeasureString("Principal:", bodyFont).Height + 5;
            e.Graphics.DrawLine(Pens.Black, principalX, yPos, principalX + sigLineLength, yPos);
            yPos += 5;
            e.Graphics.DrawString("Hanz Llenard Sacdalan", bodyFont, bodyBrush, principalX, yPos);
            yPos += (int)e.Graphics.MeasureString("Hanz Llenard Sacdalan", bodyFont).Height + 20;

            // Footer with extra bottom margin
            string dateLine = $"Report Generated on: {DateTime.Now:yyyy-MM-dd}";
            SizeF dateSize = e.Graphics.MeasureString(dateLine, footerFont);
            e.Graphics.DrawString(dateLine, footerFont, bodyBrush, leftMargin, bottomMargin - dateSize.Height - 30); // Increased bottom margin

            string pageNumber = $"Page {currentPage}";
            SizeF pageSize = e.Graphics.MeasureString(pageNumber, footerFont);
            e.Graphics.DrawString(pageNumber, footerFont, bodyBrush, rightMargin - pageSize.Width, bottomMargin - pageSize.Height - 30);

            currentPage++;
            e.HasMorePages = false;
        }

        // Helper method
        private int CalculateSectionHeight(Graphics g, string[] lines, Font font, int lineSpacing)
        {
            int totalHeight = 0;
            foreach (string line in lines)
            {
                totalHeight += (int)g.MeasureString(line, font).Height + lineSpacing;
            }
            return totalHeight;
        }





        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            highlightPicture(pictureBox1);
            action = "Add";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            highlightPicture(pictureBox3);
            action = "Edit";
        }



        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSection_SelectedValueChanged(object sender, EventArgs e)
        {
            getStudentsInSection();
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; // Block input
        }

        private void txtSearchStudentIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the search when Enter is pressed
                search();
                // Optional: Prevent the beep sound on Enter
                e.SuppressKeyPress = true;
            }
        }
    }
}
