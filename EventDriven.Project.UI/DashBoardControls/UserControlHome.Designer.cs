namespace EventDriven.Project.UI.DashBoardControls
{
    partial class UserControlHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblUnpaid = new Label();
            lblPaid = new Label();
            lblEnrolled = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            lblPending = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(lblUnpaid);
            panel1.Controls.Add(lblPaid);
            panel1.Controls.Add(lblPending);
            panel1.Controls.Add(lblEnrolled);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 125);
            panel1.TabIndex = 0;
            // 
            // lblUnpaid
            // 
            lblUnpaid.AutoSize = true;
            lblUnpaid.Font = new Font("Sitka Text", 18F, FontStyle.Bold);
            lblUnpaid.Location = new Point(1206, 42);
            lblUnpaid.Name = "lblUnpaid";
            lblUnpaid.Size = new Size(38, 43);
            lblUnpaid.TabIndex = 7;
            lblUnpaid.Text = "0";
            lblUnpaid.Click += lblUnpaid_Click;
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Sitka Text", 18F, FontStyle.Bold);
            lblPaid.Location = new Point(818, 42);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(38, 43);
            lblPaid.TabIndex = 5;
            lblPaid.Text = "0";
            // 
            // lblEnrolled
            // 
            lblEnrolled.AutoSize = true;
            lblEnrolled.Font = new Font("Sitka Text", 18F, FontStyle.Bold);
            lblEnrolled.Location = new Point(43, 42);
            lblEnrolled.Name = "lblEnrolled";
            lblEnrolled.Size = new Size(38, 43);
            lblEnrolled.TabIndex = 1;
            lblEnrolled.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1470, 835);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1470, 835);
            dataGridView1.TabIndex = 0;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Sitka Text", 18F, FontStyle.Bold);
            lblPending.Location = new Point(410, 42);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(38, 43);
            lblPending.TabIndex = 3;
            lblPending.Text = "0";
            // 
            // UserControlHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlHome";
            Size = new Size(1470, 960);
            Load += UserControlHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label lblUnpaid;
        private Label lblPaid;
        private Label lblEnrolled;
        private Label lblPending;
    }
}
