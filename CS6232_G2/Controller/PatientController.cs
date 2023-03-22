﻿using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the PatientDAL
    /// </summary>
    public class PatientController
    {
        private PatientDAL _patientDBDAL;

        /// <summary>
        /// Returns the patient to be edited
        /// </summary>
        /// <returns></returns>
        public Patient GetPatientToEdit()
        {
            return _patientDBDAL.GetPatientToEdit();
        }

        /// <summary>
        /// Sets the patient to be edited
        /// </summary>
        /// <returns></returns>
        public void SetPatientToEdit(Patient patient)
        {
            _patientDBDAL.SetPatientToEdit(patient);
        }

        /// <summary>
        /// The constructor for the PatientController
        /// </summary>
        public PatientController()
        {
            _patientDBDAL= new PatientDAL();
        }

        /// <summary>
        /// Addes both patient to the patient table, and an associated user to the user table
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            _patientDBDAL.AddPatient(user);
        }

        /// <summary>
        /// Returns the patient associated with the given patientId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Patient GetPatientByPatientId(int id)
        {
            return _patientDBDAL.GetPatientByPatientId(id);
        }

        public bool UpdatePatient(User user, User oldUser)
        {
            return _patientDBDAL.UpdatePatient(user, oldUser);
        }
    }
}
