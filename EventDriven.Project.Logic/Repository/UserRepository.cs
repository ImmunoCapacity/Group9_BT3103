using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using EventDriven.Project.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace EventDriven.Project.Logic.Repository
{
    internal class UserRepository
    {
        private readonly string CONNECTIONSTRING = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public UserModel ValidateUser(string Username, string Password, string role)//Form1 Validate User
        {

            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection Enroll = new SqlConnection(CONNECTIONSTRING))
                {

                    Enroll.Open();
                    string query = "SELECT * FROM [dbo].[tblUser] WHERE username = @username and userPassword = HASHBYTES('SHA2_256', @password) and Role=@role;";
                    Console.WriteLine(query);
                    SqlCommand command = new SqlCommand(query, Enroll);
                    command.Parameters.AddWithValue("@username", Username);
                    //command.Parameters.AddWithValue("@password", Password);
                    command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = Password;
                    command.Parameters.AddWithValue("@role", role);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count >= 1)
                    {
                        matchingUser = new UserModel
                        {
                            Id = Convert.ToInt32(table.Rows[0]["Id"]),
                            Username = Username,
                            Password = Password
                            
                        };
                        return matchingUser;


                    }
                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return null;

        }


        //trial
        public UserModel GetUserByUserId(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Username, Role FROM dbo.[User] WHERE Id = @UserId",
                    conn))
                {
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserModel
                            {
                                Id = (int)reader["Id"],
                                Username = reader["Username"].ToString(),
                                Role = reader["Role"].ToString()
                            };
                        }
                    }
                }

                throw new Exception("User does not exist");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

        public UserModel ValidateRole(string username, string role)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Username FROM dbo.[User] WHERE Username = @Username AND Role = @Role",
                    conn))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
                    cmd.Parameters.Add("@Role", SqlDbType.NVarChar, 50).Value = role;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserModel
                            {
                                Id = (int)reader["Id"],
                                Username = reader["Username"].ToString(),
                                Role = role
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
