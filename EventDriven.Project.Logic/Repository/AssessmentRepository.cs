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

        public async Task UpdateStudentStatusAsync(int studentId, string requirement, string enrollment)
        {
            var query = @"UPDATE tblStudents
                  SET AssessmentStatus = @requirement,
                      EnrollmentStatus = @enrollment
                  WHERE Id = @StudentId";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@requirement", requirement);
                    command.Parameters.AddWithValue("@enrollment", enrollment);
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
            var query = @"SELECT * FROM vwStudentAssessment WHERE YearName IS NOT NULL";

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


        public async Task<List<StudentAssessment>> GetSectionGradeYear()
        {
            var query = @"SELECT DISTINCT SectionName, GradeLevel, YearName 
                  FROM vwStudentAssessment 
                  ORDER BY SectionName, GradeLevel, YearName";

            var list = new List<StudentAssessment>();

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                await connection.OpenAsync(); // use async

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(ReadAssessment2(reader));
                    }
                }
            }

            return list;
        }

        // Fixed ReadAssessment for the query
        private StudentAssessment ReadAssessment2(SqlDataReader r)
        {
            return new StudentAssessment
            {
                StudentSection = r["SectionName"] as string,
                GradeLevel = r["GradeLevel"] as string,
                year = r["YearName"] as string
            };
        }

        public async Task<List<StudentAssessment>> GetAllEnrolledAsync()
        {
            var query = @"SELECT * FROM tblStudents 
                  WHERE EnrollmentStatus = 'Enrolled'";

            var list = new List<StudentAssessment>();

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(ReadAssessment(reader));
                    }
                }
            }

            return list;
        }

        public async Task<int> getNumberofEnrolledStudents()
        {
            var query = @"SELECT Count(*) FROM tblStudents 
                  WHERE EnrollmentStatus = 'Enrolled'";

            int enrolled;

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                     enrolled = (int)await command.ExecuteScalarAsync();
                }
            }
            return enrolled;
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
                AssessmentStatus = r["AssessmentStatus"].ToString(),
                EnrollmentStatus = r["EnrollmentStatus"].ToString(),


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