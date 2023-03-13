using CS6232_G2.DAL;
using CS6232_G2.Model;
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
    }
}
