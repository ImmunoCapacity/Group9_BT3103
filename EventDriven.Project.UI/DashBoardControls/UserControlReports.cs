using System.Drawing.Printing;
using System.Text.RegularExpressions;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlReports : UserControl
    {
        private readonly StudentController studentController;
        private UserControlStudentInformation studentInformationControl;
        private string role;
        private UserModel authenticationKey;
        private MainForm main;
        private List<StudentModel> allStudents = new List<StudentModel>(); // To hold all students for printing
        private List<StudentModel> studentsToPrint = new List<StudentModel>();
        private int currentPrintIndex = 0;
        private int currentPage = 1; // Added missing variable
        private int selectedStudentId = 0; // Added missing variable for selected student

        public UserControlReports(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();

            RemoveTabsForRole();

            studentController = new StudentController();


            LoadStudents();
        }
        UserControlStudentRegistrationReports reports;
        UserControlAssessmentReports reports2;
        UserControlPaymentReports reports3;

        private async Task LoadComboBoxData()
        {


            AssessmentController2 assessmentController2 = new AssessmentController2();
            var list = await assessmentController2.GetSectionGradeYear(authenticationKey);

            cmbSection.Items.Clear();
            cmbGrade.Items.Clear();
            cmbYearLevel.Items.Clear();

            // Track added items to avoid duplicates
            var addedSections = new HashSet<string>();
            var addedGrades = new HashSet<string>();
            var addedYears = new HashSet<string>();

            foreach (var item in list)
            {
                if (!string.IsNullOrEmpty(item.StudentSection) && !addedSections.Contains(item.StudentSection))
                {
                    cmbSection.Items.Add(item.StudentSection);
                    addedSections.Add(item.StudentSection);
                }

                if (!string.IsNullOrEmpty(item.GradeLevel) && !addedGrades.Contains(item.GradeLevel))
                {
                    cmbGrade.Items.Add(item.GradeLevel);
                    addedGrades.Add(item.GradeLevel);
                }

                if (!string.IsNullOrEmpty(item.year) && !addedYears.Contains(item.year))
                {
                    cmbYearLevel.Items.Add(item.year);
                    addedYears.Add(item.year);
                }


            }

        }


        private void SortBy(DataGridView view)
        {
            string section = cmbSection.Text?.Trim();  // Trim to handle extra spaces
            string grade = cmbGrade.Text?.Trim();
            string year = cmbYearLevel.Text?.Trim();
            foreach (DataGridViewRow row in view.Rows)
            {
                if (row.IsNewRow) continue;  // Skip the "new row" placeholder
                bool isVisible = true;
                // Check section filter
                if (!string.IsNullOrEmpty(section) &&
                    row.Cells["Section"].Value?.ToString() != section)
                {
                    isVisible = false;
                }
                // Check grade filter
                if (!string.IsNullOrEmpty(grade) &&
                    row.Cells["Grade"].Value?.ToString() != grade)
                {
                    isVisible = false;
                }
                // Check year filter
                if (!string.IsNullOrEmpty(year) &&
                    row.Cells["YearLevel"].Value?.ToString() != year)
                {
                    isVisible = false;
                }
                row.Visible = isVisible;
            }
        }


        private async void LoadStudents()
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<StudentModel> students = await studentController.GetAllAsync(authenticationKey);
                allStudents = students; // Store for printing

                foreach (var student in students)
                {
                    dataGridView1.Rows.Add(
                        student.Id,
                        $"{student.FirstName} {student.MiddleName} {student.LastName}",
                        student.Contact,
                        student.GradeLevel,
                        student.BirthDate.ToString("yyyy-MM-dd")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            studentInformationControl.selectAdd();
            studentInformationControl.ClearForm();
            tabControl1.SelectedIndex = 1;
        }

        private void edit(int studentId)
        {
            studentInformationControl.selectEdit();
            studentInformationControl.selectedStudentId = studentId;
            tabControl1.SelectedIndex = 1;
            studentInformationControl.txtSearchStudentIn.Text = studentId.ToString();
            studentInformationControl.search();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "ColEdit")
            {
                int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);
                edit(studentId);
                // MessageBox.Show($"Edit student with ID: {studentId}");
                // TODO: open Student Registration tab and load details
            }
            else if (columnName == "ColDelete")
            {
                if (role != "Admin")
                {
                    MessageBox.Show("Only Admin can delete student records.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);

                var confirm = MessageBox.Show("Delete this student?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    await studentController.DeleteAsync(studentId, authenticationKey);
                    LoadStudents(); // refresh grid
                }
            }
        }

        private void UserControlReports_Load(object sender, EventArgs e)
        {
            UserControlStudentInformation info = new UserControlStudentInformation(role, main, authenticationKey);
            studentInformationControl = info;
            panel1.Controls.Clear();
            studentInformationControl.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panel1.Controls.Add(studentInformationControl);
            info.btnSave.Click += refresh;
        }

        private void SearchStudent(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                // Show all rows if search is empty
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.Visible = true;
                return;
            }

            bool isNumber = Regex.IsMatch(searchValue, @"^\d+$"); // only digits

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool match = false;

                if (isNumber)
                {
                    // search by ID (exact match)
                    match = row.Cells["Column1"].Value.ToString().Contains(searchValue);
                    row.Visible = match;
                }
                else
                {
                    // search by Name (partial match)
                    match = row.Cells["Column2"].Value.ToString()
                                .ToLower()
                                .Contains(searchValue.ToLower());
                }

                row.Visible = match;
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Modified to print all students as per user request ("print all of the student information in a list")
                if (allStudents.Count == 0)
                {
                    MessageBox.Show("No students to print.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                studentsToPrint = allStudents; // Print all students
                currentPrintIndex = 0; // Reset page index
                currentPage = 1; // Reset page number

                PrintPreviewDialog preview = new PrintPreviewDialog();
                PrintDocument printDoc = new PrintDocument();
                printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Set to A4 size (210mm x 297mm)
                printDoc.PrintPage += printDocument1_PrintPage; // Fixed case mismatch: was PrintDocument1_PrintPage, now matches method name
                preview.Document = printDoc;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (studentsToPrint.Count == 0) return;

            int yPos = e.MarginBounds.Top;
            int leftMargin = e.MarginBounds.Left;
            int rightMargin = e.MarginBounds.Right;
            int bottomMargin = e.MarginBounds.Bottom;
            int pageWidth = rightMargin - leftMargin;

            // Fonts
            Font headerFont = new Font("Segoe UI", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font bodyFont = new Font("Segoe UI", 10);
            Font tableHeaderFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font footerFont = new Font("Segoe UI", 8);

            // Brushes
            Brush headerBrush = Brushes.DarkRed;
            Brush subHeaderBrush = Brushes.Black;
            Brush bodyBrush = Brushes.Black;
            Brush tableBrush = Brushes.Black;

            // Pen for borders
            Pen borderPen = new Pen(Color.Black, 1);

            // Draw outer border for the entire report
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
            string reportTitle = "Student Information List";
            SizeF titleSize = e.Graphics.MeasureString(reportTitle, subHeaderFont);
            e.Graphics.DrawString(reportTitle, subHeaderFont, subHeaderBrush, (leftMargin + rightMargin - titleSize.Width) / 2, innerY);

            yPos += headerHeight + 40;

            // Table Header
            e.Graphics.DrawString("Student Information List", subHeaderFont, subHeaderBrush, leftMargin, yPos);
            yPos += (int)e.Graphics.MeasureString("Student Information List", subHeaderFont).Height + 10;

            // Define column widths
            int col1Width = 80; // ID
            int col2Width = 200; // Name
            int col3Width = 120; // Contact
            int col4Width = 100; // Grade Level
            int col5Width = 100; // Birth Date
            int rowHeight = 25;

            // Draw table header
            Rectangle tableHeaderBox = new Rectangle(leftMargin, yPos, pageWidth, rowHeight);
            e.Graphics.DrawRectangle(borderPen, tableHeaderBox);

            int xPos = leftMargin;
            e.Graphics.DrawString("ID", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col1Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Name", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col2Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Contact", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col3Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Grade Level", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col4Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Birth Date", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);

            yPos += rowHeight;

            // Draw table rows
            for (int i = currentPrintIndex; i < studentsToPrint.Count; i++)
            {
                var student = studentsToPrint[i];
                if (yPos + rowHeight > bottomMargin - 50) // Check if new page needed
                {
                    e.HasMorePages = true;
                    currentPrintIndex = i; // Save current index for next page
                    return;
                }

                Rectangle rowBox = new Rectangle(leftMargin, yPos, pageWidth, rowHeight);
                e.Graphics.DrawRectangle(borderPen, rowBox);

                xPos = leftMargin;
                e.Graphics.DrawString(student.Id.ToString(), bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col1Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                string fullName = $"{student.FirstName} {student.MiddleName} {student.LastName}";
                e.Graphics.DrawString(fullName, bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col2Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(student.Contact, bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col3Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(student.GradeLevel, bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col4Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(student.BirthDate.ToString("yyyy-MM-dd"), bodyFont, bodyBrush, xPos + 5, yPos + 5);

                yPos += rowHeight;
                currentPrintIndex = i + 1; // Update index
            }

            // Footer
            yPos += 20;
            string dateLine = $"Report Generated on: {DateTime.Now:yyyy-MM-dd}";
            SizeF dateSize = e.Graphics.MeasureString(dateLine, footerFont);
            e.Graphics.DrawString(dateLine, footerFont, bodyBrush, leftMargin, bottomMargin - dateSize.Height - 10);

            string pageNumber = $"Page {currentPage}";
            SizeF pageSize = e.Graphics.MeasureString(pageNumber, footerFont);
            e.Graphics.DrawString(pageNumber, footerFont, bodyBrush, rightMargin - pageSize.Width, bottomMargin - pageSize.Height - 10);

            currentPage++; // Increment for next page
            e.HasMorePages = false;
        }


        private async void UserControlReports_Load_1(object sender, EventArgs e)
        {
            reports = new UserControlStudentRegistrationReports(role, main, authenticationKey);
            reports.Dock = DockStyle.Fill;   // Makes the UserControl scale to fill the panel
            panel2.Controls.Clear();         // Clear any existing controls in panel1
            panel2.Controls.Add(reports);    // Add the reports control to panel1

            reports2 = new UserControlAssessmentReports(role, main, authenticationKey);
            reports2.Dock = DockStyle.Fill;
            panel3.Controls.Add(reports2);
            panel3.Controls.Add(reports2);

            reports3 = new UserControlPaymentReports(role, main, authenticationKey);
            reports3.Dock = DockStyle.Fill;
            panel4.Controls.Add(reports3);
            panel4.Controls.Add(reports3);
            await LoadComboBoxData();
        }

        private void RemoveTabsForRole()
        {
            if (tabControl1 == null) return;

            if (role == "Cashier")
            {
                // Remove tabs for Cashier
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
            }
            else if (role == "Registrar")
            {
                // Remove tabs for Registrar
                tabControl1.TabPages.Remove(tabPage4);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Update the label with the selected section
            //string selectedSection = cmbSection.Text?.Trim();
            //lblSelectedSection.Text = string.IsNullOrEmpty(selectedSection) ? "Section: None" : $"Section: {selectedSection}";
            //SortBy(dataGridView1);
        }
        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Update the label with the selected grade
            //string selectedGrade = cmbGrade.Text?.Trim();
            //lblSelectedGrade.Text = string.IsNullOrEmpty(selectedGrade) ? "Grade: None" : $"Grade: {selectedGrade}";
            //SortBy(dataGridView1);
        }
        private void cmbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Update the label with the selected year
            //string selectedYear = cmbYearLevel.Text?.Trim();
            //lblSelectedYear.Text = string.IsNullOrEmpty(selectedYear) ? "Year: None" : $"Year: {selectedYear}";
            //SortBy(dataGridView1);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
