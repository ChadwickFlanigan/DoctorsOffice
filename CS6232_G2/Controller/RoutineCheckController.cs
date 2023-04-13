using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;


namespace CS6232_G2.Controller
{
    /// <summary>
    /// Routine check controller will be used add all patient check-up data
    /// </summary>
    public class RoutineCheckController
    {
        private RoutineCheckDAL _routineCheckDAL;
        /// <summary>
        ///  Constructor to initialize the DAL
        /// </summary>
        public RoutineCheckController()
        {
            _routineCheckDAL = new RoutineCheckDAL();
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

            return _routineCheckDAL.RoutineVisit(visit);
        }
    }
}
