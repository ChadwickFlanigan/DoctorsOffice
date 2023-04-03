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
        /// <param name="fname">first name</param>
        /// <param name="lname">last name</param>
        /// <returns> user by first and last name</returns>
        public List<Patient> GetPatientByFirstAndLastName(string fname, string lname)
        {
            return _searchDAL.GetPatientListByFirstAndLastName(fname, lname);
        }
        /// <summary>
        /// Search user by date of birth
        /// </summary>
        /// <param name="dob"> date of birth</param>
        /// <returns> user by date of birth</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Patient> GetPatientsByDOB(DateTime dob)
        {
            if (dob == DateTime.MinValue || dob == null)
            {
                throw new ArgumentNullException("Date of birth cannot be null");
            }
            return _searchDAL.GetPatientsByDOB(dob);
        }
        /// <summary>
        /// Search user by date of birth and last name
        /// </summary>
        /// <param name="dob">date of birth</param>
        /// <param name="lname">last name</param>
        /// <returns>user by dob and last name</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Patient> GetPatientsByDOBAndLastName(DateTime dob, string lname)
        {
            if (dob == DateTime.MinValue || dob == null)
            {
                throw new ArgumentNullException("Date of birth cannot be null");
            }
            return _searchDAL.GetPatientsByDOBAndLastName(dob, lname);
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
            return _searchDAL.GetNurseByCriteria(firstName, lastName, dob);
        }
    }
}
