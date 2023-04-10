using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL to access the patientVisits table
    /// </summary>
    public class PatientVisitDAL
    {
        /// <summary>
        /// Get patient appoinment list by patient id
        /// </summary>
        /// <param name="patientId"> patient id</param>
        /// <returns>patient</returns>
        public List<PatientVisit> GetPatientVisits(int patientId)
        {
            List<PatientVisit> patientVisits = new List<PatientVisit>();

            string selectStatement = @"select patientVisitID, visitDateAndTime, pv.appointmentTime, weight, bpSystolic, 
                                       bpDiastolic, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis, 
                                       nurseId, appointmentId, height
                                       from PatientVisits pv
                                       join Appointments a
                                       on pv.appointmentId, a.appointmentId
                                       where a.patientId = @patientId";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientId", patientId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientVisit patientVisit = new PatientVisit
                            {
                                PatientVisitID = Convert.ToInt32(reader["patientVisitID"]),
                                VisitDateAndTime = Convert.ToDateTime(reader["visitDateAndTime"]),
                                AppointmentTime = Convert.ToDateTime(reader["pv.appointmentTime"]),
                                Weight = decimal.Parse(reader["weight"].ToString()),
                                Systolic = Convert.ToInt32(reader["bpSystolic"]),
                                Diastolic = Convert.ToInt32(reader["bpDiastolic"]),
                                Temperature = decimal.Parse(reader["bodyTemperature"].ToString()),
                                Pulse = Convert.ToInt32(reader["pulse"]),
                                Symptoms = reader["symptoms"].ToString(),
                                InitialDiagnosis = reader["initialDiagnosis"].ToString(),
                                FinalDiagnosis = reader["finalDiagnosis"].ToString(),
                                AppointmentID = Convert.ToInt32(reader["appointmentId"]),
                                NurseID = Convert.ToInt32(reader["nurseId"]),
                                Height = decimal.Parse(reader["height"].ToString())

                            };

                            patientVisits.Add(patientVisit);
                        }
                    }
                }
            }

            return patientVisits;
        }
    }
}
