using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    /// <summary>
    /// Appointment user control will allow the nurse to take in a new appointment
    /// </summary>
    public partial class ucAppointments : UserControl
    {
        private DateTime _lastTimeValue;
        private AppointmentController _appointmentController;

        public ucAppointments()
        {
            InitializeComponent();
            _appointmentController = new AppointmentController();
        }

        private void ucAppointments_Load(object sender, EventArgs e)
        {
            DateTime newAvailableTime = CalculateNextAvailableTime(DateTime.Now);
            _lastTimeValue = newAvailableTime;
            dtAppointmentDate.MinDate = newAvailableTime;
            dtAppointmentTime.MinDate = newAvailableTime;

            BindDoctors();
        }

        private void BindDoctors()
        {
            List<Doctor> doctors = _appointmentController.GetDoctors();
            cbDoctors.Items.Clear();
            cbDoctors.Items.AddRange(doctors.ToArray());
        }

        private void ValidateDoctorAvailability()
        {
            // validate if the doctor is book
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

        private void dtAppointmentTime_ValueChanged(object sender, EventArgs e)
        {
            if (_lastTimeValue == dtAppointmentTime.Value)
            {
                return;
            }

            TimeSpan elapsed = new TimeSpan(dtAppointmentTime.Value.Ticks - _lastTimeValue.Ticks);
            int minuteIncrements = 0;

            if (elapsed.TotalMinutes > 59)
            {
                _lastTimeValue = dtAppointmentTime.Value;
                return;
            }
            else if (elapsed.TotalMinutes == 59)
            {
                minuteIncrements = _lastTimeValue < dtAppointmentTime.Value.AddHours(-1) ? 74 : -74;
            }
            else
            {
                minuteIncrements = _lastTimeValue < dtAppointmentTime.Value ? 14 : -14;
            }

            DateTime newValue = dtAppointmentTime.Value.AddMinutes(minuteIncrements);

            newValue = newValue < dtAppointmentTime.MinDate ? dtAppointmentTime.MinDate : newValue;
            newValue = CalculateNextAvailableTime(newValue);
            _lastTimeValue = newValue;
            dtAppointmentTime.Value = newValue;
        }
    }
}
