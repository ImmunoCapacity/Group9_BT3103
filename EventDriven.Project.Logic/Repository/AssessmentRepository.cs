using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Repository
{
    public class AssessmentRepository
    {

        public async Task UpdateStudentStatusAsync(int studentId, string newStatus)
        {
            var query = @"UPDATE tblStudents
                  SET Status = @Status
                  WHERE Id = @StudentId";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    if (rowsAffected == 0)
                        throw new Exception("Update failed. No student found with the given ID.");
                }
            }
        }

        public async Task<List<StudentAssessment>> GetAssessmentAsync(int studentId)
        {
            var query = @"SELECT * FROM vwStudentAssessment WHERE StudentId = @StudentId";

            var list = new List<StudentAssessment>();

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(ReadAssessment(reader));
                        }
                    }
                }
            }

            return list;
        }
        public async Task<List<StudentAssessment>> GetAllAssessmentsAsync()
        {
            var query = @"SELECT * FROM vwStudentAssessment WHERE YearName IS NOT NULL
";

            var list = new List<StudentAssessment>();

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(ReadAssessment(reader));
                    }
                }
            }

            return list;
        }

        private StudentAssessment ReadAssessment(SqlDataReader r)
        {
            return new StudentAssessment
            {
                StudentId = r.GetInt32(r.GetOrdinal("StudentId")),
                FirstName = r["FirstName"].ToString(),
                MiddleName = r["MiddleName"] as string,
                LastName = r["LastName"].ToString(),
                GradeLevel = r["GradeLevel"].ToString(),
                StudentSection = r["StudentSection"] as string,
                GWA = r["GWA"] == DBNull.Value ? null : (decimal?)r["GWA"],
                Status = r["Status"].ToString(),

                RegistrationId = r["RegistrationId"] as int?,
                RegistrationSection = r["RegistrationSection"] as string,
                Requirements = r["Requirements"] as string,
                PaymentMethod = r["PaymentMethod"] as string,

                PaymentId = r["PaymentId"] as int?,
                AmountPaid = r["AmountPaid"] == DBNull.Value ? null : (decimal?)r["AmountPaid"],
                DatePaid = r["DatePaid"] == DBNull.Value ? null : (DateTime?)r["DatePaid"],
                PaymentType = r["PaymentType"] as string,

                SectionId = r["SectionId"] as int?,

                ScheduleID = r["ScheduleID"] as int?,
                StartTime = r["StartTime"] == DBNull.Value ? null : (TimeSpan?)r["StartTime"],
                EndTime = r["EndTime"] == DBNull.Value ? null : (TimeSpan?)r["EndTime"],
                Day = r["Day"] as string,

                TeacherID = r["TeacherID"] as int?,
                TeacherName = r["TeacherName"] as string,

                SubjectID = r["SubjectID"] as int?,
                SubjectName = r["SubjectName"] as string,
                Category = r["Category"] as string,
                yearId = r["YearId"] as int?,
                year = r["YearName"] as string
            };
        }
    }
}