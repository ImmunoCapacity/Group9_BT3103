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
    public partial class UserControlHome : UserControl
    {
        private string role;
        private MainForm main;
        private UserModel authenticationKey;
        private readonly PaymentController paymentController;
        private readonly StudentController studentController;
        private readonly AssessmentController2 assessmentController2;
        private readonly RegistrationController registrationController;

        public UserControlHome(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();
            paymentController = new PaymentController(); 
            studentController = new StudentController();
            assessmentController2 = new AssessmentController2();
            registrationController = new RegistrationController();
        }

        private async void UserControlHome_Load(object sender, EventArgs e)
        {
            await LoadStudentHome();  // Load both counts asynchronously
        }

        private async Task LoadStudentHome()
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<StudentModel> students = await studentController.GetAllAsync(authenticationKey);

                dataGridView1.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                // Fetch all student payment info
                var studentPayments = await paymentController.GetAllStudentPayment(authenticationKey);
                var RegisteredStudents = await registrationController.GetAllAsync(authenticationKey);

                // Count students where TotalPaid > 0 (paid)
                int totalPaidStudents = studentPayments.Count(sp => sp.TotalPaid > 0);

                // Count students where TotalPaid == 0 (unpaid/pending)
                int totalUnpaidStudents = studentPayments.Count(sp => sp.TotalPaid == 0);

                int totalRegisteredStudents = RegisteredStudents.Count();

                // Fetch enrolled students using AssessmentController
                var enrolledStudents = await assessmentController2.GetAllEnrolledAsync(authenticationKey);
                int totalEnrolledStudents = enrolledStudents.Count(sp => sp.EnrollmentStatus.Equals("Enrolled"));
                // Display in the labels
                lblPaid.Text = $"Paid: {totalPaidStudents}";  // Adjust label name if needed
                lblUnpaid.Text = $"UnPaid: {totalUnpaidStudents}";  // Adjust label name if needed
                lblEnrolled.Text = $"Enrolled: {totalEnrolledStudents}";  // Add this label if needed
                lblPending.Text = $"Registered: {totalRegisteredStudents}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student payment counts: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPaid.Text = "Paid: 0";  // Fallback value
                lblUnpaid.Text = "Pending: 0";  // Fallback value
                lblEnrolled.Text = "Enrolled: 0";  // Fallback value
                lblPending.Text = "Registered: 0";
            }
        }

        private void refresh(object sender, EventArgs e)
        {
            // Implement refresh logic here if needed (e.g., reload data)
            UserControlHome_Load(sender, e);  // Or call LoadStudentPaymentCounts directly
        }

        private void lblUnpaid_Click(object sender, EventArgs e)
        {

        }
    }
}
