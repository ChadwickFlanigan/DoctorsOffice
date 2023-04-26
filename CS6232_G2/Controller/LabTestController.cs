using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the LabTestDAL
    /// </summary>
    public class LabTestController
    {
        private LabTestDAL _labTestDAL;

        /// <summary>
        /// The constructor for the LabTestController class
        /// </summary>
        public LabTestController()
        {
            _labTestDAL = new LabTestDAL();
        }

        /// <summary>
        /// Returns all labTests from the database for the given patientVisit and testCode
        /// </summary>
        /// <returns></returns>
        public List<LabTest> GetLabTestByVistIdAndTestCode(int patientVisit, int testCode)
        {
            return _labTestDAL.GetLabTestByVistIdAndTestCode(patientVisit, testCode);
        }

        /// <summary>
        /// Returns all labTests from the database for the given patientVisit
        /// </summary>
        /// <returns></returns>
        public List<LabTest> GetLabTestByVistId(int patientVisit)
        {
            return _labTestDAL.GetLabTestByVistId(patientVisit);
        }

        /// <summary>
        /// method to insert a labtest into the datebase.
        /// </summary>
        /// <param name="labTest"> a LabTest object representing a Test ordered for a patient</param>
        public void OrderLabTest(List<LabTest> labTests)
        {
            this._labTestDAL.OrderLabTest(labTests);
        }

        /// <summary>
        /// method called to update the results of a LabTest in the DB
        /// </summary>
        /// <param name="test">a LabTest object</param>
        public void UpdateLabTestResults(LabTest test)
        {
            this._labTestDAL.UpdateLabTestResults(test);
        }

        /// <summary>
        /// method returning true if a test has been ordered, otherwise false
        /// </summary>
        /// <param name="test"></param>
        /// <returns>true or false depending on if test has been ordered</returns>
        public Boolean HasTestBeenOrdered(LabTest test)
        {
            return this._labTestDAL.HasTestBeenOrdered(test);
        }

        /// <summary>
        /// method calling on a stored procedure to get the statistics of performed lab tests in a given date range
        /// </summary>
        /// <param name="startDate">the starting date</param>
        /// <param name="endDate">the ending date</param>
        /// <returns></returns>
        public List<LabTestStatistic> GetLabTestStatistics(DateTime startDate, DateTime endDate)
        {
            return this._labTestDAL.GetLabTestStatistics(startDate, endDate);
        }
    }
}
