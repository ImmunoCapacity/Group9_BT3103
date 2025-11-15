using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Repository
{
    internal class StudentAssessmentRepository
    {
        readonly string _connectionString = connect.connectionString;

        public async Task<AssessmentModel> AddAsync(AssessmentModel assessment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO tblStudentAssessment (StudentId, Section, Requirements, PaymentMethod)
                    OUTPUT INSERTED.Id
                    VALUES (@StudentId, @Section, @Requirements, @PaymentMethod)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", assessment.StudentId);
                    cmd.Parameters.AddWithValue("@Section", assessment.Section);
                    cmd.Parameters.AddWithValue("@Requirements", assessment.Requirements);
                    cmd.Parameters.AddWithValue("@PaymentMethod", assessment.PaymentMethod);

                    await conn.OpenAsync();
                    assessment.Id = (int)await cmd.ExecuteScalarAsync();
                    return assessment;
                }
            }
        }

        public async Task<AssessmentModel> UpsertAsync(AssessmentModel assessment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                // Check if record exists
                string checkQuery = "SELECT COUNT(*) FROM tblStudentAssessment WHERE StudentId = @Id";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Id", assessment.StudentId);
                    int count = (int)await checkCmd.ExecuteScalarAsync();

                    if (count > 0)
                    {
                        // Record exists → update
                        string updateQuery = @"
                    UPDATE tblStudentAssessment
                    SET Section = @Section,
                        Requirements = @Requirements,
                        PaymentMethod = @PaymentMethod
                    WHERE StudentId = @Id";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Section", assessment.Section);
                            updateCmd.Parameters.AddWithValue("@Requirements", assessment.Requirements);
                            updateCmd.Parameters.AddWithValue("@PaymentMethod", assessment.PaymentMethod);
                            updateCmd.Parameters.AddWithValue("@Id", assessment.Id);

                            int rows = await updateCmd.ExecuteNonQueryAsync();
                            return rows > 0 ? assessment : null;
                        }
                    }
                    else
                    {
                        // Record doesn’t exist → insert new
                        string insertQuery = @"
                    INSERT INTO tblStudentAssessment (StudentId, Section, Requirements, PaymentMethod)
                    OUTPUT INSERTED.Id
                    VALUES (@StudentId, @Section, @Requirements, @PaymentMethod)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@StudentId", assessment.StudentId);
                            insertCmd.Parameters.AddWithValue("@Section", assessment.Section);
                            insertCmd.Parameters.AddWithValue("@Requirements", assessment.Requirements);
                            insertCmd.Parameters.AddWithValue("@PaymentMethod", assessment.PaymentMethod);

                            assessment.Id = (int)await insertCmd.ExecuteScalarAsync();
                            return assessment;
                        }
                    }
                }
            }
        }

        public async Task<AssessmentModel> UpdateAsync(AssessmentModel assessment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE tblStudentAssessment
                    SET Section = @Section,
                        Requirements = @Requirements,
                        PaymentMethod = @PaymentMethod
                    WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Section", assessment.Section);
                    cmd.Parameters.AddWithValue("@Requirements", assessment.Requirements);
                    cmd.Parameters.AddWithValue("@PaymentMethod", assessment.PaymentMethod);
                    cmd.Parameters.AddWithValue("@Id", assessment.Id);

                    await conn.OpenAsync();
                    int rows = await cmd.ExecuteNonQueryAsync();
                    return rows > 0 ? assessment : null;
                }
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM tblStudentAssessment WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    await conn.OpenAsync();
                    int rows = await cmd.ExecuteNonQueryAsync();
                    return rows > 0;
                }
            }
        }

        public async Task<AssessmentModel> GetByIdAsync(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM tblStudentAssessment WHERE StudentId = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new AssessmentModel
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                StudentId = reader.GetInt32(reader.GetOrdinal("StudentId")),
                                Section = reader["Section"].ToString(),
                                Requirements = reader["Requirements"].ToString(),
                                PaymentMethod = reader["PaymentMethod"].ToString()
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public async Task<List<AssessmentModel>> GetAllAsync()
        {
            var list = new List<AssessmentModel>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM tblStudentAssessment";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new AssessmentModel
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                StudentId = reader.GetInt32(reader.GetOrdinal("StudentId")),
                                Section = reader["Section"].ToString(),
                                Requirements = reader["Requirements"].ToString(),
                                PaymentMethod = reader["PaymentMethod"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
