using CS6232_G2.View;
using System.Windows.Forms;

namespace CS6232_G2
{
    /// <summary>
    /// Will allow nurse to view/edit/add appointments for patients
    /// </summary>
    public partial class MainForm : Form
    {
        private bool loggedOut;
        private readonly LoginForm _loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        /// <summary>
        /// Sets the label username
        /// </summary>
        /// <param name="username"></param>
        public void SetUsername(string username)
        {
            lblUsername.Text = username;
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loggedOut)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Logout button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loggedOut = true;
            _loginForm.Logout();
            Close();
        }
    }
}
