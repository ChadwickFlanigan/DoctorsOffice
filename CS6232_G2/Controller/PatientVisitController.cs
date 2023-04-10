using CS6232_G2.DAL;
using CS6232_G2.Model;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the PatientVisitDAL
    /// </summary>
    public class PatientVisitController
    {
        private PatientVisitDAL _patientVisitDAL;

        public PatientVisitController() { 
            _patientVisitDAL= new PatientVisitDAL();
        }

        /// <summary>
        /// Returns a list of appointments for the given patientId
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public List<PatientVisit> GetPatientVisits(int patientId)
        {
            return _patientVisitDAL.GetPatientVisits(patientId);
        }
    }
}
