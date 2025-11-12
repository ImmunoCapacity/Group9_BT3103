using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Repository
{
    internal class StudentRegistrationRepository
    {

        readonly string _connectionString = connect.connectionString;
        public async Task<RegistrationModel> AddAsync(RegistrationModel registration)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO tblStudentRegistration (StudentId, Section, Requirements, PaymentMethod)
                    OUTPUT INSERTED.Id
                    VALUES (@StudentId, @Section, @Requirements, @PaymentMethod)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", registration.StudentId);
                    cmd.Parameters.AddWithValue("@Section", registration.Section);
                    cmd.Parameters.AddWithValue("@Requirements", registration.Requirements);
                    cmd.Parameters.AddWithValue("@PaymentMethod", registration.PaymentMethod);

                    await conn.OpenAsync();
                    registration.Id = (int)await cmd.ExecuteScalarAsync();
                    return registration;
                }
            }
        }
        public async Task<RegistrationModel> UpsertAsync(RegistrationModel registration)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                // Check if record exists
                string checkQuery = "SELECT COUNT(*) FROM tblStudentRegistration WHERE StudentId = @Id";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Id", registration.StudentId);
                    int count = (int)await checkCmd.ExecuteScalarAsync();

                    if (count > 0)
                    {
                        // Record exists → update
                        string updateQuery = @"
                    UPDATE tblStudentRegistration
                    SET Section = @Section,
                        Requirements = @Requirements,
                        PaymentMethod = @PaymentMethod
                    WHERE StudentId = @Id";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Section", registration.Section);
                            updateCmd.Parameters.AddWithValue("@Requirements", registration.Requirements);
                            updateCmd.Parameters.AddWithValue("@PaymentMethod", registration.PaymentMethod);
                            updateCmd.Parameters.AddWithValue("@Id", registration.Id);

                            int rows = await updateCmd.ExecuteNonQueryAsync();
                            return rows > 0 ? registration : null;
                        }
                    }
                    else
                    {
                        // Record doesn’t exist → insert new
                        string insertQuery = @"
                    INSERT INTO tblStudentRegistration (StudentId, Section, Requirements, PaymentMethod)
                    OUTPUT INSERTED.Id
                    VALUES (@StudentId, @Section, @Requirements, @PaymentMethod)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@StudentId", registration.StudentId);
                            insertCmd.Parameters.AddWithValue("@Section", registration.Section);
                            insertCmd.Parameters.AddWithValue("@Requirements", registration.Requirements);
                            insertCmd.Parameters.AddWithValue("@PaymentMethod", registration.PaymentMethod);

                            registration.Id = (int)await insertCmd.ExecuteScalarAsync();
                            return registration;
                        }
                    }
                }
            }
        }


        public async Task<RegistrationModel> UpdateAsync(RegistrationModel registration)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE tblStudentRegistration
                    SET Section = @Section,
                        Requirements = @Requirements,
                        PaymentMethod = @PaymentMethod
                    WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Section", registration.Section);
                    cmd.Parameters.AddWithValue("@Requirements", registration.Requirements);
                    cmd.Parameters.AddWithValue("@PaymentMethod", registration.PaymentMethod);
                    cmd.Parameters.AddWithValue("@Id", registration.Id);

                    await conn.OpenAsync();
                    int rows = await cmd.ExecuteNonQueryAsync();
                    return rows > 0 ? registration : null;
                }
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM tblStudentRegistration WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    await conn.OpenAsync();
                    int rows = await cmd.ExecuteNonQueryAsync();
                    return rows > 0;
                }
            }
        }

        public async Task<RegistrationModel> GetByIdAsync(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM tblStudentRegistration WHERE StudentId = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new RegistrationModel
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

        public async Task<List<RegistrationModel>> GetAllAsync()
        {
            var list = new List<RegistrationModel>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM tblStudentRegistration";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new RegistrationModel
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