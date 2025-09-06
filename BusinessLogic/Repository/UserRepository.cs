using System.Data;
using System.Data.SqlClient;
using TestLog.Model;

namespace Repository
{
    internal class UserRepository
    {
         private string CONNECTIONSTRING = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EventDrivenProject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

          public UserModel ValidateUser(string Username, string Password)//Form1 Validate User
        {
            
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection Hotel = new SqlConnection(CONNECTIONSTRING))
                {
                    Hotel.Open();
                    string query = "SELECT * FROM dbo.[User] WHERE Username = @username AND Password = @password";
                    SqlCommand command = new SqlCommand(query, Hotel);
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@password", Password);
                    

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count >= 1)
                    {
                        matchingUser = new UserModel
                        {
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
        public UserModel getUserByUserId(string UserIdParam)
        {
            try { 
            UserModel matchingUser = new UserModel();
            using (SqlConnection myConnection = new SqlConnection(CONNECTIONSTRING))
            {
                string oString = "SELECT * FROM User WHERE Id = @userId";
                using (SqlCommand oCmd = new SqlCommand(oString, myConnection))
                {
                    oCmd.Parameters.AddWithValue("@UserId", UserIdParam);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            matchingUser.Id = (int)oReader["Id"];
                            matchingUser.Username = oReader["Username"].ToString();
                            matchingUser.Password = oReader["Password"].ToString();
                        }
                        myConnection.Close();

                    }
                }
                
            }
            
                if (matchingUser.Id == 0)
                {
                    throw new Exception("User does not exist");
                }

                return matchingUser;
            }
            
            catch (Exception ex)
            {
                
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

       
    }
}
        
    