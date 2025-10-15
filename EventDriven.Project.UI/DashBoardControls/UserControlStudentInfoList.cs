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
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.DashBoardControls
{
    public partial class UserControlStudentInfoList : UserControl
    {
        private readonly StudentController studentController;
        private UserControlStudentInfo studentRegistrationControl;
        private string role;
        private MainForm main;
        public UserControlStudentInfoList(string role, MainForm main)
        {
            this.role = role;
            this.main = main;
            InitializeComponent();
            studentController = new StudentController();
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<StudentModel> students = studentController.GetAll();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            studentRegistrationControl.selectAdd();
            studentRegistrationControl.ClearForm();
            tabControl1.SelectedIndex = 1;
        }
        

        private void edit(int studentId)
        {
            studentRegistrationControl.selectEdit();
            studentRegistrationControl.selectedStudentId = studentId;
            tabControl1.SelectedIndex = 1;
            studentRegistrationControl.txtSearchStudentIn.Text = studentId.ToString();
            studentRegistrationControl.search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "ColEdit")
            {
                int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);
                edit(studentId);
                //MessageBox.Show($"Edit student with ID: {studentId}");
                // TODO: open Student Registration tab and load details
            }
            else if (columnName == "ColDelete")
            {
                if(role != "Admin")
                {
                    MessageBox.Show("Only Admin can delete student records.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);

                var confirm = MessageBox.Show("Delete this student?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    studentController.Delete(studentId);
                    LoadStudents(); // refresh grid
                }
            }
        }

        private void UserControlStudentInfoList_Load(object sender, EventArgs e)
        {
            studentRegistrationControl = new UserControlStudentInfo(role, main);
            panel1.Controls.Clear();
            studentRegistrationControl.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panel1.Controls.Add(studentRegistrationControl);
        }
        private void btnSearchStuIn_Click(object sender, EventArgs e)
        {
            SearchStudent(txtSearch.Text.Trim());
        }
        private void SearchInGrid(string idText)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool match = row.Cells["Column1"].Value.ToString().Contains(idText);
                    row.Visible = match;
                }
            }
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
