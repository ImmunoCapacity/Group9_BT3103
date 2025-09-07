
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
            TBPassword.UseSystemPasswordChar = true;
            this.KeyPreview = true;

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
                //using (SqlConnection Enroll = new SqlConnection(CONNECTIONSTRING))
                //{
                //    Enroll.Open();
                //    string query = "SELECT * FROM dbo.[User] WHERE name ='" + TBName.Text + "'AND password ='" + TBPassword.Text + "'";
                //    SqlCommand command = new SqlCommand(query, Enroll);


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

        private void CBSeePW_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSeePW.Checked)
            {
                TBPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TBPassword.UseSystemPasswordChar = true;
            }
        }
        private void TBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the next control
                this.SelectNextControl((Control)sender, true, true, true, true);

                // Prevent the "ding" sound
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

      
        private void TempLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(this.ActiveControl is TextBox))
                return;

            bool forward = e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right;
            bool backward = e.KeyCode == Keys.Up || e.KeyCode == Keys.Left;

            if (forward || backward)
            {
                e.SuppressKeyPress = true; // prevent system beep
                e.Handled = true;

                // Move focus safely
                this.SelectNextControl(this.ActiveControl, forward, true, true, true);


            }
        }
    }
}
    