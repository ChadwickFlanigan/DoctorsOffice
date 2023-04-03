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

        /// <summary>
        /// Search nurses table by either name or dob or combination
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dob"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Nurse> GetNurseByCriteria(string firstName, string lastName, DateTime? dob)
        {
            List<Nurse> nurseDetails = new List<Nurse>();
            string selectStatement = "select n.nurseId, u.userId, lastName, firstName, active from users u inner join Nurses n on u.userId = n.userId ";

            if (dob.HasValue && !string.IsNullOrEmpty(lastName))
            {
                selectStatement += "Where dob = @dob And lastName = @lastName And @firstName = @firstName";
            }
            else if (dob.HasValue && string.IsNullOrEmpty(lastName))
            {
                selectStatement += "Where dob = @dob And lastName = @lastName And @firstName = @firstName";
            }
            else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                selectStatement += "Where firstName = @firstName And lastName = @lastName And @dob is null ";
            }
            else
            {
                return null;
            }

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (dob.HasValue)
                    {
                        selectCommand.Parameters.AddWithValue("@dob", dob.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@dob", DBNull.Value);
                    }

                    selectCommand.Parameters.AddWithValue("@firstName", firstName);
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse
                            {
                                NurseId = Convert.ToInt32(reader["NurseId"]),
                                UserId = Convert.ToInt32(reader["userId"]),
                                LastName = reader["lastName"].ToString(),
                                FirstName = reader["firstName"].ToString(),
                                IsActive = Convert.ToBoolean(reader["active"])
                            };

                            nurseDetails.Add(nurse);
                        }
                    }
                }
            }
            return nurseDetails;
        }
    }
}
