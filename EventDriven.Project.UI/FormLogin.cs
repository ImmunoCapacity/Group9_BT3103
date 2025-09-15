
using System.Windows.Forms;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {
        #region
        MainForm main;
        UserController userController;
        string role;
        byte attempt = 0;
        private static bool isLocked = false;
        private System.Windows.Forms.Timer resetTimer;
        #endregion
        public FormLogin(string Role, MainForm main)
        {
            role = Role;
            this.main = main;
            InitializeComponent();
            lblLogin.Text = Role + " Login";
            TBPassword.UseSystemPasswordChar = true;
            userController = new UserController();

            resetTimer = new System.Windows.Forms.Timer();
            resetTimer.Interval = 180000;
            resetTimer.Tick += ResetAttempts;
            resetTimer.Stop();


        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            main.OpenChildForm(new FormUserRoles(main));
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

            attempt++;
            if (isLocked)
            {
                MessageBox.Show("Too many failed attempts. Please wait to try again");
                return;

            }
            if (attempt > 3)
            {
                MessageBox.Show("Too many failed attempts. Please Try Again later.");
                isLocked = true;
                resetTimer.Start();
                return;
            }

            try
            {
                UserModel matchingUser = userController.ValidateUser(TBUsername.Text, TBPassword.Text, role);
                if (matchingUser != null)
                {
                    attempt = 0;
                    main.OpenChildForm(new TempLoggedIn(role));
                }
                else throw new Exception("Invalid Credentials");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message + "error");
            }
        }


        private void showBtn_Click(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = !TBPassword.UseSystemPasswordChar;
        }
        private void ResetAttempts(object sender, EventArgs e)
        {
            attempt = 0;
            isLocked = false;
            resetTimer.Stop();
            MessageBox.Show("You can try logging in again.");
        }
    }
}
