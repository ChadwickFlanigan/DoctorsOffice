using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_G2.DAL
{
    public class RoutineCheckDAL
    {
        public bool RoutineVisit(PatientVisit visit)
        {
            {
                string insertStatement =
                    "INSERT INTO PatientVisits " +
                    "(visitDateAndTime, appointmentTime, weight, bpSystolic, bpDiastolic, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis, nurseId, appointmentId) " +
                    "VALUES (@visitDateAndTime, @appointmentTime, @weight, @bpSystolic, @bpDiastolic, @bodyTemperature, @pulse, @symptoms, @initialDiagnosis, @finalDiagnosis, @nurseId, @appointmentId);";

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

                       // insertCommand.Parameters.Add("@height", System.Data.SqlDbType.Decimal);
                       // insertCommand.Parameters["@height"].Value = visit.Height;

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

                        if (String.IsNullOrEmpty(visit.FinalDiagnosis) || visit.FinalDiagnosis.Equals("None currently entered"))
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
    }
}
