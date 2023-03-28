using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// Login form will accept login before moving to the incident page
    /// </summary>
    public partial class LoginForm : Form
    {
        private LoginController _loginController;
        private UserController _userController;
        private Login _login;

        /// <summary>
        /// Login form for users to login before heading to the main form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            _loginController = new LoginController();
            _userController = new UserController();
            _login = new Login();

            txtUsername.Text = "hansmuller";
            txtPassword.Text = "mypassword";
        }

        /// <summary>
        /// Checks the username and password to match value, if correct we take the user to the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _login.Username = txtUsername.Text.Trim();
                _login.Password = txtPassword.Text.Trim();

                _login = _loginController.CheckIfLoginIsValid(_login);

                if (_login.AdministratorId > 0)
                {
                    AdministratorForm _adminForm = new AdministratorForm(this);
                    _adminForm.SetUsername(_login, _userController.GetUserAdminByLogin(_login));
                    Hide();
                    _adminForm.Show();
                }
                else if (_login.NurseId > 0)
                {
                    SearchPatientForm _searchPatientForm = new SearchPatientForm(this);
                    _searchPatientForm.SetUsername(_login, _userController.GetUserNurseByLogin(_login));
                    Hide();
                    _searchPatientForm.Show();
                }
                else
                {
                    lblError.Text = "Invalid username/password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
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
            _login.Username = txtUsername.Text;
            lblError.Text = string.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _login.Password = txtPassword.Text;
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
            _login = new Login();
        }
    }
}
