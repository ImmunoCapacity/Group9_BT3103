using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public UserControlStudentPayment(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();
            paymentController = new PaymentController();
            LoadStudents();
        }
        private async void LoadStudents()
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<StudentPaymentInfo> payments = await paymentController.GetAllStudentPayment(authenticationKey);

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
        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Get selected student row
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student first.");
                    return;
                }
                decimal change = 0;
                int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["column1"].Value);

                // 2️⃣ Get payment info from UI
                if (!decimal.TryParse(txtPaymentReceived.Text, out decimal paymentAmount))
                {
                    MessageBox.Show("Invalid payment amount.");
                    return;
                }
                if (!decimal.TryParse(lbBalance.Text, out decimal currentBalance))
                {
                    MessageBox.Show("Invalid payment amount.");
                    return;
                }


                if (paymentAmount > currentBalance)
                {
                    change = paymentAmount - currentBalance;
                    paymentAmount = currentBalance; // record only up to the remaining balance
                }

                string paymentType = rbFullPayment.Checked ? "Full" : "Partial";

                // 3️⃣ Create payment model
                PaymentModel payment = new PaymentModel
                {
                    StudentId = studentId,
                    AmountPaid = paymentAmount,
                    DatePaid = DateTime.Now,
                    PaymentType = paymentType
                };

                // 4️⃣ Add payment via controller
                var addedPayment = await paymentController.AddAsync(payment, authenticationKey);

                MessageBox.Show($"Payment of {paymentAmount:C} added successfully!");

                // 5️⃣ Refresh UI: grid & labels
                LoadStudents(); // your method to reload DataGridView
                UpdatePayment(change, paymentAmount, currentBalance);

                // Clear payment input
                txtPaymentReceived.Text = "";

                rbFullPayment.Checked = rbFullPayment.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}");
            }
        }
        private void UpdatePayment(decimal change, decimal paymentAmount,  decimal currentBalance)
        {
            currentBalance = currentBalance - paymentAmount;
            // Update the UI labels
            lbBalance.Text = currentBalance.ToString("F2");
            lbChange.Text = change.ToString("F2");

            // Reset the payment textbox
            txtPaymentReceived.Text = "0.00";
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
                lbName.Text = row.Cells["Column2"].Value?.ToString() ?? "";
                lbBalance.Text = row.Cells["Column7"].Value?.ToString() ?? "0.00";
                lbChange.Text = "0.00";
                if (rbFullPayment.Checked)
                {
                    txtPaymentReceived.Text = lbBalance.Text;
                }
                else
                {
                    txtPaymentReceived.Text = "0.00";
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
                txtPaymentReceived.Text = "0.00";
            }
        }

    }
}
