namespace EventDriven.Project.UI
{
    public partial class UserRoles : Form
    {
        public UserRoles()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Cashierbtn_Click(object sender, EventArgs e)
        {

        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            AdminLogIn adminlogin = new AdminLogIn();
            adminlogin.Show();
            this.Close();
        }
    }
}
