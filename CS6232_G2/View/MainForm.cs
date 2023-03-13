using CS6232_G2.Model;
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

        private void mnuNewAppointment_Click(object sender, System.EventArgs e)
        {

        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (!loggedOut)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Appointment appointment = new Appointment
            {
                AppointmentId = 0,
                AppointmentTime = new System.DateTime(2023, 10, 12, 14, 30, 00),
                DoctorId = 0,
                PatientId = 1,
                PatientName = "Maged Assad",
                Reason = "Test"
            };

            AppointmentForm appointmentForm = new AppointmentForm(appointment);
            appointmentForm.ShowDialog();
        }
    }
}
