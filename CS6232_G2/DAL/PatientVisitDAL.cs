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
        /// Records a routine visit for a patient.
        /// </summary>
        /// <param name="visit">The patient visit to record.</param>
        /// <returns>True if the visit was successfully recorded, otherwise false.</returns>
        public bool RoutineVisit(PatientVisit visit)
        {
            {
                string insertStatement =
                    "INSERT INTO PatientVisits " +
                    "(visitDateAndTime, appointmentTime, weight, bpSystolic, bpDiastolic, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis, nurseId, appointmentId, height) " +
                    "VALUES (@visitDateAndTime, @appointmentTime, @weight, @bpSystolic, @bpDiastolic, @bodyTemperature, @pulse, @symptoms, @initialDiagnosis, @finalDiagnosis, @nurseId, @appointmentId, @height);";

                using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
                {
                    connection.Open();
                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                    {
                        insertCommand.Parameters.Add("@visitDateAndTime", System.Data.SqlDbType.SmallDateTime);
                        insertCommand.Parameters["@visitDateAndTime"].Value = visit.VisitDateAndTime;

                        insertCommand.Parameters.Add("@appointmentTime", System.Data.SqlDbType.SmallDateTime);
                        insertCommand.Parameters["@appointmentTime"].Value = visit.AppointmentTime;

                        insertCommand.Parameters.Add("@nurseId", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@nurseId"].Value = visit.NurseID;

                        insertCommand.Parameters.Add("@appointmentId", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@appointmentId"].Value = visit.AppointmentID;

                        insertCommand.Parameters.Add("@height", System.Data.SqlDbType.Decimal);
                        insertCommand.Parameters["@height"].Value = visit.Height;

                        insertCommand.Parameters.Add("@weight", System.Data.SqlDbType.Decimal);
                        insertCommand.Parameters["@weight"].Value = visit.Weight;

                        insertCommand.Parameters.Add("@bpSystolic", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@bpSystolic"].Value = visit.Systolic;

                        insertCommand.Parameters.Add("@bpDiastolic", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@bpDiastolic"].Value = visit.Diastolic;

                        insertCommand.Parameters.Add("@bodyTemperature", System.Data.SqlDbType.Decimal);
                        insertCommand.Parameters["@bodyTemperature"].Value = visit.Temperature;

                        insertCommand.Parameters.Add("@pulse", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@pulse"].Value = visit.Pulse;

                        insertCommand.Parameters.Add("@symptoms", System.Data.SqlDbType.VarChar);
                        insertCommand.Parameters["@symptoms"].Value = visit.Symptoms;

                        insertCommand.Parameters.Add("@initialDiagnosis", System.Data.SqlDbType.VarChar);
                        insertCommand.Parameters["@initialDiagnosis"].Value = visit.InitialDiagnosis;


                        insertCommand.Parameters.Add("@finalDiagnosis", System.Data.SqlDbType.VarChar);

                        if (String.IsNullOrEmpty(visit.FinalDiagnosis) || visit.FinalDiagnosis.Equals("Nothing was currently entered"))
                        {
                            insertCommand.Parameters["@finalDiagnosis"].Value = DBNull.Value;
                        }
                        else
                        {
                            insertCommand.Parameters["@finalDiagnosis"].Value = visit.FinalDiagnosis;
                        }

                        int count = insertCommand.ExecuteNonQuery();
                        if (count > 0)
                            return true;
                        else
                            return false;
                    }
                }
            }
        }

        /// <summary>
        /// Get patient appoinment list by patient id
        /// </summary>
        /// <param name="patientId"> patient id</param>
        /// <returns>patient</returns>
        public List<PatientVisit> GetPatientVisits(int patientId)
        {
            List<PatientVisit> patientVisits = new List<PatientVisit>();

            string selectStatement = @"select patientVisitID, visitDateAndTime, pv.appointmentTime as time, weight, bpSystolic, 
                                       bpDiastolic, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis, 
                                       nurseId, pv.appointmentId as Id, height
                                       from PatientVisits pv
                                       join Appointments a
                                       on pv.appointmentId = a.appointmentId
                                       where a.patientId = @patientId;";

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
                                AppointmentTime = Convert.ToDateTime(reader["time"]),
                                Weight = decimal.Parse(reader["weight"].ToString()),
                                Systolic = Convert.ToInt32(reader["bpSystolic"]),
                                Diastolic = Convert.ToInt32(reader["bpDiastolic"]),
                                Temperature = decimal.Parse(reader["bodyTemperature"].ToString()),
                                Pulse = Convert.ToInt32(reader["pulse"]),
                                Symptoms = reader["symptoms"].ToString(),
                                InitialDiagnosis = reader["initialDiagnosis"].ToString(),
                                FinalDiagnosis = reader["finalDiagnosis"].ToString(),
                                AppointmentID = Convert.ToInt32(reader["Id"]),
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

        /// <summary>
        /// Get patient appoinment by appointmentId
        /// </summary>
        /// <param name="appointmentId"> appointment Id</param>
        /// <returns>patient</returns>
        public PatientVisit GetPatientVisitByAppointmentId(int appointmentId)
        {
            PatientVisit patientVisit = new PatientVisit();

            string selectStatement = @"select patientVisitID, visitDateAndTime, pv.appointmentTime as time, weight, bpSystolic, 
                                       bpDiastolic, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis, 
                                       nurseId, pv.appointmentId as Id, height
                                       from PatientVisits pv
                                       join Appointments a
                                       on pv.appointmentId = a.appointmentId
                                       where a.appointmentId = @appointmentId;";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@appointmentId", appointmentId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patientVisit = new PatientVisit
                            {
                                PatientVisitID = Convert.ToInt32(reader["patientVisitID"]),
                                VisitDateAndTime = Convert.ToDateTime(reader["visitDateAndTime"]),
                                AppointmentTime = Convert.ToDateTime(reader["time"]),
                                Weight = decimal.Parse(reader["weight"].ToString()),
                                Systolic = Convert.ToInt32(reader["bpSystolic"]),
                                Diastolic = Convert.ToInt32(reader["bpDiastolic"]),
                                Temperature = decimal.Parse(reader["bodyTemperature"].ToString()),
                                Pulse = Convert.ToInt32(reader["pulse"]),
                                Symptoms = reader["symptoms"].ToString(),
                                InitialDiagnosis = reader["initialDiagnosis"].ToString(),
                                FinalDiagnosis = reader["finalDiagnosis"].ToString(),
                                AppointmentID = Convert.ToInt32(reader["Id"]),
                                NurseID = Convert.ToInt32(reader["nurseId"]),
                                Height = decimal.Parse(reader["height"].ToString())
                            };
                        }
                    }
                }
            }

            return patientVisit;
        }
    }
}
