namespace EventDriven.Project.UI
{
    partial class TempLogin
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
            TBName = new TextBox();
            TBPassword = new TextBox();
            btnLogin = new Button();
            LbName = new Label();
            lbPass = new Label();
            CBSeePW = new CheckBox();
            SuspendLayout();
            // 
            // TBName
            // 
            TBName.Location = new Point(158, 71);
            TBName.Name = "TBName";
            TBName.Size = new Size(448, 27);
            TBName.TabIndex = 0;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(158, 137);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(448, 27);
            TBPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(334, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LbName
            // 
            LbName.AutoSize = true;
            LbName.Location = new Point(363, 48);
            LbName.Name = "LbName";
            LbName.Size = new Size(49, 20);
            LbName.TabIndex = 3;
            LbName.Text = "Name";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(363, 114);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(70, 20);
            lbPass.TabIndex = 4;
            lbPass.Text = "Password";
            // 
            // CBSeePW
            // 
            CBSeePW.AutoSize = true;
            CBSeePW.Location = new Point(324, 170);
            CBSeePW.Name = "CBSeePW";
            CBSeePW.Size = new Size(120, 24);
            CBSeePW.TabIndex = 5;
            CBSeePW.Text = "See Password";
            CBSeePW.UseVisualStyleBackColor = true;
            CBSeePW.CheckedChanged += CBSeePW_CheckedChanged;
            // 
            // TempLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CBSeePW);
            Controls.Add(lbPass);
            Controls.Add(LbName);
            Controls.Add(btnLogin);
            Controls.Add(TBPassword);
            Controls.Add(TBName);
            Name = "TempLogin";
            Text = "TempLogin";
            KeyDown += TempLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBName;
        private TextBox TBPassword;
        private Button btnLogin;
        private Label LbName;
        private Label lbPass;
        private CheckBox CBSeePW;
    }
}