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
    public partial class UserControlAssessment : UserControl
    {
        private readonly StudentController studentController;
        private readonly AssessmentController2 assessmentController;
        public int selectedStudentId = 0;
        string status = "";
        string action = "Edit";
        MainForm main;
        private List<StudentModel> studentsToPrint = new List<StudentModel>();
        private int currentPrintIndex = 0;
        private UserModel authenticationKey;

        public UserControlAssessment(int id, string role, MainForm main, UserModel authenticationKey)
        {
            InitializeComponent();
            studentController = new StudentController();
            assessmentController = new AssessmentController2();
            this.authenticationKey = authenticationKey;

            this.main = main;

            GetStudent(id);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchStudentIn.Text))
            {
                MessageBox.Show("Please enter a student ID.");
                return;
            }

            if (!int.TryParse(txtSearchStudentIn.Text, out int studentId))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            await GetStudent(studentId);
        }
        public async Task GetStudent(int id)
        {
            try
            {
                var assessmentList = await assessmentController.GetAssessmentAsync(id, authenticationKey);

                if (assessmentList == null || assessmentList.Count == 0)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                var s = assessmentList.First();   // Base info (all rows have same student)

                selectedStudentId = s.StudentId;

                // ------- Fill Labels -------
                lbFullName.Text = $"{s.FirstName} {s.MiddleName} {s.LastName}".Replace("  ", " ").Trim();
                lbId.Text = s.StudentId.ToString();
                lbGrade.Text = s.GradeLevel;
                lbSection.Text = s.StudentSection;
                cbStatus.Text = s.Status;

                // ------- Fill Subjects Grid -------
                var subjectRows = assessmentList
                    .Where(x => x.SubjectID != null)
                    .GroupBy(x => x.SubjectID)
                    .Select(g => new
                    {
                        SubjectID = g.Key,
                        SubjectName = g.First().SubjectName,
                        Category = g.First().Category
                    })
                    .ToList();

                dataGridViewSubject.DataSource = subjectRows;
                FormatDataGridView(dataGridViewSubject);

                // ------- Fill Schedule Grid -------
                var scheduleRows = assessmentList
                    .Where(x => x.ScheduleID != null)
                    .Select(x => new
                    {
                        x.Day,
                        StartTime = x.StartTime?.ToString(@"hh\:mm"),
                        EndTime = x.EndTime?.ToString(@"hh\:mm"),
                        x.SubjectName,
                        x.TeacherName
                    }).Distinct().ToList();

                dataGridViewSchedule.DataSource = scheduleRows;
                FormatDataGridView(dataGridViewSchedule);

                // ------- Fill Payment Grid -------
                var paymentRows = assessmentList
                    .Where(x => x.PaymentId != null)
                    .GroupBy(x => x.PaymentId) // Group by PaymentId to remove duplicates
                    .Select(g => new
                    {
                        PaymentId = g.Key,
                        AmountPaid = g.First().AmountPaid,
                        DatePaid = g.First().DatePaid?.ToString("yyyy-MM-dd"),
                        PaymentType = g.First().PaymentType
                    })
                    .ToList();

                dataGridViewPayment.DataSource = paymentRows;
                FormatDataGridView(dataGridViewPayment);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student: {ex.Message}");
            }
        }

        /// <summary>
        /// Utility function to format DataGridView for clean display
        /// </summary>
        private void FormatDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoResizeColumns();
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.ValueType == typeof(decimal) || col.ValueType == typeof(int))
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                else
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
