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
        /// Sets the username and personal name of the user logged in
        /// </summary>
        /// <param name="login"></param>
        /// <param name="user"></param>
        public void SetUsername(Login login, User user)
        {
            lblUsername.Text = login.Username;
            lblName.Text = CapitalizeFirstLetter(user.FirstName) + " " + CapitalizeFirstLetter(user.LastName);
        }

        private string CapitalizeFirstLetter(string str)
        {
            string firstLetter = str.Remove(1, str.Length - 1);
            string newString = firstLetter.ToUpper() + str.Remove(0, 1);
            return newString;
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
