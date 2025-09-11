using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;
using System.Xml.Linq;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {
        MainForm main;
        UserController userController;
        string role;
        public FormLogin(string Role, MainForm main)
        {
            role = Role;
            this.main = main;
            InitializeComponent();
            lblLogin.Text = Role + " Login";
            TBPassword.UseSystemPasswordChar = true;
            userController = new UserController();


        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            main.OpenChildForm(new FormUserRoles(main));
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel matchingUser = userController.ValidateUser(TBUsername.Text, TBPassword.Text, role);

                if (matchingUser != null)
                {
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
            if (TBPassword.UseSystemPasswordChar)
            {
                TBPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TBPassword.UseSystemPasswordChar = true;
            }
        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
