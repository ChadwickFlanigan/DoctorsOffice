using CS6232_G2.Controller;
using CS6232_G2.Model;
using CS6232_G2.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    /// <summary>
    /// Patients Appointment user control will display the appointments of the patient and an option to add apointment or edit the user
    /// </summary>
    public partial class ucPatientAppointments : UserControl
    {
        private Patient _user;
        private PatientVisit _patientCheckUp;
        private AppointmentController _appointmentController;
        private List<Appointment> _appointments = new List<Appointment>();

        /// <summary>
        /// Constructor to initialize the user control
        /// </summary>
        public ucPatientAppointments()
        {
            InitializeComponent();
            _appointmentController = new AppointmentController();
            dgAppointments.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Set the userId of the patient selected
        /// </summary>
        /// <param name="userId"></param>
        public void SetPatient(Patient patient)
        {
            _user = patient;
            InitializeAppointment();
        }
        public void SetAppoinment(PatientVisit appoinment)
        {
            _patientCheckUp = appoinment;
            InitializeAppointment();
        }

        private void InitializeAppointment()
        {
            try
            {
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
            using (EditPatientForm _editForm = new EditPatientForm(_user.UserId))
            {
                _editForm.ShowDialog();
            }
        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
            if (dgAppointments.SelectedRows.Count > 0)
            {
                Appointment appointment = (Appointment)dgAppointments.SelectedRows[0].DataBoundItem;

                using (AppointmentForm _appointmentForm = new AppointmentForm(appointment))
                {
                    _appointmentForm.ShowDialog();
                }

                dgAppointments.Refresh();
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment()
            {
                PatientId = _user.PatientId,
                PatientName = $"{_user.FirstName} {_user.LastName}",
                PatientDob = _user.DOB
            };

            using (AppointmentForm appointmentForm = new AppointmentForm(newAppointment))
            {
                appointmentForm.ShowDialog();
            }

            GetPatientAppointments();
        }

        private void routineCheckupButton_Click(object sender, EventArgs e)
        {
            if (dgAppointments.SelectedRows.Count > 0)
            {
                Appointment appointment = (Appointment)dgAppointments.SelectedRows[0].DataBoundItem;

                using (RoutineCheckupForm checkupForm = new RoutineCheckupForm(appointment))
                {
                    checkupForm.ShowDialog();
                }
            }
        }

        private void deleteApptButton_Click(object sender, EventArgs e)
        {
            if (dgAppointments.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want delete this appointment?", "Delete Appointment", MessageBoxButtons.YesNo);

                if (result.Equals(DialogResult.Yes))
                {
                    Appointment appointment = (Appointment)dgAppointments.SelectedRows[0].DataBoundItem;
                    DateTime appointmentDateTime = (DateTime)appointment.AppointmentTime;
                    if (appointmentDateTime > DateTime.Now)
                    {
                        if (_appointmentController.DeleteAppointment(appointment))
                        {
                            InitializeAppointment();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete appointment.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected appointment cannot be deleted because it has already passed.");
                    }

                    dgAppointments.Refresh();
                }
            }
        }
    }
}
