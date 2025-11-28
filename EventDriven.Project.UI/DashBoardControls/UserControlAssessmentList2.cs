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
        private List<StudentAssessment> allAssessments; // Store all assessments for filtering

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
            try
            {
                allAssessments = await assessmentController2.GetAllAssessmentsAsync(authenticationKey);

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
                        Year = g.First().year
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
                var years = datasource
                    .Select(s => s.Year)
                    .Distinct()
                    .OrderBy(y => y)
                    .ToList();

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(years.Cast<object>().ToArray());

                // Select the last year if available
                if (years.Any())
                {
                    comboBox1.SelectedItem = years.Last();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearchStuIn_Click(object sender, EventArgs e)
        {
            await SearchStudent(txtSearch.Text.Trim());
        }

        private async Task SearchStudent(string searchText)
        {
            try
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    // If search is empty, reload all students
                    LoadStudents();
                    return;
                }

                // Filter the allAssessments list
                var filtered = allAssessments
                    .Where(s =>
                        s.StudentId.ToString().Contains(searchText) ||
                        s.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                        s.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .GroupBy(s => s.StudentId)
                    .Select(g => new
                    {
                        Id = g.Key,
                        FullName = $"{g.First().FirstName} {g.First().MiddleName} {g.First().LastName}".Replace("  ", " ").Trim(),
                        Grade = g.First().GradeLevel,
                        Section = g.First().StudentSection,
                        GWA = g.First().GWA,
                        Status = g.First().Status,
                        Year = g.First().year
                    })
                    .ToList();

                dataGridView1.DataSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            // Get the StudentId from the selected row
            int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

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

        private void loadyear()
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    // If no year selected, show all rows
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Visible = true;
                    }
                    return;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool match = row.Cells["Year"].Value?.ToString().Contains(comboBox1.Text) ?? false;
                    row.Visible = match;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering by year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
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
