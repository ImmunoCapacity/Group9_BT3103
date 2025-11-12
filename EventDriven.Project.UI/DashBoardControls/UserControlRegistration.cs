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
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlRegistration : UserControl
    {
        private readonly StudentController studentController;
        private readonly RegistrationController registrationController;
        private readonly UserModel authenticationKey;
        private readonly MainForm main;


        public int selectedStudentId = 0;
        private string status = "";
        private string action = "Edit";

        public UserControlRegistration(string role, MainForm main, UserModel authenticationKey)
        {
            InitializeComponent();
            studentController = new StudentController();
            registrationController = new RegistrationController();
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
                        //MessageBox.Show(result != null ? "Student updated successfully!" : "Failed to update student.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating student: {ex.Message}");
                    }
                    try
                    {
                        // Example usage
                        var (requirements, paymentMethod) = GetCheckedOptions();

                       

                        // You can now include these values in your RegistrationModel:
                        var registration = new RegistrationModel
                        {
                            StudentId = selectedStudentId,
                            Section = cmbSection.Text,
                            Requirements = requirements,
                            PaymentMethod = paymentMethod
                        };

                        // Call your controller (if you have one):
                         var result = await registrationController.UpsertAsync(registration, authenticationKey);
                        if (result != null) { MessageBox.Show($"Requirements: {requirements}\nPayment Method: {paymentMethod}"); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving registration: {ex.Message}");
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

        private void SetCheckedOptions(string requirements, string paymentMethod)
        {
            // Split the comma-separated strings into lists (handle "None" gracefully)
            var requirementItems = requirements != null && requirements != "None"
                ? requirements.Split(',').Select(r => r.Trim()).ToList()
                : new List<string>();

            var paymentItems = paymentMethod != null && paymentMethod != "None"
                ? paymentMethod.Split(',').Select(p => p.Trim()).ToList()
                : new List<string>();

            // Clear all current checks
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                checkedListBox2.SetItemChecked(i, false);

            // Re-check items that match the stored values
            foreach (var req in requirementItems)
            {
                int index = checkedListBox1.Items.IndexOf(req);
                if (index >= 0)
                    checkedListBox1.SetItemChecked(index, true);
            }

            foreach (var pay in paymentItems)
            {
                int index = checkedListBox2.Items.IndexOf(pay);
                if (index >= 0)
                    checkedListBox2.SetItemChecked(index, true);
            }
        }

        /// <summary>
        /// Gets the selected requirements and payment method from the checked list boxes.
        /// </summary>
        private (string Requirements, string PaymentMethod) GetCheckedOptions()
        {
            // Collect all checked items from the requirements list
            List<string> selectedRequirements = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedRequirements.Add(item.ToString());
            }

            // Collect all checked items from the payment method list
            List<string> selectedPaymentMethods = new List<string>();
            foreach (var item in checkedListBox2.CheckedItems)
            {
                selectedPaymentMethods.Add(item.ToString());
            }

            // Convert to comma-separated strings for saving or displaying
            string requirements = selectedRequirements.Count > 0 ? string.Join(", ", selectedRequirements) : "None";
            string paymentMethod = selectedPaymentMethods.Count > 0 ? string.Join(", ", selectedPaymentMethods) : "None";

            return (requirements, paymentMethod);
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

                // Get student
                var student = await studentController.GetByIdAsync(id, authenticationKey);
                if (student == null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                selectedStudentId = student.Id;

                // Fill student fields
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

                // --- NEW: Also get registration data ---
                var registration = await registrationController.GetByIdAsync(student.Id, authenticationKey);
                //MessageBox.Show("Requirements" + registration.Requirements + " Payment" + registration.PaymentMethod);
                if (registration != null)
                {
                    // Fill registration section dropdown (if not already)
                    cmbSection.Text = registration.Section;

                    // Use your earlier helper to restore checked items
                    SetCheckedOptions(registration.Requirements, registration.PaymentMethod);
                    
                }
                else
                {
                    // Clear if no registration record found
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        checkedListBox1.SetItemChecked(i, false);
                    for (int i = 0; i < checkedListBox2.Items.Count; i++)
                        checkedListBox2.SetItemChecked(i, false);
                }
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