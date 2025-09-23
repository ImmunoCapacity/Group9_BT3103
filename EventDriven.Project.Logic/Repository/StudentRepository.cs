using EventDriven.Project.Model;
using System.Data.SqlClient;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class StudentRepository
    {
        // Define connection string
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        // INSERT student
        public int Insert(StudentModel student)
        {
            var query = @"INSERT INTO dbo.Students
                          (FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
                           FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
                           GuardianName, GuardianRelationship, GuardianContact, GuardianAddress)
                          VALUES
                          (@FirstName, @MiddleName, @LastName, @Status, @BirthDate, @GradeLevel, @Nationality,
                           @FatherName, @FatherContact, @MotherName, @MotherContact, @ParentAddress,
                           @GuardianName, @GuardianRelationship, @GuardianContact, @GuardianAddress)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@MiddleName", student.MiddleName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Status", student.Status);
                    command.Parameters.AddWithValue("@BirthDate", student.BirthDate);
                    command.Parameters.AddWithValue("@GradeLevel", student.GradeLevel);
                    command.Parameters.AddWithValue("@Nationality", student.Nationality);

                    command.Parameters.AddWithValue("@FatherName", student.FatherName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@FatherContact", student.FatherContact ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@MotherName", student.MotherName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@MotherContact", student.MotherContact ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ParentAddress", student.ParentAddress ?? (object)DBNull.Value);

                    command.Parameters.AddWithValue("@GuardianName", student.GuardianName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GuardianRelationship", student.GuardianRelationship ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GuardianContact", student.GuardianContact ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GuardianAddress", student.GuardianAddress ?? (object)DBNull.Value);

                    return command.ExecuteNonQuery();
                }
            }
        }

        // GET all students
        public List<StudentModel> GetAll()
        {
            var query = @"SELECT Id, FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
                                 FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
                                 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress
                          FROM dbo.Students";

            var list = new List<StudentModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var student = new StudentModel
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            MiddleName = reader.IsDBNull(2) ? null : reader.GetString(2),
                            LastName = reader.GetString(3),
                            Status = reader.GetString(4),
                            BirthDate = reader.GetDateTime(5),
                            GradeLevel = reader.GetString(6),
                            Nationality = reader.GetString(7),

                            FatherName = reader.IsDBNull(8) ? null : reader.GetString(8),
                            FatherContact = reader.IsDBNull(9) ? null : reader.GetString(9),
                            MotherName = reader.IsDBNull(10) ? null : reader.GetString(10),
                            MotherContact = reader.IsDBNull(11) ? null : reader.GetString(11),
                            ParentAddress = reader.IsDBNull(12) ? null : reader.GetString(12),

                            GuardianName = reader.IsDBNull(13) ? null : reader.GetString(13),
                            GuardianRelationship = reader.IsDBNull(14) ? null : reader.GetString(14),
                            GuardianContact = reader.IsDBNull(15) ? null : reader.GetString(15),
                            GuardianAddress = reader.IsDBNull(16) ? null : reader.GetString(16)
                        };

                        list.Add(student);
                    }
                }
            }
            return list;
        }

        // GET student by Id
        public StudentModel GetById(int id)
        {
            var query = @"SELECT Id, FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
                                 FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
                                 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress
                          FROM dbo.Students
                          WHERE Id = @id";

            var student = new StudentModel();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student.Id = reader.GetInt32(0);
                            student.FirstName = reader.GetString(1);
                            student.MiddleName = reader.IsDBNull(2) ? null : reader.GetString(2);
                            student.LastName = reader.GetString(3);
                            student.Status = reader.GetString(4);
                            student.BirthDate = reader.GetDateTime(5);
                            student.GradeLevel = reader.GetString(6);
                            student.Nationality = reader.GetString(7);

                            student.FatherName = reader.IsDBNull(8) ? null : reader.GetString(8);
                            student.FatherContact = reader.IsDBNull(9) ? null : reader.GetString(9);
                            student.MotherName = reader.IsDBNull(10) ? null : reader.GetString(10);
                            student.MotherContact = reader.IsDBNull(11) ? null : reader.GetString(11);
                            student.ParentAddress = reader.IsDBNull(12) ? null : reader.GetString(12);

                            student.GuardianName = reader.IsDBNull(13) ? null : reader.GetString(13);
                            student.GuardianRelationship = reader.IsDBNull(14) ? null : reader.GetString(14);
                            student.GuardianContact = reader.IsDBNull(15) ? null : reader.GetString(15);
                            student.GuardianAddress = reader.IsDBNull(16) ? null : reader.GetString(16);
                        }
                        else
                        {
                            throw new Exception("No student found.");
                        }
                    }
                }
            }
            return student;
        }

        // COUNT students
        public int GetCount()
        {
            var query = "SELECT COUNT(*) FROM dbo.Students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
}
