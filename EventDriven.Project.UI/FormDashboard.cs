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
    public partial class FormDashboard : Form
    {
        MainForm main;
        string role;
        public FormDashboard(string role, MainForm main)
        {
            this.main = main;
            this.role = role;

            MaximizeBox = false;
            MinimizeBox = false;

            InitializeComponent();
            this.Text = role + " Dashboard";
            visibleRole(role);
        }
        private void ShowControl(UserControl control)
        {
            //papaltan natin yung control ng panel sa user control bawt press ng btn
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;   // ✅ makes UserControl scale
            panel2.Controls.Add(control);
        }

        private void btnStudentReg_Click(object sender, EventArgs e)
        {
            highlightButton(sender as Button);
            ShowControl(new UserControlStudentInfo(role, main));

            StudentInfoList studentInfoList = new StudentInfoList();
            studentInfoList.TopLevel = false;
            panel2.Controls.Add(studentInfoList);
            studentInfoList.BringToFront();
            studentInfoList.Show();
        }

        private void visibleRole(string role)
        {
            btnStudentInfo.Visible = true;
            btnHistory.Visible = true;
            btnStudentReg.Visible = true;
            btnPayments.Visible = true;
            btnAssessment.Visible = true;
            btnReports.Visible = true;
            if (role.Equals("Registrar"))
            {
                btnHistory.Visible = false;
                btnPayments.Visible = false;
            }
            else if (role.Equals("Cashier"))
            {
                btnStudentReg.Visible = false;
                btnAssessment.Visible = false;
            }
        }
        private void highlightButton(Button selected)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Reset all buttons to default
                    btn.BackColor = flowLayoutPanel1.BackColor;
                    btn.ForeColor = Color.FromArgb(64, 64, 64);
                    btn.FlatAppearance.BorderColor = Color.Firebrick;
                    btn.UseVisualStyleBackColor = true;
                }
            }

            if (selected != null)
            {
                // Highlight the clicked button
                selected.BackColor = Color.LightGray;
                selected.ForeColor = Color.Firebrick;
                selected.FlatAppearance.BorderColor = Color.Firebrick;
                selected.UseVisualStyleBackColor = false;
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            highlightButton(sender as Button);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            highlightButton(sender as Button);
        }

        private void btnStudentReg_Click_1(object sender, EventArgs e)
        {
            highlightButton(sender as Button);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            highlightButton(sender as Button);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            highlightButton(sender as Button);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            highlightButton(sender as Button);
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            highlightButton(sender as Button);
        }

        private void btnAdminDashboardLogout_Click(object sender, EventArgs e)
        {
            main.OpenChildForm(new FormUserRoles(main));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentInfo addStudentInfo = new AddStudentInfo();
            addStudentInfo.ShowDialog();
        }
    }
}
