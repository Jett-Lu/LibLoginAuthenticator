using System;
using System.Windows.Forms;

namespace Login_Authenticator_Forms
{
    public partial class frmLogin : Form
    {
        private readonly LibLoginAuthenticator.LibLoginAuthenticator authenticator = new LibLoginAuthenticator.LibLoginAuthenticator();

        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            authenticator.Username = string.IsNullOrWhiteSpace(txtUsername.Text) ? null : txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            authenticator.Password = string.IsNullOrWhiteSpace(txtPassword.Text) ? null : txtPassword.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool? authenticationResult = authenticator.Authenticate();

            if (authenticationResult == null)
            {
                MessageBox.Show("You must enter both username and password...\n    please try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clearFocus();
            }
            else if (authenticationResult == false)
            {
                MessageBox.Show("Authentication failed...\n    please try again...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                clearFocus();
            }
            else
            {
                MessageBox.Show("Authentication successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void clearFocus()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.U)
                {
                    txtUsername.Focus();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.P)
                {
                    txtPassword.Focus();
                    e.Handled = true;
                }
            }
        }

    }
}