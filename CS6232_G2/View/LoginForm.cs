using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// Login form will accept login before moving to the incident page
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Login form for users to login before heading to the main form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            txtUsername.Text = "jane";
            txtPassword.Text = "test1234";
        }

        /// <summary>
        /// Checks the username and password to match value, if correct we take the user to the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("jane") && txtPassword.Text.Equals("test1234"))
            {
                MainForm _mainForm = new MainForm(this);
                _mainForm.SetUsername(txtUsername.Text);
                Hide();
                _mainForm.Show();
            }
            else
            {
                lblError.Text = "Invalid username/password";
            }
        }
        /// <summary>
        /// Handles page closing, will close the application if user closes the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        /// <summary>
        /// Clears the textbox values
        /// </summary>
        public void Logout()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            Show();
            txtUsername.Focus();
        }
    }
}
