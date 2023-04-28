using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;

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
        public NurseController()
        {
            _nurseDAL = new NurseDAL();
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

        /// <summary>
        /// Returns the nurse object for a given nurseId
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Nurse GetNurseById(int nurseId)
        {
            return _nurseDAL.GetNurseById(nurseId);
        }

        /// <summary>
        /// Searches the databae with the firstname,lastname, and dob
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dob"></param>
        /// <returns></returns>
        public List<Nurse> GetNurseByCriteria(string firstName, string lastName, DateTime? dob)
        {
            return _nurseDAL.GetNurseByCriteria(firstName, lastName, dob);
        }

        public void SaveNurse(Nurse nurse)
        {
            _nurseDAL.SaveNurse(nurse);
        }
    }
}
