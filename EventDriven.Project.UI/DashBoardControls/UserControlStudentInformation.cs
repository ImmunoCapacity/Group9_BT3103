using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using System.Drawing.Printing;
 

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

        

        public UserControlStudentInformation(string role, MainForm main)
        {
            InitializeComponent();
            highlightButton(btnAddStudInfo);
            studentController = new StudentController();

            this.main = main;
            if (role != "Admin")
            {
                btnDeleteStudInfo.Visible = false;
            }
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
                    var result = await studentController.DeleteAsync(selectedStudentId);
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

                var student = await studentController.GetByIdAsync(id);
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
        }

        private void highlightButton(Button selected)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = flowLayoutPanel1.BackColor;
                    btn.ForeColor = Color.FromArgb(64, 64, 64);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Firebrick;
                    btn.UseVisualStyleBackColor = false;
                }
            }

            if (selected != null)
            {
                selected.BackColor = Color.LightGray;
                selected.ForeColor = Color.Firebrick;
                selected.FlatStyle = FlatStyle.Flat;
                selected.FlatAppearance.BorderColor = Color.Firebrick;
                selected.UseVisualStyleBackColor = false;
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
            if(!cbOld.Checked) status = "";
        }
        #endregion

        private void UserControlStudentInfo_Load(object sender, EventArgs e)
        {
            // Gender
            string[] genders = { "Male", "Female" };
            cmbGender.Items.AddRange(genders);

            // Grade Levels
            string[] gradeLevels = { "Grade 7", "Grade 8", "Grade 9", "Grade 10" };
            cmbGradeLevel.Items.AddRange(gradeLevels);

            // Suffixes
            string[] suffixes = { "", "Jr.", "II", "III", "IV", "V" };
            cmbSuffix.Items.AddRange(suffixes);

            // Sections
            string[] sections = {
            "Section Aster","Section Azalea","Section Camellia","Section Chrysanthemum","Section Dahlia","Section Hyacinth", };
            cmbSection.Items.AddRange(sections);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Add":
                    try
                    {
                        var student = GetStudentFromForm();
                        var result = studentController.AddAsync(student);
                        MessageBox.Show(result != null ? "Student added successfully!" : "Failed to add student.");
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

                        var result = studentController.UpdateAsync(student);
                        MessageBox.Show(result != null ? "Student updated successfully!" : "Failed to update student.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
        public void selectEdit() {

            highlightButton(btnEditStudInfo);
            action = "Edit";
        }
        public void selectAdd()
        {
            highlightButton(btnAddStudInfo);
            action = "Add";
        }
        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                studentsToPrint = await studentController.GetAllAsync(); // Get all students
                if (studentsToPrint.Count == 0)
                {
                    MessageBox.Show("No students to print.");
                    return;
                }

                currentPrintIndex = 0; // Reset page index

                PrintPreviewDialog preview = new PrintPreviewDialog();
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintDocument1_PrintPage;
                preview.Document = printDoc;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int yPos = e.MarginBounds.Top;
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font itemFont = new Font("Arial", 10);

            // Header
            string header = "ID | Firstname | Lastname | Grade | Section | Gender | GWA";
            e.Graphics.DrawString(header, headerFont, Brushes.Black, e.MarginBounds.Left, yPos);
            yPos += headerFont.Height + 5;

            // Print students
            while (currentPrintIndex < studentsToPrint.Count)
            {
                StudentModel s = studentsToPrint[currentPrintIndex];

                string line = $"{s.Id,-3} | {s.FirstName,-10} | {s.LastName,-10} | {s.GradeLevel,-6} | {s.Section,-12} | {s.Gender,-6} | {s.GWA?.ToString("0.00") ?? "-"}";
                e.Graphics.DrawString(line, itemFont, Brushes.Black, e.MarginBounds.Left, yPos);
                yPos += itemFont.Height + 5;

                // Check if we need a new page
                if (yPos + itemFont.Height > e.MarginBounds.Bottom)
                {
                    currentPrintIndex++; // next student on next page
                    e.HasMorePages = true;
                    return;
                }

                currentPrintIndex++;
            }

            // Finished printing
            e.HasMorePages = false;
            currentPrintIndex = 0;
        }



    }
}
