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
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlStudentPayment : UserControl
    {
        private readonly PaymentController paymentController;
        private UserControlStudentInformation studentRegistrationControl;
        private string role;
        private UserModel authenticationKey;
        private MainForm main;
        private PaymentModel selectedPayment; // Set this before printing
        private int currentPage = 1;

        // Fields to hold data for printing
        private StudentPaymentInfo currentStudentPayment;
        private decimal currentPaymentReceived;
        private decimal currentChange;
        private decimal currentBalance;
        private DateTime currentDate;

        // Added missing fields for list printing
        private List<StudentPaymentInfo> allPayments = new List<StudentPaymentInfo>(); // To hold all payments for printing
        private List<StudentPaymentInfo> paymentsToPrint = new List<StudentPaymentInfo>();
        private int currentPrintIndex = 0;

        private string Peso(decimal value)
        {
            return $"₱{value:N2}";
        }

        public UserControlStudentPayment(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();
            paymentController = new PaymentController();
            cmbPaymentStatus.Text = "Unpaid";
            LoadStudents();

        }


        //private string getTuitionFee()
        //{
        //    return dataGridView1.SelectedCells
        //}
        private async void LoadStudents()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                List<StudentPaymentInfo> payments = await paymentController.GetAllStudentPayment(authenticationKey);
                allPayments = payments;

                foreach (var payment in payments)
                {
                    if (cmbPaymentStatus.Text.Equals("Unpaid") && payment.TuitionFee > payment.TotalPaid && payment.PaymentMethod != null)
                    {
                        // ==== DataGridView1 (Summary List) ====
                        addPaymentToDataGrid(payment);
                    }
                    else if (cmbPaymentStatus.Text.Equals("Paid") && payment.TuitionFee <= payment.TotalPaid && payment.PaymentMethod != null)
                    {
                        addPaymentToDataGrid(payment);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.Columns["Column1"].ValueType = typeof(int);
            dataGridView2.Columns["dataGridViewTextBoxColumn1"].ValueType = typeof(int);

            // Sort both tables by ID
            dataGridView1.Sort(dataGridView1.Columns["Column1"], ListSortDirection.Ascending);
            dataGridView2.Sort(dataGridView2.Columns["dataGridViewTextBoxColumn1"], ListSortDirection.Ascending);

            // ============================================
            // ✅ Add Peso Formatting to Both Grids
            // ============================================
            // DataGridView1
            dataGridView1.Columns["Column4"].DefaultCellStyle.Format = "₱#,0.00"; // Tuition Fee
            dataGridView1.Columns["Column5"].DefaultCellStyle.Format = "₱#,0.00"; // Total Paid
            dataGridView1.Columns["Column7"].DefaultCellStyle.Format = "₱#,0.00"; // Remaining Balance

            // DataGridView2
            dataGridView2.Columns["dataGridViewTextBoxColumn4"].DefaultCellStyle.Format = "₱#,0.00"; // Tuition Fee
            dataGridView2.Columns["dataGridViewTextBoxColumn5"].DefaultCellStyle.Format = "₱#,0.00"; // Total Paid
            dataGridView2.Columns["dataGridViewTextBoxColumn6"].DefaultCellStyle.Format = "₱#,0.00"; // Remaining Balance
            dataGridView2.Columns["Column11"].DefaultCellStyle.Format = "₱#,0.00"; // Tuition
        }

        private void addPaymentToDataGrid(StudentPaymentInfo payment)
        {
            dataGridView1.Rows.Add(
                            payment.StudentId,
                            payment.StudentName,
                            payment.GradeLevel,
                            payment.TuitionFee,
                            payment.TotalPaid,
                            payment.RemainingBalance,
                            payment.PaymentMethod
                        );

            // ==== DataGridView2 (Next Payment Breakdown) ====
            dataGridView2.Rows.Add(
                payment.StudentId,
                payment.StudentName,
                payment.GradeLevel,
                payment.TuitionFee,
                payment.NextAmountDue,
                payment.TotalPaid,
                payment.RemainingBalance,
                payment.NextDueDate,
                payment.NextScheduleDescription,
                payment.PaymentMethod
            );
        }

        private PaymentModel currentPayment;

        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Ensure a student is selected
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2️⃣ Validate and get Student ID
                if (!int.TryParse(lbId.Text, out int studentId))
                {
                    MessageBox.Show("Invalid student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3️⃣ Validate payment input (strip ₱ sign before parsing)
                string paymentInput = txtPaymentReceived.Text.Replace("₱", "").Trim();
                if (!decimal.TryParse(paymentInput, out decimal paymentAmount))
                {
                    MessageBox.Show("Please enter a valid numeric payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 🚫 Prevent zero or negative payments
                if (paymentAmount <= 0)
                {
                    MessageBox.Show("Invalid Payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4️⃣ Validate balance (strip ₱ sign before parsing)
                string balanceInput = lbBalance.Text.Replace("₱", "").Trim();
                if (!decimal.TryParse(balanceInput, out decimal currentBalance))
                {
                    MessageBox.Show("Invalid balance amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal change = 0;

                // ⚖️ Handle overpayment
                if (paymentAmount > currentBalance)
                {
                    change = paymentAmount - currentBalance;
                    paymentAmount = currentBalance; // record only up to the remaining balance
                }
                //string tuition

                // 5️⃣ Determine payment type
                string paymentType = rbFullPayment.Checked ? "Full" : "Partial";

                // 6️⃣ Build model
                currentPayment = new PaymentModel
                {
                    StudentId = studentId,
                    AmountPaid = paymentAmount,
                    DatePaid = DateTime.Now,
                    Change = change,
                    PaymentType = paymentType,
                    Grade = grade,
                    Name = name
                };

                // 7️⃣ Send to controller
                var addedPayment = await paymentController.AddAsync(currentPayment, authenticationKey);

                // ✅ Success message
                string msg = $"Payment of ₱{paymentAmount:N2} added successfully!";
                if (change > 0)
                    msg += $"\nChange to return: ₱{change:N2}";

                MessageBox.Show(msg, "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 8️⃣ Refresh data grid & UI
                LoadStudents(); // reload student list
                UpdatePayment(change, paymentAmount, currentBalance);

                //// 9️⃣ Reset input
                //txtPaymentReceived.Text = "0.00";
                rbFullPayment.Checked = rbFullPayment.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePayment(decimal change, decimal paymentAmount, decimal currentBalance)
        {
            currentBalance = currentBalance - paymentAmount;
            // Update the UI labels
            lbBalance.Text = Peso(currentBalance);
            lbChange.Text = Peso(change);

            //// Reset the payment textbox
            //txtPaymentReceived.Text = "0.00";
        }

        private void btnSearchStuIn_Click(object sender, EventArgs e)
        {
            SearchStudent(txtSearch.Text);
        }

        private void SearchStudent(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                // Show all rows if search is empty
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.Visible = true;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                    row.Visible = true;
                return;
            }

            // only digits
            match(dataGridView1, searchValue);
            match(dataGridView2, searchValue);
        }

        private void match(DataGridView rows, string searchValue)
        {
            bool isNumber = Regex.IsMatch(searchValue, @"^\d+$");
            foreach (DataGridViewRow row in rows.Rows)
            {
                if (row.IsNewRow) continue;

                bool match = false;

                if (isNumber)
                {
                    // Search by ID (exact match) - Check if column exists
                    if (rows.Columns.Contains("Column1") && row.Cells["Column1"].Value != null)
                    {
                        match = row.Cells["Column1"].Value.ToString().Contains(searchValue);
                    }
                    else if (rows.Columns.Contains("dataGridViewTextBoxColumn1") && row.Cells["dataGridViewTextBoxColumn1"].Value != null)
                    {
                        match = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString().Contains(searchValue);
                    }
                }
                else
                {
                    // Search by Name (partial match) - Assume Column2 exists; add check if needed
                    if (rows.Columns.Contains("Column2") && row.Cells["Column2"].Value != null)
                    {
                        match = row.Cells["Column2"].Value.ToString()
                                    .ToLower()
                                    .Contains(searchValue.ToLower());
                    }
                }

                row.Visible = match;
            }
        }

        string tuitionFee;
        string grade;
        string name;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure user clicked a valid row (not header or empty space)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Example: assuming these are the column names or indexes
                name = row.Cells["Column2"].Value?.ToString() ?? "";
                grade = row.Cells["Column3"].Value?.ToString() ?? "";
                tuitionFee = "₱" + row.Cells["Column4"].Value?.ToString() ?? "0.00";
                lbName.Text = row.Cells["Column2"].Value?.ToString() ?? "";
                lbBalance.Text = "₱" + row.Cells["Column7"].Value?.ToString() ?? "0.00";
                lbChange.Text = "₱0.00";
                lbId.Text = row.Cells["Column1"].Value?.ToString() ?? "0";
                if (row.Cells["Column12"].Value.ToString().Equals("Full"))
                {
                    rbFullPayment.Checked = true;
                    txtPaymentReceived.Text = "₱" + lbBalance.Text;

                }
                else
                {
                    rbPartialPayment.Checked = true;
                    txtPaymentReceived.Text = "₱0.00";

                }
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            // Make sure user clicked a valid row (not header or empty space)
            if (row.Cells["Column10"].Value?.ToString().Length > 0)
            {
                // Example: assuming these are the column names or indexes

                grade = row.Cells["dataGridViewTextBoxColumn3"].Value?.ToString() ?? "";
                tuitionFee = "₱" + row.Cells["dataGridViewTextBoxColumn4"].Value?.ToString() ?? "";
                name = lbName.Text = row.Cells["dataGridViewTextBoxColumn2"].Value?.ToString() ?? "" ?? "";
                lbBalance.Text = "₱" + row.Cells["dataGridViewTextBoxColumn6"].Value?.ToString() ?? "0.00";
                lbChange.Text = "₱0.00";
                lbId.Text = row.Cells["dataGridViewTextBoxColumn1"].Value?.ToString() ?? "0";
                if (row.Cells["Column10"].Value.ToString().Equals("Full"))
                {
                    rbFullPayment.Checked = true;
                    txtPaymentReceived.Text = lbBalance.Text;

                }
                else
                {
                    rbPartialPayment.Checked = true;
                    txtPaymentReceived.Text = row.Cells["Column11"].Value?.ToString() ?? ""; ;

                }
            }
        }

        private void rbFullPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFullPayment.Checked)
            {
                txtPaymentReceived.Text = lbBalance.Text;
            }
            else
            {
                txtPaymentReceived.Text = "₱0.00";
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedIndex = dataGridView1.CurrentRow.Index;
                currentStudentPayment = allPayments[selectedIndex];

                PrintPreviewDialog preview = new PrintPreviewDialog();
                PrintDocument printDoc = new PrintDocument();
                printDoc.DefaultPageSettings.Landscape = false; // Portrait for single student
                printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // A4 portrait
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
            if (currentPayment == null)
            {
                return;
            }
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
            string title = "Payment Receipt";
            SizeF titleSize = g.MeasureString(title, subHeaderFont);
            g.DrawString(title, subHeaderFont, blackBrush, leftMargin + (pageWidth - titleSize.Width) / 2, innerY);

            yPos += headerHeight + 20;
            yPos += 50;

            // Student Information Section
            g.DrawString("Student Information", subHeaderFont, blackBrush, leftMargin, yPos);
            yPos += (int)g.MeasureString("Student Information", subHeaderFont).Height + 10;

            string[] studentInfo = {
                $"Student ID: {currentPayment.StudentId}",
                $"Name: {currentPayment.Name}",
                $"Grade Level: {currentPayment.Grade}",
                $"Tuition Fee: ₱{tuitionFee}",
                $"Total Paid: ₱{currentPayment.AmountPaid:N2}",
                $"Remaining Balance: ₱{lbBalance.Text}"
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

            // Additional Information Section (optional, can be customized or removed)
            g.DrawString("Additional Information", subHeaderFont, blackBrush, leftMargin, yPos);
            yPos += (int)g.MeasureString("Additional Information", subHeaderFont).Height + 10;

            string[] additionalInfo = {
                "Payment Status: Paid", // Placeholder or customize based on data
                "Date: " + DateTime.Now.ToString("yyyy-MM-dd") // Or use specific date if available
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

        private void lbChange_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPaymentReceived_TextChanged(object sender, EventArgs e)
        {
            // Remove existing peso sign if user types it manually
            string input = txtPaymentReceived.Text.Replace("₱", "").Trim();

            // Only allow numbers and dot
            if (decimal.TryParse(input, out decimal value))
            {
                // Format with peso sign
                txtPaymentReceived.Text = "₱" + value.ToString("N2");
                txtPaymentReceived.SelectionStart = txtPaymentReceived.Text.Length; // Keep cursor at end
            }
            else if (string.IsNullOrEmpty(input))
            {
                txtPaymentReceived.Text = "₱0.00";
                txtPaymentReceived.SelectionStart = txtPaymentReceived.Text.Length;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the search when Enter is pressed (no validation needed, as SearchStudent handles empty input)
                SearchStudent(txtSearch.Text);
                // Optional: Prevent the beep sound on Enter
                e.SuppressKeyPress = true;
            }
        }

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
