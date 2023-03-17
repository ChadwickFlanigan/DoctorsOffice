using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the PatientDAL
    /// </summary>
    public class PatientController
    {
        private PatientDAL _patientDBDAL;

        public PatientController()
        {
            _patientDBDAL= new PatientDAL();
        }

        public void Add(User user)
        {
            _patientDBDAL.AddPatient(user);
        }
    }
}
