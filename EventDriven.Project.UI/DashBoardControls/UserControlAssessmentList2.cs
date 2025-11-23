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
    public partial class UserControlAssessmentList2 : UserControl
    {
        string role;
        MainForm main;
        UserModel authenticationKey;
        AssessmentController2 assessmentController2;
        private AcademicYearController academicYearController;
        private List<AcademicYearModel> academicYearModels;


        public UserControlAssessmentList2(string role, MainForm main, UserModel authenticationKey)
        {
            this.role = role;
            this.main = main;
            this.authenticationKey = authenticationKey;
            InitializeComponent();
            assessmentController2 = new AssessmentController2();
            LoadStudents();
            action();
            loadyear();

        }

        private async void LoadStudents()
        {
            loadyear();
            List<StudentAssessment> allAssessments =
                await assessmentController2.GetAllAssessmentsAsync(authenticationKey);
            
            // Group by student to remove duplicates caused by multiple schedules/payments
            var datasource = allAssessments
                .GroupBy(s => s.StudentId)
                .Select(g => new
                {
                    Id = g.Key,
                    FullName = $"{g.First().FirstName} {g.First().MiddleName} {g.First().LastName}".Replace("  ", " ").Trim(),
                    Grade = g.First().GradeLevel,
                    Section = g.First().StudentSection,
                    GWA = g.First().GWA,
                    Status = g.First().Status,
                    year = g.First().year
                    
                })
                .ToList();

            dataGridView1.DataSource = datasource;

            // Adjust column headers
            dataGridView1.Columns["Id"].HeaderText = "Student ID";
            dataGridView1.Columns["FullName"].HeaderText = "Name";
            dataGridView1.Columns["Grade"].HeaderText = "Grade";
            dataGridView1.Columns["Section"].HeaderText = "Section";
            dataGridView1.Columns["GWA"].HeaderText = "GWA";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["Year"].HeaderText = "Year";
            //dataGridView1.Columns["Year"].Visible = false;

            // Auto-size columns to fit content
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();

            // Optional: set alignment
            dataGridView1.Columns["GWA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Grade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Section"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Optional: prevent user from resizing
            dataGridView1.AllowUserToResizeColumns = false;
            // Populate ComboBox with distinct years

            var lastYear = datasource
            .Select(s => s.year)
            .Distinct()
            .OrderBy(y => y)
            .LastOrDefault();


            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(
                datasource
                    .Select(s => s.year)
                    .Distinct()
                    .OrderBy(y => y)
                    .Cast<object>()
                    .ToArray()
            );
            comboBox1.SelectedItem = lastYear;


        }


        private async void btnSearchStuIn_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // If search is empty, load all students
                List<StudentAssessment> allStudents = await assessmentController2.GetAllAssessmentsAsync(authenticationKey);
                dataGridView1.DataSource = allStudents;
                return;
            }

            // Load all students (or you could create a specific search query in your repository)
            List<StudentAssessment> allStudentsList = await assessmentController2.GetAllAssessmentsAsync(authenticationKey);

            // Filter by Id, FirstName, or LastName
            var filtered = allStudentsList
                .Where(s =>
                    s.StudentId.ToString().Contains(searchText) ||
                    s.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    s.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridView1.DataSource = filtered;
            loadyear();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            // Get the StudentId from the selected row
            int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value); // "Id" if using mapped datasource

            // Clear any existing controls in panel1
            panel1.Controls.Clear();

            // Instantiate the assessment control
            var assessmentControl = new UserControlAssessment(studentId, authenticationKey.Role, main, authenticationKey);

            // Dock it to fill the panel
            assessmentControl.Dock = DockStyle.Fill;

            // Add it to the panel
            panel1.Controls.Add(assessmentControl);
            tabControl1.SelectedIndex = 1;
        }

        void action()
        {
            UserControlAssessment info = new UserControlAssessment(1, role, main, authenticationKey);

            panel1.Controls.Clear();
            info.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panel1.Controls.Add(info);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            loadyear();
        }
        private async void loadyear()
        {
            try
            {
                if(comboBox1.Text == null) { return; }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool match = false;
                    match = row.Cells["Year"].Value.ToString().Contains(comboBox1.Text);
                    row.Visible = match;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
