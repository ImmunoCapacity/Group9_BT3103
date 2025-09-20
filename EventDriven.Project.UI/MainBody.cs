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
    public partial class MainBody : Form
    {
        MainForm main;
        public MainBody(string role, MainForm main)
        {
            this.main = main;

            InitializeComponent();
            this.Text = role + " Dashboard";
        }
        private void ShowControl(UserControl control)
        {
            //papaltan natin yung control ng panel sa user control bawt press ng btn
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panelContainer.Controls.Add(control);
        }

        private void btnStudentReg_Click(object sender, EventArgs e)
        {
            ShowControl(new FormStudentRegistration());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //example to, pag role ay admin kita lahat wala babawas, pero pag role ay cashier, di makikita yung student reg
            btnStudentReg.Visible = false;
        }
    }
}
