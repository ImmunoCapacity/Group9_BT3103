using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Repository
{
    internal class StudentPayment
    {
        // INSERT payment
        public async Task<PaymentModel> InsertAsync(PaymentModel payment)
        {
            var query = @"INSERT INTO tblPayments
                          (StudentId, AmountPaid, DatePaid, PaymentType)
                          VALUES (@StudentId, @AmountPaid, @DatePaid, @PaymentType);
                          SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddParameters(command, payment);
                    int insertedId = (int)command.ExecuteScalar();
                    payment.Id = insertedId;
                }
            }

            return payment;
        }
        public async Task<List<StudentPaymentInfo>> GetAllStudentPayments()
        {
            var payments = new List<StudentPaymentInfo>();

            using (SqlConnection conn = new SqlConnection(connect.connectionString))
            {
                string query = "SELECT * FROM vwStudentPaymentBalance ORDER BY StudentName";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        payments.Add(new StudentPaymentInfo
                        {
                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            StudentName = reader["StudentName"].ToString(),
                            GradeLevel = reader["GradeLevel"].ToString(),
                            TuitionFee = Convert.ToDecimal(reader["TuitionFee"]),
                            TotalPaid = Convert.ToDecimal(reader["TotalPaid"]),
                            RemainingBalance = Convert.ToDecimal(reader["RemainingBalance"]),
                            LastPaymentDate = reader["LastPaymentDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["LastPaymentDate"]),
                            LastPaymentType = reader["LastPaymentType"] == DBNull.Value ? "" : reader["LastPaymentType"].ToString()
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


        // Helper method to add parameters
        private void AddParameters(SqlCommand command, PaymentModel payment)
        {
            command.Parameters.AddWithValue("@StudentId", payment.StudentId);
            command.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
            command.Parameters.AddWithValue("@DatePaid", payment.DatePaid ?? DateTime.Now);
            command.Parameters.AddWithValue("@PaymentType", payment.PaymentType ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@RemainingBalance", payment.RemainingBalance ?? (object)DBNull.Value);
        }

        // Helper method to read payment from SqlDataReader
        private PaymentModel ReadPayment(SqlDataReader reader)
        {
            return new PaymentModel
            {
                Id = reader.GetInt32(0),
                StudentId = reader.GetInt32(1),
                AmountPaid = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                DatePaid = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                PaymentType = reader.IsDBNull(4) ? null : reader.GetString(4)
            };
        }
    }
}
