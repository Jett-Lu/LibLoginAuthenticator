namespace Login_Authenticator_Forms
{
    partial class frmLogin
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
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsername.Location = new System.Drawing.Point(196, 58);
            txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(129, 29);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.Location = new System.Drawing.Point(196, 111);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(129, 29);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblUsername.Location = new System.Drawing.Point(80, 61);
            lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(81, 21);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "U̲sername";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPassword.Location = new System.Drawing.Point(82, 114);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(77, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "P̲assword";
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.Location = new System.Drawing.Point(163, 173);
            btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(88, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(399, 243);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "jlu119 PRG650B L1 Login Form";
            KeyDown += frmMain_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

