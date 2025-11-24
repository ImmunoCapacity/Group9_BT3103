    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using EventDriven.Project.Businesslogic.Controller;
    using EventDriven.Project.Logic.Controller;
    using EventDriven.Project.Model;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private List<StudentModel> studentsToPrint = new List<StudentModel>();
        private int currentPrintIndex = 0;
        private StudentModel student;
        private readonly AcademicYearController academicYearController;
        private List<AcademicYearModel> academicYearModels;
        private AcademicYearModel academicYearModel;


        public UserControlRegistration(string role, MainForm main, UserModel authenticationKey)
        {
            InitializeComponent();
            studentController = new StudentController();
            registrationController = new RegistrationController();
            this.authenticationKey = authenticationKey;

            this.main = main;
            if (role != "Admin")
            {
                //btnDeleteStudInfo.Visible = false;
                //pictureBox3.Visible = false;
            }
            academicYearController = new AcademicYearController();
            LoadYear();
            checkedListBox2.SelectionMode = SelectionMode.One;
            checkedListBox2.CheckOnClick = true;

            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            getStudentsInSection();


        }

        private async void LoadYear()
        {
            academicYearModels = await academicYearController.GetAllAsync(authenticationKey);
            foreach (var model in academicYearModels)
            {
                cbYear.Items.Add(model.YearName);
                cbYear.SelectedItem = model.YearName;
            }

        }
        private async Task<StudentModel> GetStudentFromForm()
        {
            string studentType = "";
            if (cbNew.Checked) studentType = "New";
            else if (cbOld.Checked) studentType = "Old";
            else if (cbTransferee.Checked) studentType = "Transferee";

            student.FirstName = txtFirstname.Text.Trim();
            student.MiddleName = txtMiddleName.Text.Trim();
            student.LastName = txtLastName.Text.Trim();
            student.Suffix = cmbSuffix.Text;
            student.BirthDate = dateTimePicker1.Value;
            student.Address = txtAddress.Text.Trim();
            student.Contact = txtContactNo.Text.Trim();
            student.Email = txtEmail.Text.Trim();
            student.GuardianName = txtGuardian.Text.Trim();
            student.GradeLevel = cmbGradeLevel.Text;
            student.Section = cmbSection.Text;
            student.Gender = cmbGender.Text;
            student.Status = studentType;
            student.AcademicYearId = await academicYearController.getYearId(cbYear.Text, academicYearModels, authenticationKey);



            return student;

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
            if (string.IsNullOrWhiteSpace(txtFirstname.Text)) MarkInvalid(txtFirstname); else MarkValid(txtFirstname);
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) MarkInvalid(txtLastName); else MarkValid(txtLastName);
            if (string.IsNullOrWhiteSpace(cmbGender.Text)) MarkInvalid(cmbGender); else MarkValid(cmbGender);
            if (string.IsNullOrWhiteSpace(cmbGradeLevel.Text)) MarkInvalid(cmbGradeLevel); else MarkValid(cmbGradeLevel);
            if (string.IsNullOrWhiteSpace(cmbSection.Text)) MarkInvalid(cmbSection); else MarkValid(cmbSection);

            // Newly added required fields
            if (string.IsNullOrWhiteSpace(txtAddress.Text)) MarkInvalid(txtAddress); else MarkValid(txtAddress);


            // Parent or guardian must have at least 1 name
            if (
                string.IsNullOrWhiteSpace(txtGuardian.Text))
            {
                MarkInvalid(txtGuardian);
            }
            else
            {
                MarkValid(txtGuardian);
            }

            // Numeric-only fields
            if (!long.TryParse(txtContactNo.Text, out _)) MarkInvalid(txtContactNo); else MarkValid(txtContactNo);

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

        private async void btnSave_Click(object sender, EventArgs e)
        {
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
            if (!ValidateStudentForm())
            {
                MessageBox.Show("Please correct the highlighted fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

                        var student = await GetStudentFromForm();
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
            getStudentsInSection();
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

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get a reference to the CheckedListBox
            CheckedListBox list = (CheckedListBox)sender;

            // If the checked item is not the one being clicked, uncheck it
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int index in list.CheckedIndices)
                {
                    if (index != e.Index)
                    {
                        list.SetItemChecked(index, false);
                    }
                }
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

                // Get student
                student = await studentController.GetByIdAsync(id, authenticationKey);
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
                foreach (var year in academicYearModels)
                {
                    if (year.Id == student.AcademicYearId)
                    {
                        cbYear.SelectedItem = year.YearName;
                    }
                }



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
            getStudentsInSection();
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

        public void selectEdit()
        {


        }
        public void selectAdd()
        {
            //highlightButton(btnAddStudInfo);
            action = "Add";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //highlightPicture(pictureBox1);
            action = "Add";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //highlightPicture(pictureBox3);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (selectedStudentId <= 0)
            {
                MessageBox.Show("Please search and select a student first.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDoc = new PrintDocument();

            // Set to A4 paper
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // width, height in hundredths of an inch
            printDoc.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50); // 0.5 inch margins

            printDoc.PrintPage += printDocument1_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 900,
                Height = 700
            };
            preview.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int rightMargin = e.MarginBounds.Right;
            int bottomMargin = e.MarginBounds.Bottom;
            int pageWidth = rightMargin - leftMargin;

            // Fonts
            Font headerFont = new Font("Segoe UI", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font bodyFont = new Font("Segoe UI", 11);
            Font footerFont = new Font("Segoe UI", 9, FontStyle.Italic);
            Brush blackBrush = Brushes.Black;
            Brush darkRedBrush = Brushes.DarkRed; // For school name
            Pen borderPen = new Pen(Color.Black, 1);

            int yPos = topMargin;

            // Draw outer border for the entire form
            Rectangle outerBorder = new Rectangle(leftMargin - 10, yPos - 10, pageWidth + 20, bottomMargin - yPos + 20);
            g.DrawRectangle(borderPen, outerBorder);

            // Header Section
            int headerHeight = 100;
            Rectangle headerBox = new Rectangle(leftMargin, yPos + 5, pageWidth, headerHeight + 10);
            g.DrawRectangle(borderPen, headerBox);

            int innerY = yPos + 10;

            // Draw logo (centered in header)
            try
            {
                Image logo = Properties.Resources.logo; // Ensure logo.png is in Resources
                if (logo != null)
                {
                    int logoWidth = 120;
                    int logoHeight = 50;
                    int logoX = leftMargin + (pageWidth - logoWidth) / 2;
                    g.DrawImage(logo, logoX, innerY, logoWidth, logoHeight);
                    innerY += logoHeight + 10;
                }
            }
            catch { }

            // School name (centered, darker red)
            string schoolName = "ROSEWOOD ACADEMY INC.";
            SizeF schoolSize = g.MeasureString(schoolName, headerFont);
            g.DrawString(schoolName, headerFont, darkRedBrush, leftMargin + (pageWidth - schoolSize.Width) / 2, innerY);
            innerY += (int)schoolSize.Height + 5;
            innerY += 15;

            // Form Title (centered)
            string title = "Registration Form";
            SizeF titleSize = g.MeasureString(title, subHeaderFont);
            g.DrawString(title, subHeaderFont, blackBrush, leftMargin + (pageWidth - titleSize.Width) / 2, innerY);

            yPos += headerHeight + 20;
            yPos += 50;

            // Student Information Section
            g.DrawString("Student Information", subHeaderFont, blackBrush, leftMargin, yPos);
            yPos += (int)g.MeasureString("Student Information", subHeaderFont).Height + 10;

            string[] studentInfo = {
        $"Name: {txtFirstname.Text} {txtMiddleName.Text} {txtLastName.Text}",
        $"Date of Birth: {dateTimePicker1.Value:yyyy-MM-dd}",
        $"Gender: {cmbGender.Text}",
        $"Suffix: {cmbSuffix.Text}",
        $"Address: {txtAddress.Text}",
        $"Contact No.: {txtContactNo.Text}",
        $"Email: {txtEmail.Text}",
        $"Guardian: {txtGuardian.Text}",
        $"Grade Level to Enroll: {cmbGradeLevel.Text}",
        $"Section: {cmbSection.Text}",
        $"Student Type: {status}"
    };

            int studentHeight = CalculateSectionHeight(g, studentInfo, bodyFont, 8);
            Rectangle studentBox = new Rectangle(leftMargin, yPos, pageWidth, studentHeight + 20);
            g.DrawRectangle(borderPen, studentBox);

            innerY = yPos + 10;
            foreach (string line in studentInfo)
            {
                g.DrawString(line, bodyFont, blackBrush, leftMargin + 10, innerY);
                innerY += (int)g.MeasureString(line, bodyFont).Height + 8;
            }
            yPos += studentHeight + 30;

            // Requirements and Payment Section
            g.DrawString("Additional Information", subHeaderFont, blackBrush, leftMargin, yPos);
            yPos += (int)g.MeasureString("Additional Information", subHeaderFont).Height + 10;

            string requirements = GetCheckedOptions().Requirements;
            string paymentMethod = GetCheckedOptions().PaymentMethod;
            string[] additionalInfo = {
        $"Requirements: {requirements}",
        $"Mode of Payment: {paymentMethod}"
    };

            int additionalHeight = CalculateSectionHeight(g, additionalInfo, bodyFont, 8);
            Rectangle additionalBox = new Rectangle(leftMargin, yPos, pageWidth, additionalHeight + 20);
            g.DrawRectangle(borderPen, additionalBox);

            innerY = yPos + 10;
            foreach (string line in additionalInfo)
            {
                g.DrawString(line, bodyFont, blackBrush, leftMargin + 10, innerY);
                innerY += (int)g.MeasureString(line, bodyFont).Height + 8;
            }
            yPos += additionalHeight + 40;

            // Signature Section
            int sigLineLength = 300;
            int sigSpacing = 50;

            yPos += 30;

            // Registrar Signature (left)
            g.DrawString("Registrar:", bodyFont, blackBrush, leftMargin, yPos);
            yPos += (int)g.MeasureString("Registrar:", bodyFont).Height + 30;
            g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + sigLineLength, yPos);
            yPos += 5;
            g.DrawString("Zarah Austria", bodyFont, blackBrush, leftMargin, yPos);
            yPos += (int)g.MeasureString("Zarah Austria", bodyFont).Height + sigSpacing + 20; // Added extra space below Registrar

            // Principal Signature (right)
            int principalX = rightMargin - sigLineLength;
            yPos -= (int)g.MeasureString("Principal:", bodyFont).Height + sigSpacing + 20; // Align with registrar, accounting for extra space
            g.DrawString("Principal:", bodyFont, blackBrush, principalX, yPos - 30);
            yPos += (int)g.MeasureString("Principal:", bodyFont).Height + 5;
            g.DrawLine(Pens.Black, principalX, yPos, principalX + sigLineLength, yPos);
            yPos += 5;
            g.DrawString("Hanz Llenard Kim Sacdalan", bodyFont, blackBrush, principalX, yPos);
            yPos += (int)g.MeasureString("Hanz Llenard Kim Sacdalan", bodyFont).Height + 20; // Added extra space below Principal

            // Footer with extra bottom margin
            string datePrinted = $"Printed on: {DateTime.Now:yyyy-MM-dd HH:mm}";
            SizeF footerSize = g.MeasureString(datePrinted, footerFont);
            g.DrawString(datePrinted, footerFont, blackBrush, leftMargin + (pageWidth - footerSize.Width) / 2, bottomMargin - footerSize.Height - 30); // Increased bottom margin

            e.HasMorePages = false;
        }

        // Helper method to calculate section height
        private int CalculateSectionHeight(Graphics g, string[] lines, Font font, int lineSpacing)
        {
            int totalHeight = 0;
            foreach (string line in lines)
            {
                totalHeight += (int)g.MeasureString(line, font).Height + lineSpacing;
            }
            return totalHeight;
        }

        private void cmbSection_SelectedValueChanged(object sender, EventArgs e)
        {
            getStudentsInSection();
        }

        private async void pictureBox4_Click(object sender, EventArgs e)
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
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; // Block input
        }
    }
}