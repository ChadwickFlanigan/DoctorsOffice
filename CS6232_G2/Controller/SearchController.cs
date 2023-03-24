using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// Search controller will be used to search for patients by name and dob
    /// </summary>
    public class SearchController
    {
        private SearchDAL _searchDAL;

        /// <summary>
        /// Constructor to initialize the DAL
        /// </summary>
        public SearchController()
        {
            _searchDAL = new SearchDAL();
        }
        
        /// <summary>
        /// Searches the users with firstname and lastname
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <returns></returns>
        public List<Patient> GetPatientByFirstAndLastName(string fname, string lname)
        {
            return _searchDAL.GetPatientListByFirstAndLastName(fname, lname);
        }

        public List<Patient> GetPatientsByDOB(DateTime dob)
        {
            if (dob == DateTime.MinValue || dob == null)
            {
                throw new ArgumentNullException("Date of birth cannot be null");
            }
            return _searchDAL.GetPatientsByDOB(dob);
        }

        public List<Patient> GetPatientsByDOBAndLastName(DateTime dob, string lname)
        {
            if (dob == DateTime.MinValue || dob == null)
            {
                throw new ArgumentNullException("Date of birth cannot be null");
            }
            return _searchDAL.GetPatientsByDOBAndLastName(dob, lname);
        }
    }
}
