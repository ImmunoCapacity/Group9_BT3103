using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Repository
{
    internal class StudentPaymentRepository
    {
        // INSERT payment
        public async Task<PaymentModel> InsertAsync(PaymentModel payment)
        {
            var queryPayment = @"
        INSERT INTO tblPayments
        (StudentId, AmountPaid, Change, DatePaid, PaymentType)
        VALUES (@StudentId, @AmountPaid, @Change, @DatePaid, @PaymentType);
        SELECT CAST(SCOPE_IDENTITY() AS INT);";

            var queryGetNextSchedule = @"
        SELECT TOP 1 Id
        FROM tblPaymentSchedule
        WHERE StudentId = @StudentId AND IsPaid = 0
        ORDER BY DueDate ASC;";

            var queryUpdateSchedule = @"
        UPDATE tblPaymentSchedule
        SET IsPaid = 1
        WHERE Id = @ScheduleId;
    ";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                await connection.OpenAsync();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int paymentId;

                    // 1️⃣ Insert payment
                    using (SqlCommand cmd = new SqlCommand(queryPayment, connection, transaction))
                    {
                        AddParameters(cmd, payment);
                        paymentId = (int)await cmd.ExecuteScalarAsync();
                    }

                    payment.Id = paymentId;

                    // 2️⃣ Get the next unpaid schedule
                    int? scheduleId = null;

                    using (SqlCommand cmd = new SqlCommand(queryGetNextSchedule, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", payment.StudentId);
                        var result = await cmd.ExecuteScalarAsync();
                        if (result != null && result != DBNull.Value)
                            scheduleId = Convert.ToInt32(result);
                    }

                    // 3️⃣ If schedule exists, update it
                    if (scheduleId.HasValue)
                    {
                        using (SqlCommand cmd = new SqlCommand(queryUpdateSchedule, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ScheduleId", scheduleId.Value);
                            await cmd.ExecuteNonQueryAsync();
                        }
                    }

                    // 4️⃣ Commit everything
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }

            return payment;
        }

        public async Task<List<StudentPaymentInfo>> GetAllStudentPayments()
        {
            var payments = new List<StudentPaymentInfo>();

            using (SqlConnection conn = new SqlConnection(connect.connectionString))
            {
                string query = @"SELECT 
            
                            StudentId,
                            StudentName,
                            GradeLevel,
                            TuitionFee,
                            TotalPaid,
                            RemainingBalance,
                            LastPaymentDate,
                            LastPaymentType,
                            PaymentMethod,
                            NextDueDate,
                            NextAmountDue,
                            NextScheduleDescription
                         FROM vwStudentPaymentBalance
                         ORDER BY StudentName";

                SqlCommand cmd = new SqlCommand(query, conn);

                await conn.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        payments.Add(new StudentPaymentInfo
                        {
                            StudentId = reader.GetInt32(reader.GetOrdinal("StudentId")),
                            StudentName = reader["StudentName"].ToString(),
                            GradeLevel = reader["GradeLevel"].ToString(),

                            TuitionFee = reader.GetDecimal(reader.GetOrdinal("TuitionFee")),
                            TotalPaid = reader.GetDecimal(reader.GetOrdinal("TotalPaid")),
                            RemainingBalance = reader.GetDecimal(reader.GetOrdinal("RemainingBalance")),

                            LastPaymentDate = reader["LastPaymentDate"] == DBNull.Value
                                                ? null
                                                : (DateTime?)reader.GetDateTime(reader.GetOrdinal("LastPaymentDate")),

                            LastPaymentType = reader["LastPaymentType"] == DBNull.Value
                                                ? null
                                                : reader["LastPaymentType"].ToString(),

                            PaymentMethod = reader["PaymentMethod"] == DBNull.Value
                                                ? null
                                                : reader["PaymentMethod"].ToString(),

                            NextDueDate = reader["NextDueDate"] == DBNull.Value
                                                ? null
                                                : (DateTime?)reader.GetDateTime(reader.GetOrdinal("NextDueDate")),

                            NextAmountDue = reader["NextAmountDue"] == DBNull.Value
                                                ? null
                                                : (decimal?)reader.GetDecimal(reader.GetOrdinal("NextAmountDue")),

                            NextScheduleDescription = reader["NextScheduleDescription"] == DBNull.Value
                                                ? null
                                                : reader["NextScheduleDescription"].ToString()
                        });
                    }
                }
            }

            return payments;
        }

        public async Task<List<PaymentHistoryModel>> GetAllPayments()
        {
            var payments = new List<PaymentHistoryModel>();

            using (SqlConnection conn = new SqlConnection(connect.connectionString))
            {
                string query = "SELECT * FROM vwStudentPaymentHistory ORDER BY StudentName, DatePaid DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                await conn.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        payments.Add(new PaymentHistoryModel
                        {
                            PaymentId = Convert.ToInt32(reader["PaymentId"]),
                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            StudentName = reader["StudentName"].ToString(),
                            GradeLevel = reader["GradeLevel"].ToString(),
                            DatePaid = Convert.ToDateTime(reader["DatePaid"]),
                            PaymentType = reader["PaymentType"].ToString(),
                            AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                            RemainingBalance = Convert.ToDecimal(reader["RemainingBalance"])
                        });
                    }
                }
            }

            return payments;
        }


        // UPDATE payment


        // GET all payments
        public async Task<List<PaymentModel>> GetAllAsync()
        {
            var query = @"SELECT Id, StudentId, AmountPaid, DatePaid, PaymentType, RemainingBalance
                          FROM tblPayments";

            var list = new List<PaymentModel>();
            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(ReadPayment(reader));
                    }
                }
            }

            return list;
        }



        // GET payment by Id
        public async Task<PaymentModel> GetByIdAsync(int id)
        {
            var query = @"SELECT Id, StudentId, AmountPaid, DatePaid, PaymentType, RemainingBalance
                          FROM tblPayments
                          WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return ReadPayment(reader);
                        else
                            throw new Exception("No payment found with the given ID.");
                    }
                }
            }
        }

        public async Task<decimal> GetTotalPaidByStudentIdAsync(int studentId)
        {
            decimal totalPaid = 0;

            using (SqlConnection conn = new SqlConnection(connect.connectionString))
            {
                string query = @"SELECT ISNULL(SUM(AmountPaid), 0)
                         FROM tblPayments
                         WHERE StudentId = @StudentId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                await conn.OpenAsync();
                object result = await cmd.ExecuteScalarAsync();

                if (result != DBNull.Value)
                    totalPaid = Convert.ToDecimal(result);
            }

            return totalPaid;
        }

        public async Task<FeeStructure> GetFeeStructureAsync(string gradeLevel)
        {
            var query = @"
        SELECT Id, GradeLevel, BaseTuition, LabFee, LibraryFee, SportsFee, TuitionFee
        FROM tblFeeStructure
        WHERE GradeLevel = @GradeLevel
    ";

            using (SqlConnection conn = new SqlConnection(connect.connectionString))
            {
                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeLevel);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new FeeStructure
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                GradeLevel = reader["GradeLevel"].ToString(),
                                BaseTuition = reader.GetDecimal(reader.GetOrdinal("BaseTuition")),
                                LabFee = reader.GetDecimal(reader.GetOrdinal("LabFee")),
                                LibraryFee = reader.GetDecimal(reader.GetOrdinal("LibraryFee")),
                                SportsFee = reader.GetDecimal(reader.GetOrdinal("SportsFee")),
                                TuitionFee = reader.GetDecimal(reader.GetOrdinal("TuitionFee"))
                            };
                        }
                    }
                }
            }

            return null; // No matching grade level
        }



        // Helper method to add parameters
        private void AddParameters(SqlCommand command, PaymentModel payment)
        {
            command.Parameters.AddWithValue("@StudentId", payment.StudentId);
            command.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
            command.Parameters.AddWithValue("@Change", payment.Change);                // NEW
            command.Parameters.AddWithValue("@DatePaid", payment.DatePaid ?? DateTime.Now);
            command.Parameters.AddWithValue("@PaymentType", payment.PaymentType ?? (object)DBNull.Value);
        }


        // Helper method to read payment from SqlDataReader
        private PaymentModel ReadPayment(SqlDataReader reader)
        {
            return new PaymentModel
            {
                Id = reader.GetInt32(0),
                StudentId = reader.GetInt32(1),
                AmountPaid = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                Change = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),          // NEW
                DatePaid = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                PaymentType = reader.IsDBNull(5) ? null : reader.GetString(5)
            };
        }

    }
}
