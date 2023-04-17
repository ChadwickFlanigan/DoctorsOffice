using CS6232_G2.DAL;
using CS6232_G2.Model;
using System.Collections.Generic;
using System;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the PatientDAL
    /// </summary>
    public class PatientController
    {
        private PatientDAL _patientDAL;

        /// <summary>
        /// The constructor for the PatientController
        /// </summary>
        public PatientController()
        {
            _patientDAL= new PatientDAL();
        }

        /// <summary>
        /// Addes both patient to the patient table, and an associated user to the user table
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            _patientDAL.AddPatient(user);
        }

        /// <summary>
        /// represent boolean value for update patient
        /// </summary>
        /// <param name="user"></param>
        /// <param name="oldUser"></param>
        /// <returns></returns>
        public bool UpdatePatient(User user, User oldUser)
        {
            return _patientDAL.UpdatePatient(user, oldUser);
        }

        /// <summary>
        /// Searches the users with firstname and lastname
        /// </summary>
        /// <param name="fname">first name</param>
        /// <param name="lname">last name</param>
        /// <returns> user by first and last name</returns>
        public List<Patient> GetPatientByFirstAndLastName(string fname, string lname)
        {
            return _patientDAL.GetPatientListByFirstAndLastName(fname, lname);
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
            return _patientDAL.GetPatientsByDOB(dob);
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
            return _patientDAL.GetPatientsByDOBAndLastName(dob, lname);
        }
    }
}
