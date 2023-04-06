using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
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

                GetPatientAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetPatientAppointments()
        {
            try
            {
                _appointments = _appointmentController.GetPatientAppointments(_user.PatientId);

                lblPatientName.Text = $"{_user.FirstName} {_user.LastName}";

                dgAppointments.DataSource = _appointments;

                if (dgAppointments.Rows.Count > 0)
                {
                    dgAppointments.Rows[0].Selected = true;
                }
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
            Appointment appointment = (Appointment)dgAppointments.SelectedRows[0].DataBoundItem;

            using (AppointmentForm appointmentForm = new AppointmentForm(appointment))
            {
                appointmentForm.ShowDialog();
            }

            dgAppointments.Refresh();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment()
            {
                PatientId = _user.PatientId,
                PatientName = $"{_user.FirstName} {_user.LastName}"
            };

            using (AppointmentForm appointmentForm = new AppointmentForm(newAppointment))
            {
                appointmentForm.ShowDialog();
            }

            GetPatientAppointments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgAppointments.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
