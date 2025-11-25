using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlPaymentHistory : UserControl
    {
        private readonly PaymentController paymentController;
        private UserControlStudentInformation studentRegistrationControl;
        private string role;
        private UserModel authenticationKey;
        private MainForm main;
        private AcademicYearModel AcademicYearModel;
        private FeeStructure feeStructure;
        public UserControlPaymentHistory(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();
            paymentController = new PaymentController();
            LoadPaymentHistory();
            dataGridView1.SortCompare += dataGridView1_SortCompare;
        }
        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // Only apply to ID column (replace "Column1" with your actual column name)
            if (e.Column.Name == "Column1")
            {
                int val1 = int.Parse(e.CellValue1.ToString());
                int val2 = int.Parse(e.CellValue2.ToString());
                e.SortResult = val1.CompareTo(val2);
                e.Handled = true;
            }
        }

        private async void LoadPaymentHistory()
        {
            try
            {
                dataGridView1.Rows.Clear();

                // Get all payments
                var payments = await paymentController.GetAllPayments(authenticationKey);

                // Fill DataGridView manually
                foreach (var payment in payments)
                {
                    dataGridView1.Rows.Add(
                        payment.PaymentId,
                        payment.StudentName,
                        payment.DatePaid.ToString("MM/dd/yyyy"),
                        payment.PaymentType,
                        string.Format("₱{0:N2}", payment.AmountPaid),  // Updated: Add ₱ sign with formatting
                        string.Format("₱{0:N2}", payment.RemainingBalance),  // Updated: Add ₱ sign with formatting
                        payment.StudentId,
                        payment.GradeLevel

                    );
                }
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment history: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchStuIn_Click(object sender, EventArgs e)
        {
            // Get the search value from the TextBox
            string searchValue = txtSearch.Text.Trim();

            // If the search value is empty, show a message and return
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a student ID or name.");
                return;
            }

            // Check if the input is a valid student ID (numeric)
            if (int.TryParse(searchValue, out _))
            {
                // If it's a valid student ID, search by ID (true)
                SearchStudent(searchValue, true);
            }
            else
            {
                // If it's not a valid ID, search by name (false)
                SearchStudent(searchValue, false);
            }
        }


        private void SearchStudent(string searchValue, bool searchById)
        {
            // Reset visibility before starting the search
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true; // Show all rows initially
                }
            }

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                return; // Do nothing if the search value is empty
            }

            bool isNumber = int.TryParse(searchValue, out _); // Check if it's an ID (numeric)

            string searchValueLower = searchValue.ToLower(); // For name search, make it case-insensitive

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool match = false;

                if (searchById || isNumber)
                {
                    // Search by ID (exact match)
                    string studentId = row.Cells["PaymentId"].Value?.ToString(); 
                    match = studentId != null && studentId.Equals(searchValue, StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    // Search by Name (partial match, case-insensitive)
                    string studentName = row.Cells["StudentName"].Value?.ToString();
                    match = studentName != null && studentName.ToLower().Contains(searchValueLower);
                }

                // Set row visibility based on match
                row.Visible = match;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure user clicked a valid row (not header or empty space)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Example: assuming these are the column names or indexes
                lbName.Text = row.Cells["StudentName"].Value?.ToString() ?? "";

                // Updated: Strip ₱ and commas before parsing to avoid FormatException
                string balanceStr = row.Cells["RemainingBalance"].Value?.ToString() ?? "₱0.00";
                balanceStr = balanceStr.Replace("₱", "").Replace(",", "");
                decimal balance = decimal.Parse(balanceStr);
                lbBalance.Text = $"₱{balance:N2}";  // Reformat with ₱ sign

                lbId.Text = row.Cells["studentID"].Value?.ToString() ?? "0";
                getTotal();
                getBreakDown(row.Cells["Grade"].Value?.ToString() ?? "");
            }
        }
        private async void getTotal()
        {
            decimal totalPaid = await paymentController.GetTotalPaidByStudentIdAsync(int.Parse(lbId.Text), authenticationKey);
            lbTotal.Text = string.Format("₱{0:N2}", totalPaid);  // Updated: Add ₱ sign with formatting
        }
        private async void getBreakDown(string grade)
        {
            feeStructure = await paymentController.GetFeeStructureByGradeAsync(grade, authenticationKey);

            lbBreakDown.Text =
                $"Base Tuition: ₱{feeStructure.BaseTuition:N2}\n" +
                $"Lab Fee: ₱{feeStructure.LabFee:N2}\n" +
                $"Library Fee: ₱{feeStructure.LibraryFee:N2}\n" +
                $"Sports Fee: ₱{feeStructure.SportsFee:N2}\n" +
                $"Total Tuition: ₱{feeStructure.TuitionFee}";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Get the search value and trim it to remove any extra spaces
                string searchValue = txtSearch.Text.Trim();

                // If the search value is empty, show a message and return
                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    MessageBox.Show("Please enter a student ID or name.");
                    return;
                }

                // Check if the input is a valid student ID (numeric)
                if (int.TryParse(searchValue, out int studentId))
                {
                    // If it's a valid student ID, trigger the search by ID
                    SearchStudent(studentId.ToString(), true); // Assuming SearchStudent can handle ID search
                }
                else
                {
                    // If it's not a valid ID, trigger the search by name
                    SearchStudent(searchValue, false); // Assuming SearchStudent handles name search
                }

                // Optional: Prevent the beep sound when pressing Enter
                e.SuppressKeyPress = true;
            }
        }

    }
}
