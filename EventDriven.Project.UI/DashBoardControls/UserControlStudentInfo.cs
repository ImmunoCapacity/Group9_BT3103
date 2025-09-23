using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class UserControlStudentInfo : UserControl
    {
        private readonly StudentController studentController;
        private int selectedStudentId = 0;
        string status = "";
        MainForm main;
        public UserControlStudentInfo(string role, MainForm main)
        {
            InitializeComponent();
            studentController = new StudentController();

            btnAddStudInfo.Click += BtnAddStudInfo_Click;
            btnSearchStudInfo.Click += BtnSearchStudInfo_Click;
            btnEditStudInfo.Click += BtnEditStudInfo_Click;
            btnDeleteStudInfo.Click += BtnDeleteStudInfo_Click;
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
                Status = cbNew.Checked ? "New" :
                         cbTransferee.Checked ? "Transferee" : "Old",
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
            try
            {
                var student = GetStudentFromForm();
                var result = studentController.Add(student);
                MessageBox.Show(result != null ? "Student added successfully!" : "Failed to add student.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditStudInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudentId <= 0) { MessageBox.Show("Please search and select a student first."); return; }

                var student = GetStudentFromForm();
                student.Id = selectedStudentId;

                var result = studentController.Update(student);
                MessageBox.Show(result != null ? "Student updated successfully!" : "Failed to update student.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteStudInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudentId <= 0) { MessageBox.Show("Please search and select a student first."); return; }

                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var result = studentController.Delete(selectedStudentId);
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
            try
            {
                if (!int.TryParse(txtboxSearchStudInfo.Text, out int id)) { MessageBox.Show("Invalid ID."); return; }

                var student = studentController.GetById(id);
                if (student == null) { MessageBox.Show("Student not found."); return; }

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


        private void ClearForm()
        {
            txtFullname.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbGradeLevel.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtFatherName.Clear();
            txtEmail.Clear();
            txtMotherName.Clear();
            txtFatherContactNo.Clear();
            txtLastSchool.Clear();
            txtGuardian.Clear();
            txtRelationship.Clear();
            txtMotherContact.Clear();
            txtLastGrade.Clear();
            selectedStudentId = 0;
        }
        #region checked button
        private void cbNew_CheckedChanged(object sender, EventArgs e)
        {
            cbTransferee.Checked = false;
            cbOld.Checked = false;
            status = "New";
        }

        private void cbTransferee_CheckedChanged(object sender, EventArgs e)
        {
            cbNew.Checked = false;
            cbOld.Checked = false;
            status = "Transferee";
        }

        private void cbOld_CheckedChanged(object sender, EventArgs e)
        {
            cbTransferee.Checked = false;
            cbNew.Checked = false;
            status = "Old";
        }
        #endregion
    }
}
