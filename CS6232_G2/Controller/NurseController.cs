using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the NurseDAL
    /// </summary>
    public class NurseController
    {
        private NurseDAL _nurseDAL;

        /// <summary>
        /// The constructor for the NurseController
        /// </summary>
        public NurseController() { 
            _nurseDAL= new NurseDAL();
        }

        /// <summary>
        /// Returns the nurse object for the given login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Nurse GetNurseByLogin(Login login)
        {
            return _nurseDAL.GetNurseByLogin(login);
        }
    }
}
