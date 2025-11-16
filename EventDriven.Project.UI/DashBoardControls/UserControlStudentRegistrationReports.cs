using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlStudentRegistrationReports : UserControl
    {
        private readonly StudentController studentController;
        private UserControlRegistration studentRegistrationControl;
        private string role;
        private UserModel authenticationKey;
        private MainForm main;
        private List<StudentModel> allStudents = new List<StudentModel>(); // To hold all students for printing
        private List<StudentModel> studentsToPrint = new List<StudentModel>();
        private int currentPrintIndex = 0;
        private int currentPage = 1;

        // Updated constructor to include parameters for functionality, as per the source code
        public UserControlStudentRegistrationReports(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();
            studentController = new StudentController();
            LoadStudents();
        }

        // If keeping parameterless constructor, uncomment and adjust:
        // public UserControlStudentRegistrationReports()
        // {
        //     InitializeComponent();
        //     // Note: Without parameters, role, main, authenticationKey are not set, so functionality may be limited
        // }

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

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    studentRegistrationControl.ClearForm();
        //    tabControl1.SelectedIndex = 1;
        //}

        //private void edit(int studentId)
        //{
        //    studentRegistrationControl.selectedStudentId = studentId;
        //    tabControl1.SelectedIndex = 1;
        //    studentRegistrationControl.txtSearchStudentIn.Text = studentId.ToString();
        //    studentRegistrationControl.search();
        //}

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "ColEdit")
            {
                int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);
                //edit(studentId);
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

        private void UserControlStudentRegistrationReports_Load(object sender, EventArgs e)
        {
            UserControlRegistration info = new UserControlRegistration(role, main, authenticationKey);
            studentRegistrationControl = info;
            panel1.Controls.Clear();
            studentRegistrationControl.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panel1.Controls.Add(studentRegistrationControl);
            info.btnSave.Click += refresh;
        }

        //private void btnSearchStuIn_Click(object sender, EventArgs e)
        //{
        //    SearchStudent(txtSearch.Text.Trim());
        //}

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
                printDoc.PrintPage += printDocument1_PrintPage;
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
            string reportTitle = "Student Registration List";
            SizeF titleSize = e.Graphics.MeasureString(reportTitle, subHeaderFont);
            e.Graphics.DrawString(reportTitle, subHeaderFont, subHeaderBrush,(leftMargin + rightMargin - titleSize.Width) / 2, innerY);

            yPos += headerHeight + 75;

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
    }
}
