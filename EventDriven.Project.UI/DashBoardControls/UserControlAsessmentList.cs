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
    public partial class UserControlAsessmentList : UserControl
    {
        private readonly StudentController studentController;
        private UserControlAssessment studentAssessmentControl;
        private string role;
        private UserModel authenticationKey;
        private MainForm main;
        private AcademicYearController academicYearController;
        private List<AcademicYearModel> academicYearModels;
        public UserControlAsessmentList(string role, MainForm main, UserModel authenticationKey)
        {
            InitializeComponent();
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            studentController = new StudentController();
            academicYearController = new AcademicYearController();
            LoadStudents();
            loadyear();
        }

        private async void LoadStudents()
        {
            try
            {


                dataGridView1.Rows.Clear();
                List<StudentModel> students = await studentController.GetAllAsync(authenticationKey);
                academicYearModels = await academicYearController.GetAllAsync(authenticationKey);

                foreach (var student in students)
                {

                    dataGridView1.Rows.Add(
                        student.Id,
                        $"{student.FirstName} {student.MiddleName} {student.LastName}",

                        student.Contact,
                        student.GradeLevel,
                        student.BirthDate.ToString("yyyy-MM-dd"),
                        student.AcademicYearId
                    );
                }
                foreach (var year in academicYearModels)
                {
                    comboBox1.Items.Add(year.YearName);
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
        //    studentAssessmentControl.ClearForm();
        //    tabControl1.SelectedIndex = 1;
        //}

        private void edit(int studentId)
        {
            studentAssessmentControl.selectedStudentId = studentId;
            tabControl1.SelectedIndex = 1;
            studentAssessmentControl.txtSearchStudentIn.Text = studentId.ToString();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "ColEdit")
            {
                int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);
                edit(studentId);
                //MessageBox.Show($"Edit student with ID: {studentId}");
                // TODO: open Student Assessment tab and load details
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

        private void UserControlAsessmentList_Load(object sender, EventArgs e)
        {
            //UserControlAssessment info = new UserControlAssessment(role, main, authenticationKey);
            //studentAssessmentControl = info;
            panel1.Controls.Clear();
            studentAssessmentControl.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panel1.Controls.Add(studentAssessmentControl);
            //info.btnSave.Click += refresh;
        }

        private void btnSearchStuIn_Click(object sender, EventArgs e)
        {
            SearchStudent(txtSearch.Text.Trim());
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlAsessmentList_Load_1(object sender, EventArgs e)
        {
            //UserControlAssessment info = new UserControlAssessment(role, main, authenticationKey);
            //studentAssessmentControl = info;
            //panel2.Controls.Clear();
            //studentAssessmentControl.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            //panel2.Controls.Add(studentAssessmentControl);
            //info.btnSave.Click += refresh;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadyear();
        }
        private async void loadyear()
        {
            int id = await academicYearController.getYearId(comboBox1.Text, academicYearModels, authenticationKey);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool match = false;
                match = row.Cells["Column1"].Value.ToString().Contains(id.ToString());
                row.Visible = match;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the search when Enter is pressed
                SearchStudent(txtSearch.Text.Trim());  // Fixed: Call the async method
                // Optional: Prevent the beep sound on Enter
                e.SuppressKeyPress = true;
            }
        }
    }
}