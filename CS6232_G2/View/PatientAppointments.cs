using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// UI to view the patient appointments and edit their info
    /// </summary>
    public partial class PatientAppointments : Form
    {
        private Patient _user;
        private int _userId;
        private UserController _userController;
        private AppointmentController _appointmentController;
        private List<Appointment> _appointments = new List<Appointment>();

        /// <summary>
        /// Constructor to initialize the form
        /// </summary>
        public PatientAppointments(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _userController = new UserController();
            _appointmentController = new AppointmentController();
            dgAppointments.AutoGenerateColumns = false;
        }

        private void PatientAppointments_Load(object sender, System.EventArgs e)
        {
            try
            {
                _user = _userController.GetUserFullNameById(_userId);
                lblPatientName.Text = $"{_user.FirstName} {_user.LastName}";

                _appointments = _appointmentController.GetPatientAppointments(_user.PatientId);

                lblPatientName.Text = _appointments.FirstOrDefault().PatientName;
                dgAppointments.DataSource = _appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            using (EditPatientForm _editForm = new EditPatientForm(_userId))
            {
                _editForm.ShowDialog();
            }
        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
            int appointmentId = 1;

            Appointment appointment = new AppointmentController().GetAppointmentById(appointmentId);

            using (AppointmentForm appointmentForm = new AppointmentForm(appointment))
            {
                appointmentForm.ShowDialog();
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment()
            {
                PatientId = _user.PatientId,
                PatientName = $"{_user.FirstName} {_user.LastName}"
            };

            AppointmentForm appointmentForm = new AppointmentForm(newAppointment);
            appointmentForm.ShowDialog();
        }
    }
}
