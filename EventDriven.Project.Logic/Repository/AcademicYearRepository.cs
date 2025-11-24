using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Repository
{
    internal class AcademicYearRepository
    {
        private readonly string _connectionString = connect.connectionString;

        // Add a new academic year
        public async Task<AcademicYearModel> AddAsync(AcademicYearModel year)
        {
            string query = @"
                INSERT INTO tblAcademicYear (YearName, StartDate, EndDate, IsActive)
                OUTPUT INSERTED.Id
                VALUES (@YearName, @StartDate, @EndDate, @IsActive)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@YearName", year.YearName);
                cmd.Parameters.AddWithValue("@StartDate", year.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", year.EndDate);
                cmd.Parameters.AddWithValue("@IsActive", year.IsActive);

                await conn.OpenAsync();
                year.Id = (int)await cmd.ExecuteScalarAsync();
                await SetActiveYearAsync(year.Id);
                return year;
            }
        }



        // Update an existing academic year
        public async Task<AcademicYearModel> UpdateAsync(AcademicYearModel year)
        {
            string query = @"
                UPDATE tblAcademicYear
                SET YearName = @YearName,
                    StartDate = @StartDate,
                    EndDate = @EndDate,
                    IsActive = @IsActive
                WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@YearName", year.YearName);
                cmd.Parameters.AddWithValue("@StartDate", year.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", year.EndDate);
                cmd.Parameters.AddWithValue("@IsActive", year.IsActive);
                cmd.Parameters.AddWithValue("@Id", year.Id);

                await conn.OpenAsync();
                int rows = await cmd.ExecuteNonQueryAsync();

                return rows > 0 ? year : null;
            }
        }

        // Get by ID
        public async Task<AcademicYearModel> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM tblAcademicYear WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new AcademicYearModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            YearName = reader["YearName"].ToString(),
                            StartDate = (DateTime)reader["StartDate"],
                            EndDate = (DateTime)reader["EndDate"],
                            IsActive = (bool)reader["IsActive"]
                        };
                    }
                }
            }
            return null;
        }

        // Get all academic years
        public async Task<List<AcademicYearModel>> GetAllAsync()
        {
            var list = new List<AcademicYearModel>();

            string query = "SELECT * FROM tblAcademicYear ORDER BY StartDate DESC";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                await conn.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new AcademicYearModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            YearName = reader["YearName"].ToString(),
                            StartDate = (DateTime)reader["StartDate"],
                            EndDate = (DateTime)reader["EndDate"],
                            IsActive = (bool)reader["IsActive"]
                        });
                    }
                }
            }

            return list;
        }

        // Set active academic year (only one active at a time)
        public async Task<bool> SetActiveYearAsync(int yearId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Deactivate all
                        string deactivateQuery = "UPDATE tblAcademicYear SET IsActive = 0";
                        using (var deactivateCmd = new SqlCommand(deactivateQuery, conn, transaction))
                        {
                            await deactivateCmd.ExecuteNonQueryAsync();
                        }

                        // Activate selected one
                        string activateQuery = "UPDATE tblAcademicYear SET IsActive = 1 WHERE Id = @Id";
                        using (var activateCmd = new SqlCommand(activateQuery, conn, transaction))
                        {
                            activateCmd.Parameters.AddWithValue("@Id", yearId);
                            int rows = await activateCmd.ExecuteNonQueryAsync();

                            transaction.Commit();
                            return rows > 0;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // Get active academic year
        public async Task<AcademicYearModel> GetActiveYearAsync()
        {
            string query = "SELECT * FROM tblAcademicYear WHERE IsActive = 1";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new AcademicYearModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            YearName = reader["YearName"].ToString(),
                            StartDate = (DateTime)reader["StartDate"],
                            EndDate = (DateTime)reader["EndDate"],
                            IsActive = (bool)reader["IsActive"]
                        };
                    }
                }
            }

            return null;
        }
    }
}
