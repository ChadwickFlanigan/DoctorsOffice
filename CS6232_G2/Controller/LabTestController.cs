using CS6232_G2.DAL;
using CS6232_G2.Model;
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
        /// method to insert a labtest into the datebase.
        /// </summary>
        /// <param name="labTest"> a LabTest object representing a Test ordered for a patient</param>
        public void OrderLabTest(LabTest labTest)
        {
            this._labTestDAL.OrderLabTest(labTest);
        }
    }
}
