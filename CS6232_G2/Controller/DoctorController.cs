using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the doctor DAL
    /// </summary>
    public class DoctorController
    {
        private DoctorDAL _doctorDAL;

        /// <summary>
        /// The constructor for the PatientController
        /// </summary>
        public DoctorController()
        {
            _doctorDAL = new DoctorDAL();
        }


        /// <summary>
        /// Get doctor by Id
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        public Doctor GetDoctorById(int doctorId)
        {
            return _doctorDAL.GetDoctorByDoctorId(doctorId);
        }
    }
}
