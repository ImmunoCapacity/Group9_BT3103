
using System.Data;
using System.Data.SqlClient;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;
//using Func;

namespace EventDriven.Project.UI
{
    public partial class TempLogin : Form
    {
        private string CONNECTIONSTRING = "Data Source=.\\SQLEXPRESS;Initial Catalog=myLogTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        //private string CONNECTIONSTRING = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=myLogTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        UserController userController;
        public TempLogin()
        {
            InitializeComponent();
            userController = new UserController();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel matchingUser = userController.ValidateUser(TBName.Text, TBPassword.Text);

                if (matchingUser != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); ;
                }
                else throw new Exception("Invalid Credentials");

                //UserModel matchingUser = new UserModel();
                //using (SqlConnection Hotel = new SqlConnection(CONNECTIONSTRING))
                //{
                //    Hotel.Open();
                //    string query = "SELECT * FROM dbo.[User] WHERE name ='" + TBName.Text + "'AND password ='" + TBPassword.Text + "'";
                //    SqlCommand command = new SqlCommand(query, Hotel);


                //    SqlDataAdapter adapter = new SqlDataAdapter(command);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    if (table.Rows.Count >= 1)
                //    {
                //        this.DialogResult = DialogResult.OK;
                //        this.Close(); ;


                //    }
                //    else { MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                //}
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message + "hi error");
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
    