namespace EventDriven.Project.UI
{
    partial class AddStudentInfo
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
            btnAdd = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(261, 479);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 33);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(484, 479);
            button1.Name = "button1";
            button1.Size = new Size(144, 33);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 524);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Name = "AddStudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button button1;
    }
}