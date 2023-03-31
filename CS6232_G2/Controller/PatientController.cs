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

        /// <summary>
        /// The constructor for the PatientController
        /// </summary>
        public PatientController()
        {
            _patientDBDAL= new PatientDAL();
        }

        /// <summary>
        /// Addes both patient to the patient table, and an associated user to the user table
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            _patientDBDAL.AddPatient(user);
        }

        /// <summary>
        /// represent boolean value for update patient
        /// </summary>
        /// <param name="user"></param>
        /// <param name="oldUser"></param>
        /// <returns></returns>
        public bool UpdatePatient(User user, User oldUser)
        {
            return _patientDBDAL.UpdatePatient(user, oldUser);
        }
    }
}
