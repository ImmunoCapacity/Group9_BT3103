using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class FormUserRoles : Form
    {
        MainForm main;
        public FormUserRoles(MainForm main)
        {
            this.main = main;
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            main.OpenChildForm(new FormLogin("Admin", main));
        }

        private void Cashierbtn_Click(object sender, EventArgs e)
        {
            main.OpenChildForm(new FormLogin("Cashier", main));
        }

        private void Regstrarbtn_Click(object sender, EventArgs e)
        {
            main.OpenChildForm(new FormLogin("Registrar", main));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
