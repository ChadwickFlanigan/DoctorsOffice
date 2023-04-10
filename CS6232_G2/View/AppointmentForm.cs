using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CS6232_G2
{
    /// <summary>
    /// Appointments form used to view/edit an appointment
    /// </summary>
    public partial class AppointmentForm : Form
    {
        private AppointmentController _appointmentController;
        private Appointment _appointment;
        private List<Doctor> _doctorList;
        private bool _isFormEditable;

        /// <summary>
        /// Constructor to draw the ui components and initialize the controller
        /// </summary>
        /// <param name="appointment">At minimum requires patientId and patientName</param>
        public AppointmentForm(Appointment appointment)
        {
            InitializeComponent();
            _appointmentController = new AppointmentController();
            _appointment = appointment;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            if (_appointment.PatientId == 0 || string.IsNullOrEmpty(_appointment.PatientName))
            {
                MessageBox.Show("Invalid request, please select a patient first", "Invalid patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDoctors.Enabled = false;
                dtAppointmentDate.Enabled = false;
                numHours.Enabled = false;
                numMinutes.Enabled = false;
                txtReason.Enabled = false;
                return;
            }

            DateTime newAvailableTime = CalculateNextAvailableTime(DateTime.Now);

            if (_appointment.AppointmentId == 0)
            {
                dtAppointmentDate.MinDate = newAvailableTime;
                numHours.Value = newAvailableTime.Hour;
                numMinutes.Value = newAvailableTime.Minute;
            }

            BindDoctors();
            BindAppointmentValues();
            SetFormEditState();
        }

        private void BindDoctors()
        {
            try
            {
                _doctorList = _appointmentController.GetDoctors();
                cbDoctors.Items.Clear();
                cbDoctors.Items.AddRange(_doctorList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void BindAppointmentValues()
        {
            lblPatientName.Text = _appointment.PatientName;

            if (_appointment.AppointmentId > 0)
            {
                dtAppointmentDate.Value = _appointment.AppointmentTime.Value;
                numHours.Value = _appointment.AppointmentTime.Value.Hour;
                numMinutes.Value = _appointment.AppointmentTime.Value.Minute;

                txtReason.Text = _appointment.Reason;

                if (_doctorList?.Count > 0)
                {
                    cbDoctors.SelectedItem = _doctorList.Find(d => d.DoctorId == _appointment.DoctorId);
                }
            }
        }

        private void SetFormEditState()
        {
            _isFormEditable = _appointment.AppointmentTime == null || _appointment.AppointmentTime > DateTime.Now.AddDays(1);

            cbDoctors.Enabled = _isFormEditable;
            dtAppointmentDate.Enabled = _isFormEditable;
            numHours.Enabled = _isFormEditable;
            numMinutes.Enabled = _isFormEditable;
            txtReason.Enabled = _isFormEditable;
            btnSave.Enabled = _isFormEditable;
        }

        private DateTime CalculateNextAvailableTime(DateTime baseTime)
        {
            DateTime nextAvailable;

            if (baseTime.Minute == 0)
            {
                nextAvailable = baseTime;
            }
            else if (baseTime.Minute > 0 & baseTime.Minute <= 15)
            {
                nextAvailable = baseTime.AddMinutes(15 - baseTime.Minute);
            }
            else if (baseTime.Minute >= 16 & baseTime.Minute <= 30)
            {
                nextAvailable = baseTime.AddMinutes(30 - baseTime.Minute);
            }
            else if (baseTime.Minute >= 31 & baseTime.Minute <= 45)
            {
                nextAvailable = baseTime.AddMinutes(45 - baseTime.Minute);
            }
            else
            {
                nextAvailable = baseTime.AddMinutes(60 - baseTime.Minute);
            }

            return nextAvailable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            if (IsFormValid())
            {
                Doctor selectedDoctor = (Doctor)cbDoctors.SelectedItem;
                int doctorId = selectedDoctor.DoctorId;

                _appointment.DoctorId = doctorId;
                _appointment.AppointmentTime = dtAppointmentDate.Value.Date + new TimeSpan(Convert.ToInt16(numHours.Value), Convert.ToInt16(numMinutes.Value), 0);
                _appointment.Reason = txtReason.Text.Trim();

                try
                {
                    if (_appointmentController.SaveAppointment(_appointment))
                    {
                        SetFormEditState();
                        lblMessage.ForeColor = Color.Black;
                        lblMessage.Text = "Appointment has been saved";
                    }
                    else
                    {
                        lblMessage.Text = "Failed to save appointment, re-open page and try again";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private bool IsFormValid()
        {
            lblMessage.ForeColor = Color.Red;
            DateTime appointmentTime = dtAppointmentDate.Value.Date + new TimeSpan(Convert.ToInt16(numHours.Value), Convert.ToInt16(numMinutes.Value), 0);

            if (appointmentTime < DateTime.Now)
            {
                lblMessage.Text = "Please choose a future time";
                return false;
            }
            else if (cbDoctors.SelectedItem == null)
            {
                lblMessage.Text = "No doctor selected for the appointment";
                return false;
            }
            else if (!IsDoctorAvailability(appointmentTime))
            {
                lblMessage.Text = "Doctor is not available";
                return false;
            }
            else if (txtReason.Text.Trim().Length == 0)
            {
                lblMessage.Text = "Please enter a reason for the visit";
                return false;
            }

            return true;
        }

        private bool IsDoctorAvailability(DateTime appointmentTime)
        {
            try
            {
                Doctor selectedDoctor = (Doctor)cbDoctors.SelectedItem;
                int doctorId = selectedDoctor.DoctorId;

                return _appointmentController.IsDoctorAvailable(doctorId, appointmentTime, _appointment.AppointmentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numHours_ValueChanged(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }

        private void numMinutes_ValueChanged(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }
    }
}