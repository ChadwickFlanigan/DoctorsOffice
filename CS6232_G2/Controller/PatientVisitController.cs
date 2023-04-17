using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the PatientVisitDAL
    /// </summary>
    public class PatientVisitController
    {
        private PatientVisitDAL _patientVisitDAL;

        /// <summary>
        /// constructor for the PatientVisitController
        /// </summary>
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

        /// <summary>
        /// Returns a patient visit by appointmentId
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public PatientVisit GetPatientVisitAppointmentId(int appointmentId)
        {
            return _patientVisitDAL.GetPatientVisitByAppointmentId(appointmentId);
        }

        /// <summary>
        /// Records a routine visit for a patient.
        /// </summary>
        /// <param name="visit">The patient visit to record.</param>
        /// <returns>True if the visit was successfully recorded, otherwise false.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool RoutineVisit(PatientVisit visit)
        {
            if (visit == null)
            {
                throw new ArgumentNullException("Please enter a valid visit.");
            }

            return _patientVisitDAL.RoutineVisit(visit);
        }
    }
}
