using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlRegistration : UserControl
    {
        private readonly StudentController studentController;
        private readonly UserModel authenticationKey;
        private readonly MainForm main;


        public int selectedStudentId = 0;
        private string status = "";
        private string action = "Add";

        public UserControlRegistration(string role, MainForm main, UserModel authenticationKey)
        {
            InitializeComponent();
            studentController = new StudentController();
            this.authenticationKey = authenticationKey;
            this.main = main;
        }

        private StudentModel GetStudentFromForm()
        {
            string studentType = "";
            if (cbNew.Checked) studentType = "New";
            else if (cbOld.Checked) studentType = "Old";
            else if (cbTransferee.Checked) studentType = "Transferee";

            return new StudentModel
            {
                FirstName = txtFirstname.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Suffix = cmbSuffix.Text,
                BirthDate = dateTimePicker1.Value,
                Address = txtAddress.Text.Trim(),
                Contact = txtContactNo.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                GuardianName = txtGuardian.Text.Trim(),
                GradeLevel = cmbGradeLevel.Text,
                Section = cmbSection.Text,
                Gender = cmbGender.Text,
                Status = studentType
            };
        }

        public void ClearForm()
        {
            txtFirstname.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            cmbSuffix.SelectedIndex = -1;
            cmbGradeLevel.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtGuardian.Clear();

            cbNew.Checked = false;
            cbOld.Checked = false;
            cbTransferee.Checked = false;

            selectedStudentId = 0;
            status = "";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                

                case "Edit":
                    try
                    {
                        if (selectedStudentId <= 0)
                        {
                            MessageBox.Show("Please search and select a student first.");
                            return;
                        }

                        var student = GetStudentFromForm();
                        student.Id = selectedStudentId;

                        var result = await studentController.UpdateAsync(student, authenticationKey);
                        MessageBox.Show(result != null ? "Student updated successfully!" : "Failed to update student.");
                        if (result != null) ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating student: {ex.Message}");
                    }
                    break;
            }
        }

        public async void Delete()
        {
            try
            {
                if (selectedStudentId <= 0)
                {
                    MessageBox.Show("Please search and select a student first.");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this student?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var result = await studentController.DeleteAsync(selectedStudentId, authenticationKey);
                    if (result != null)
                    {
                        MessageBox.Show("Student deleted successfully!");
                        ClearForm();
                    }
                    else MessageBox.Show("Failed to delete student.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
            }
        }

        public async void search()
        {
            try
            {
                if (!int.TryParse(txtSearchStudentIn.Text, out int id))
                {
                    MessageBox.Show("Invalid ID. Please enter a numeric value.");
                    return;
                }

                var student = await studentController.GetByIdAsync(id, authenticationKey);
                if (student == null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                selectedStudentId = student.Id;

                txtFirstname.Text = student.FirstName;
                txtMiddleName.Text = student.MiddleName;
                txtLastName.Text = student.LastName;
                cmbSuffix.Text = student.Suffix;
                dateTimePicker1.Value = student.BirthDate;
                cmbGradeLevel.Text = student.GradeLevel;
                cmbSection.Text = student.Section;
                cmbGender.Text = student.Gender;
                txtAddress.Text = student.Address;
                txtContactNo.Text = student.Contact;
                txtEmail.Text = student.Email;
                txtGuardian.Text = student.GuardianName;

                cbNew.Checked = student.Status == "New";
                cbOld.Checked = student.Status == "Old";
                cbTransferee.Checked = student.Status == "Transferee";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching student: {ex.Message}");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        #region Checkbox logic
        private void cbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNew.Checked)
            {
                cbOld.Checked = false;
                cbTransferee.Checked = false;
                status = "New";
            }
        }

        private void cbOld_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOld.Checked)
            {
                cbNew.Checked = false;
                cbTransferee.Checked = false;
                status = "Old";
            }
        }

        private void cbTransferee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTransferee.Checked)
            {
                cbNew.Checked = false;
                cbOld.Checked = false;
                status = "Transferee";
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "Add";
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            action = "Edit";
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

    }
}