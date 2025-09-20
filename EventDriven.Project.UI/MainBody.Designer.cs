namespace EventDriven.Project.UI
{
    partial class MainBody
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnStudentReg = new Button();
            btnAssessment = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panelContainer = new Panel();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnStudentReg);
            flowLayoutPanel1.Controls.Add(btnAssessment);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Location = new Point(65, 96);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(351, 417);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnStudentReg
            // 
            btnStudentReg.Location = new Point(3, 3);
            btnStudentReg.Name = "btnStudentReg";
            btnStudentReg.Size = new Size(348, 75);
            btnStudentReg.TabIndex = 0;
            btnStudentReg.Text = "Student Registration";
            btnStudentReg.UseVisualStyleBackColor = true;
            btnStudentReg.Click += btnStudentReg_Click;
            // 
            // btnAssessment
            // 
            btnAssessment.Location = new Point(3, 84);
            btnAssessment.Name = "btnAssessment";
            btnAssessment.Size = new Size(348, 75);
            btnAssessment.TabIndex = 1;
            btnAssessment.Text = "Assessment";
            btnAssessment.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 165);
            button3.Name = "button3";
            button3.Size = new Size(348, 75);
            button3.TabIndex = 2;
            button3.Text = "Payment";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 246);
            button4.Name = "button4";
            button4.Size = new Size(348, 75);
            button4.TabIndex = 3;
            button4.Text = "Payment History";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 327);
            button5.Name = "button5";
            button5.Size = new Size(348, 75);
            button5.TabIndex = 4;
            button5.Text = "Reports";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(68, 669);
            button6.Name = "button6";
            button6.Size = new Size(348, 75);
            button6.TabIndex = 5;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(465, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1011, 829);
            panelContainer.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(103, 566);
            button1.Name = "button1";
            button1.Size = new Size(281, 29);
            button1.TabIndex = 7;
            button1.Text = "decrease button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainBody
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1482, 853);
            Controls.Add(button1);
            Controls.Add(panelContainer);
            Controls.Add(button6);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainBody";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "las";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnStudentReg;
        private Button btnAssessment;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panelContainer;
        private Button button1;
    }
}