using CS6232_G2.DAL;
using CS6232_G2.Model;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    public class AppointmentController
    {
        private AppointmentDAL _appointmentDAL;

        public AppointmentController()
        {
            _appointmentDAL = new AppointmentDAL();
        }

        public List<Doctor> GetDoctors()
        {
            return _appointmentDAL.GetAllDoctors();
        }
    }
}
