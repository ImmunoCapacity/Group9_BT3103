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
        private UserControlStudentInformation studentInformationControl;
        private string role;
        private UserModel authenticationKey;
        private MainForm main;
        public UserControlStudentInfoList(string role, MainForm main, UserModel authenticationKey)
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
                    if (student.Status != "Inactive")
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            studentInformationControl.selectAdd();
            studentInformationControl.ClearForm();
            tabControl1.SelectedIndex = 1;
        }


        private void edit(int studentId)
        {
            studentInformationControl.selectEdit();
            studentInformationControl.selectedStudentId = studentId;
            tabControl1.SelectedIndex = 1;
            studentInformationControl.txtSearchStudentIn.Text = studentId.ToString();
            studentInformationControl.search();
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

        private void UserControlStudentInfoList_Load(object sender, EventArgs e)
        {
            UserControlStudentInformation info = new UserControlStudentInformation(role, main, authenticationKey);
            studentInformationControl = info;
            panel1.Controls.Clear();
            studentInformationControl.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panel1.Controls.Add(studentInformationControl);
            info.btnSave.Click += refresh;
        }
        private void btnSearchStuIn_Click(object sender, EventArgs e)
        {
            SearchStudent(txtSearch.Text.Trim());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchStudent(txtSearch.Text.Trim());
            }
        }

        private void SearchStudent(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.Visible = true;
                return;
            }

            bool isNumber = Regex.IsMatch(searchValue, @"^\d+$");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool match = false;

                if (isNumber)
                {
                    match = row.Cells["Column1"].Value.ToString().Contains(searchValue);
                    row.Visible = match;
                }
                else
                {
                    match = row.Cells["Column2"].Value.ToString()
                                  .ToLower()
                                  .Contains(searchValue.ToLower());
                    row.Visible = match;
                }
            }
        }

        //private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        // Trigger the search when Enter is pressed
        //        SearchStudent(txtSearch.Text.Trim());  // Fixed: Pass the trimmed text as parameter
        //        // Optional: Prevent the beep sound on Enter
        //        e.SuppressKeyPress = true;
        //    }
        //}
    }
}
