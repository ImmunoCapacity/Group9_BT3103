using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class StudentRepository
    {
        

        // INSERT student
        public async Task<StudentModel> InsertAsync(StudentModel student)
        {
            var query = @"INSERT INTO tblStudents
                          (FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
                           FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
                           GuardianName, GuardianRelationship, GuardianContact, GuardianAddress,
                           Suffix, Section, Gender, Email, LastSchool, LastGrade, Address, Contact, GWA)
                          VALUES
                          (@FirstName, @MiddleName, @LastName, @Status, @BirthDate, @GradeLevel, @Nationality,
                           @FatherName, @FatherContact, @MotherName, @MotherContact, @ParentAddress,
                           @GuardianName, @GuardianRelationship, @GuardianContact, @GuardianAddress,
                           @Suffix, @Section, @Gender, @Email, @LastSchool, @LastGrade, @Address, @Contact, @GWA);
                          SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddParameters(command, student);
                    int insertedId = (int)command.ExecuteScalar();
                    student.Id = insertedId;
                }
            }

            return student;
        }

        // UPDATE student
        public async Task<StudentModel> UpdateAsync(StudentModel student)
        {
            var query = @"UPDATE tblStudents SET
                          FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Status=@Status,
                          BirthDate=@BirthDate, GradeLevel=@GradeLevel, Nationality=@Nationality,
                          FatherName=@FatherName, FatherContact=@FatherContact, MotherName=@MotherName,
                          MotherContact=@MotherContact, ParentAddress=@ParentAddress,
                          GuardianName=@GuardianName, GuardianRelationship=@GuardianRelationship,
                          GuardianContact=@GuardianContact, GuardianAddress=@GuardianAddress,
                          Suffix=@Suffix, Section=@Section, Gender=@Gender, Email=@Email,
                          LastSchool=@LastSchool, LastGrade=@LastGrade, Address=@Address, Contact=@Contact, GWA=@GWA
                          WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", student.Id);
                    AddParameters(command, student);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Update failed. No student found with the given ID.");
                }
            }

            return await GetByIdAsync(student.Id);
        }

        // DELETE student
        public async Task<StudentModel> DeleteAsync(int id)
        {
            var studentToDelete = GetByIdAsync(id);
            var query = "DELETE FROM tblStudents WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Delete failed. No student found with the given ID.");
                }
            }

            return await studentToDelete;
        }

        // GET all students
        public async Task<List<StudentModel>> GetAllAsync()
        {
            var query = @"SELECT Id, FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
                                 FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
                                 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress,
                                 Suffix, Section, Gender, Email, LastSchool, LastGrade, Address, Contact, Gwa
                          FROM tblStudents";

            var list = new List<StudentModel>();
            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(ReadStudent(reader));
                    }
                }
            }

            return list;
        }

        // GET student by Id
        public async Task<StudentModel> GetByIdAsync(int id)
        {
            var query = @"SELECT Id, FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
                         FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
                         GuardianName, GuardianRelationship, GuardianContact, GuardianAddress,
                         Suffix, Section, Gender, Email, LastSchool, LastGrade, Address, Contact, GWA
                  FROM tblStudents
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
                            return ReadStudent(reader);
                        else
                            throw new Exception("No student found with the given ID.");
                    }
                }
            }
        }


        // COUNT students
        public async Task<int> GetCountAsync()
        {
            var query = "SELECT COUNT(*) FROM tblStudents";
            using (SqlConnection connection = new SqlConnection(connect.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        // Helper method to map parameters
        private void AddParameters(SqlCommand command, StudentModel student)
        {
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@MiddleName", student.MiddleName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@Status", student.Status);
            command.Parameters.AddWithValue("@BirthDate", student.BirthDate);
            command.Parameters.AddWithValue("@GradeLevel", student.GradeLevel);
            command.Parameters.AddWithValue("@Nationality", student.Nationality ?? (object)DBNull.Value);

            command.Parameters.AddWithValue("@FatherName", student.FatherName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@FatherContact", student.FatherContact ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@MotherName", student.MotherName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@MotherContact", student.MotherContact ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ParentAddress", student.ParentAddress ?? (object)DBNull.Value);

            command.Parameters.AddWithValue("@GuardianName", student.GuardianName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@GuardianRelationship", student.GuardianRelationship ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@GuardianContact", student.GuardianContact ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@GuardianAddress", student.GuardianAddress ?? (object)DBNull.Value);

            // New fields
            command.Parameters.AddWithValue("@Suffix", student.Suffix ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Section", student.Section ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Gender", student.Gender ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Email", student.Email ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastSchool", student.LastSchool ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastGrade", student.LastGrade ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Address", student.Address ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Contact", student.Contact ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@GWA", student.GWA ?? (object)DBNull.Value);

        }

        // Helper method to read student from SqlDataReader
        private StudentModel ReadStudent(SqlDataReader reader)
        {
            return new StudentModel
            {
                Id = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                MiddleName = reader.IsDBNull(2) ? null : reader.GetString(2),
                LastName = reader.GetString(3),
                Status = reader.GetString(4),
                BirthDate = reader.GetDateTime(5),
                GradeLevel = reader.GetString(6),
                Nationality = reader.IsDBNull(7) ? null : reader.GetString(7),
                FatherName = reader.IsDBNull(8) ? null : reader.GetString(8),
                FatherContact = reader.IsDBNull(9) ? null : reader.GetString(9),
                MotherName = reader.IsDBNull(10) ? null : reader.GetString(10),
                MotherContact = reader.IsDBNull(11) ? null : reader.GetString(11),
                ParentAddress = reader.IsDBNull(12) ? null : reader.GetString(12),
                GuardianName = reader.IsDBNull(13) ? null : reader.GetString(13),
                GuardianRelationship = reader.IsDBNull(14) ? null : reader.GetString(14),
                GuardianContact = reader.IsDBNull(15) ? null : reader.GetString(15),
                GuardianAddress = reader.IsDBNull(16) ? null : reader.GetString(16),
                Suffix = reader.IsDBNull(17) ? null : reader.GetString(17),
                Section = reader.IsDBNull(18) ? null : reader.GetString(18),
                Gender = reader.IsDBNull(19) ? null : reader.GetString(19),
                Email = reader.IsDBNull(20) ? null : reader.GetString(20),
                LastSchool = reader.IsDBNull(21) ? null : reader.GetString(21),
                LastGrade = reader.IsDBNull(22) ? null : reader.GetString(22),
                Address = reader.IsDBNull(23) ? null : reader.GetString(23),
                Contact = reader.IsDBNull(24) ? null : reader.GetString(24),
                GWA = reader.IsDBNull(25) ? null : reader.GetDecimal(25)


            };
        }
    }
}
