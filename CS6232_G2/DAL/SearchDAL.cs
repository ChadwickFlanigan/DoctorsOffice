using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// SearchDAL class to access the patient
    /// </summary>
    public class SearchDAL
    {
        /// <summary>
        /// Get patient list by patient first and last name
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <returns>patient</returns>
        public List<Patient> GetPatientListByFirstAndLastName(string firstName, string lastName)
        {
            List<Patient> patientsdetails = new List<Patient>();

            string selectStatement = "select p.patientId, u.userId, lastName, firstName, dob from users u inner join Patients p on u.userId = p.userId " +
                "Where firstName = @firstName And lastName =@lastName";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@firstName", firstName);
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                UserId = Convert.ToInt32(reader["userId"]),
                                LastName = reader["lastName"].ToString(),
                                FirstName = reader["firstName"].ToString(),
                                DOB = Convert.ToDateTime(reader["dob"])
                            };

                            patientsdetails.Add(patient);
                        }
                    }
                }
            }

            return patientsdetails;
        }
        /// <summary>
        /// Get patient by patient date of birth
        /// </summary>
        /// <param name="dob">date of birth</param>
        /// <returns>patient</returns>
        public List<Patient> GetPatientsByDOB(DateTime dob)
        {
            List<Patient> patientsdetails = new List<Patient>();
            string selectStatement = "select p.patientId, u.userId, lastName, firstName, dob from users u inner join Patients p on u.userId = p.userId Where dob = @dob ";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@dob", dob);


                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                UserId = Convert.ToInt32(reader["userId"]),
                                LastName = reader["lastName"].ToString(),
                                FirstName = reader["firstName"].ToString(),
                                DOB = Convert.ToDateTime(reader["dob"])
                            };

                            patientsdetails.Add(patient);

                        }
                    }
                }
            }
            return patientsdetails;
        }
        /// <summary>
        /// Get patient by date of birth and last name
        /// </summary>
        /// <param name="dob">date of birth</param>
        /// <param name="lastName">last name</param>
        /// <returns>patient</returns>
        public List<Patient> GetPatientsByDOBAndLastName(DateTime dob, string lastName)
        {
            List<Patient> patientsdetails = new List<Patient>();
            string selectStatement = " select p.patientId, u.userId, lastName, firstName, dob from users u inner join Patients p on u.userId = p.userId Where dob = @dob And lastName =@lastName";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@dob", dob);
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                UserId = Convert.ToInt32(reader["userId"]),
                                LastName = reader["lastName"].ToString(),
                                FirstName = reader["firstName"].ToString(),
                                DOB = Convert.ToDateTime(reader["dob"])
                            };

                            patientsdetails.Add(patient);
                        }
                    }
                }
            }
            return patientsdetails;
        }

    }
}
