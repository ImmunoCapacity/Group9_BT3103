using System;
using System.Buffers;
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
using System.Xml.Linq;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlPaymentReports : UserControl
    {
        private readonly PaymentController paymentController;
        private UserControlStudentInformation studentRegistrationControl;
        private string role;
        private UserModel authenticationKey;
        private MainForm main;
        private PaymentModel selectedPayment; // Set this before printing
        private int currentPage = 1;

        // Fields to hold data for printing
        private List<StudentPaymentInfo> allPayments = new List<StudentPaymentInfo>(); // To hold all payments for printing
        private List<StudentPaymentInfo> paymentsToPrint = new List<StudentPaymentInfo>();
        private int currentPrintIndex = 0;

        // Updated constructor to include parameters for functionality, as per the source code
        public UserControlPaymentReports(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();
            paymentController = new PaymentController();
            LoadStudents();
        }

        // If keeping parameterless constructor, uncomment and adjust:
        // public UserControlPaymentReports()
        // {
        //     InitializeComponent();
        //     // Note: Without parameters, role, main, authenticationKey are not set, so functionality may be limited
        // }

        private async void LoadStudents()
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<StudentPaymentInfo> payments = await paymentController.GetAllStudentPayment(authenticationKey);
                allPayments = payments; // Store for printing

                foreach (var payment in payments)
                {
                    dataGridView1.Rows.Add(
                        payment.StudentId,
                        payment.StudentName,
                        payment.GradeLevel,
                        payment.TuitionFee,
                        payment.TotalPaid,
                        payment.RemainingBalance
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private async void btnPay_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // 1️⃣ Ensure a student is selected
        //        if (dataGridView1.CurrentRow == null)
        //        {
        //            MessageBox.Show("Please select a student first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // 2️⃣ Validate and get Student ID
        //        if (!int.TryParse(lbId.Text, out int studentId))
        //        {
        //            MessageBox.Show("Invalid student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // 3️⃣ Validate payment input
        //        if (!decimal.TryParse(txtPaymentReceived.Text, out decimal paymentAmount))
        //        {
        //            MessageBox.Show("Please enter a valid numeric payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // 🚫 Prevent zero or negative payments
        //        if (paymentAmount <= 0)
        //        {
        //            MessageBox.Show("Invalid Payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // 4️⃣ Validate balance
        //        if (!decimal.TryParse(lbBalance.Text, out decimal currentBalance))
        //        {
        //            MessageBox.Show("Invalid balance amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        decimal change = 0;

        //        // ⚖️ Handle overpayment
        //        if (paymentAmount > currentBalance)
        //        {
        //            change = paymentAmount - currentBalance;
        //            paymentAmount = currentBalance; // record only up to the remaining balance
        //        }

        //        // 5️⃣ Determine payment type
        //        string paymentType = rbFullPayment.Checked ? "Full" : "Partial";

        //        // 6️⃣ Build model
        //        PaymentModel payment = new PaymentModel
        //        {
        //            StudentId = studentId,
        //            AmountPaid = paymentAmount,
        //            DatePaid = DateTime.Now,
        //            PaymentType = paymentType
        //        };

        //        // 7️⃣ Send to controller
        //        var addedPayment = await paymentController.AddAsync(payment, authenticationKey);

        //        // ✅ Success message
        //        string msg = $"Payment of {paymentAmount:C} added successfully!";
        //        if (change > 0)
        //            msg += $"\nChange to return: {change:C}";

        //        MessageBox.Show(msg, "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // 8️⃣ Refresh data grid & UI
        //        LoadStudents(); // reload student list
        //        UpdatePayment(change, paymentAmount, currentBalance);

        //        //// 9️⃣ Reset input
        //        //txtPaymentReceived.Text = "0.00";
        //        rbFullPayment.Checked = rbFullPayment.Checked;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void UpdatePayment(decimal change, decimal paymentAmount, decimal currentBalance)
        //{
        //    currentBalance = currentBalance - paymentAmount;
        //    // Update the UI labels
        //    lbBalance.Text = currentBalance.ToString("F2");
        //    lbChange.Text = change.ToString("F2");

        //    //// Reset the payment textbox
        //    //txtPaymentReceived.Text = "0.00";
        //}

        //private void btnSearchStuIn_Click(object sender, EventArgs e)
        //{
        //    SearchStudent(txtSearch.Text);
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

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Make sure user clicked a valid row (not header or empty space)
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        //        // Example: assuming these are the column names or indexes
        //        lbName.Text = row.Cells["Column2"].Value?.ToString() ?? "";
        //        lbBalance.Text = row.Cells["Column7"].Value?.ToString() ?? "0.00";
        //        lbChange.Text = "0.00";
        //        lbId.Text = row.Cells["Column1"].Value?.ToString() ?? "0";
        //        if (rbFullPayment.Checked)
        //        {
        //            txtPaymentReceived.Text = lbBalance.Text;
        //        }
        //        else
        //        {
        //            txtPaymentReceived.Text = "0.00";
        //        }
        //    }
        //}

        //private void rbFullPayment_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbFullPayment.Checked)
        //    {
        //        txtPaymentReceived.Text = lbBalance.Text;
        //    }
        //    else
        //    {
        //        txtPaymentReceived.Text = "0.00";
        //    }
        //}

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (allPayments.Count == 0)
                {
                    MessageBox.Show("No payments to print.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                paymentsToPrint = allPayments;
                currentPrintIndex = 0;
                currentPage = 1;

                PrintPreviewDialog preview = new PrintPreviewDialog();
                PrintDocument printDoc = new PrintDocument();

                // Use printer's built-in A4
                foreach (PaperSize ps in printDoc.PrinterSettings.PaperSizes)
                {
                    if (ps.Kind == PaperKind.A4)
                    {
                        printDoc.DefaultPageSettings.PaperSize = ps;
                        break;
                    }
                }

                // TRUE Landscape
                printDoc.DefaultPageSettings.Landscape = true;

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
            if (paymentsToPrint.Count == 0) return;

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

            // Define footer height
            int footerHeight = 30;
            int maxTableY = bottomMargin - footerHeight - 10;

            // Draw outer border for the entire report (adjust height dynamically if needed, but for simplicity, keep as is)
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
            string reportTitle = "Payment Reports List";
            SizeF titleSize = e.Graphics.MeasureString(reportTitle, subHeaderFont);
            e.Graphics.DrawString(reportTitle, subHeaderFont, subHeaderBrush, (leftMargin + rightMargin - titleSize.Width) / 2, innerY);
            innerY += (int)titleSize.Height + 10; // Adjust yPos to after the title

            yPos = innerY; // Set yPos to the end of the header content

            // Table Header
            e.Graphics.DrawString("Payment Reports List", subHeaderFont, subHeaderBrush, leftMargin, yPos);
            yPos += (int)e.Graphics.MeasureString("Payment Reports List", subHeaderFont).Height + 10;

            // Define column widths (ensure they fit within pageWidth; adjust if necessary)
            int col1Width = 80; // Student ID
            int col2Width = 200; // Student Name
            int col3Width = 100; // Grade Level
            int col4Width = 120; // Tuition Fee
            int col5Width = 120; // Total Paid
            int col6Width = 120; // Remaining Balance
            int rowHeight = 25;

            // Draw table header
            Rectangle tableHeaderBox = new Rectangle(leftMargin, yPos, pageWidth, rowHeight);
            e.Graphics.DrawRectangle(borderPen, tableHeaderBox);

            int xPos = leftMargin;
            e.Graphics.DrawString("Student ID", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col1Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Student Name", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col2Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Grade Level", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col3Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Tuition Fee", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col4Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Total Paid", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);
            xPos += col5Width;
            e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

            e.Graphics.DrawString("Remaining Balance", tableHeaderFont, tableBrush, xPos + 5, yPos + 5);

            yPos += rowHeight;

            // Draw table rows
            for (int i = currentPrintIndex; i < paymentsToPrint.Count; i++)
            {
                var payment = paymentsToPrint[i];
                if (yPos + rowHeight > maxTableY) // Check if new page needed, leaving space for footer
                {
                    e.HasMorePages = true;
                    currentPrintIndex = i; // Save current index for next page
                                           // Draw footer before returning
                    DrawFooter(e, footerFont, bodyBrush, leftMargin, rightMargin, bottomMargin, footerHeight);
                    return;
                }

                Rectangle rowBox = new Rectangle(leftMargin, yPos, pageWidth, rowHeight);
                e.Graphics.DrawRectangle(borderPen, rowBox);

                xPos = leftMargin;
                e.Graphics.DrawString(payment.StudentId.ToString(), bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col1Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(payment.StudentName, bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col2Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(payment.GradeLevel, bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col3Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(payment.TuitionFee.ToString("C"), bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col4Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(payment.TotalPaid.ToString("C"), bodyFont, bodyBrush, xPos + 5, yPos + 5);
                xPos += col5Width;
                e.Graphics.DrawLine(borderPen, xPos, yPos, xPos, yPos + rowHeight);

                e.Graphics.DrawString(payment.RemainingBalance.ToString("C"), bodyFont, bodyBrush, xPos + 5, yPos + 5);

                yPos += rowHeight;
                currentPrintIndex = i + 1; // Update index
            }

            // Draw footer on the last page or any page after rows
            DrawFooter(e, footerFont, bodyBrush, leftMargin, rightMargin, bottomMargin, footerHeight);

            currentPage++; // Increment for next page
            e.HasMorePages = false;
        }

        private void DrawFooter(System.Drawing.Printing.PrintPageEventArgs e, Font footerFont, Brush bodyBrush, int leftMargin, int rightMargin, int bottomMargin, int footerHeight)
        {
            string dateLine = $"Report Generated on: {DateTime.Now:yyyy-MM-dd}";
            SizeF dateSize = e.Graphics.MeasureString(dateLine, footerFont);
            e.Graphics.DrawString(dateLine, footerFont, bodyBrush, leftMargin, bottomMargin - footerHeight + 5);

            string pageNumber = $"Page {currentPage}";
            SizeF pageSize = e.Graphics.MeasureString(pageNumber, footerFont);
            e.Graphics.DrawString(pageNumber, footerFont, bodyBrush, rightMargin - pageSize.Width, bottomMargin - footerHeight + 5);
        }

    }
}
