using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// Appointment controller to communicate with the dal
    /// </summary>
    public class AppointmentController
    {
        private AppointmentDAL _appointmentDAL;

        /// <summary>
        /// Constructor to initialize the DAL access
        /// </summary>
        public AppointmentController()
        {
            _appointmentDAL = new AppointmentDAL();
        }

        /// <summary>
        /// Gets a list of doctors from the database
        /// </summary>
        /// <returns></returns>
        public List<Doctor> GetDoctors()
        {
            return _appointmentDAL.GetAllDoctors();
        }

        /// <summary>
        /// Saves a new or existing appointment
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public bool SaveAppointment(Appointment appointment)
        {
            return _appointmentDAL.SaveAppointment(appointment);
        }

        /// <summary>
        /// Gets an appointment details by the appointmentId
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Appointment GetAppointmentById(int appointmentId)
        {
            return _appointmentDAL.GetAppointmentById(appointmentId);
        }

        /// <summary>
        /// Checks if the doctor is booked at the given time or not
        /// </summary>
        /// <param name="doctorId"></param>
        /// <param name="appointmentTime"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsDoctorAvailable(int doctorId, DateTime appointmentTime)
        {
            return _appointmentDAL.IsDoctorAvailable(doctorId, appointmentTime);
        }
    }
}
