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
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlStudentPayment : UserControl
    {
        private readonly StudentController studentController;
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
            studentController = new StudentController();
            LoadStudents();
        }
        private async void LoadStudents()
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<StudentModel> students = await studentController.GetAllAsync(authenticationKey);

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
                //MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            
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
    }
}
