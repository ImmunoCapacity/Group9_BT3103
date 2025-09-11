using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AutoScroll = false;
            //this.scrollBars
            OpenChildForm(new FormUserRoles(this));
        }

        public void OpenChildForm(Form childForm)
        {
            // Close any existing child forms
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            // Set the new child form's properties and show it
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.Text = childForm.Text;
            childForm.Show();
            this.ClientSize = childForm.Size;
            childForm.Dock = DockStyle.Fill;
            SystemSounds.Beep.Play();
        }
    }
}
