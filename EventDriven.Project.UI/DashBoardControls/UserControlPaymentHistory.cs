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
                        payment.AmountPaid.ToString("C2"),
                        payment.RemainingBalance.ToString("C2"),
                        payment.StudentId
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
            SearchStudent(txtSearch.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure user clicked a valid row (not header or empty space)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Example: assuming these are the column names or indexes
                lbName.Text = row.Cells["StudentName"].Value?.ToString() ?? "";
                lbBalance.Text = row.Cells["RemainingBalance"].Value?.ToString() ?? "0.00";;
                lbId.Text = row.Cells["studentID"].Value?.ToString() ?? "0";
                getTotal();
                

            }
        }
        private async void getTotal()
        {
            decimal totalPaid = await paymentController.GetTotalPaidByStudentIdAsync(int.Parse(lbId.Text), authenticationKey);
            lbTotal.Text = totalPaid.ToString("C2");
        }

    }

}
