using CS6232_G2.Model;
using System;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// The form for an administrating user
    /// </summary>
    public partial class AdministratorForm : Form
    {
        private bool loggedOut;
        private readonly LoginForm _loginForm;

        /// <summary>
        /// The constructor for the administrator form
        /// </summary>
        public AdministratorForm(LoginForm loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
        }

        /// <summary>
        /// Sets the label username
        /// </summary>
        /// <param name="username"></param>
        public void SetUsername(Login login)
        {
            lblUsername.Text = login.Username;
        }

        private void lnkLogout_Click(object sender, EventArgs e)
        {
            loggedOut = true;
            _loginForm.Logout();
            Close();
        }

        private void AdministratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loggedOut)
            {
                Application.Exit();
            }
        }
    }
}
