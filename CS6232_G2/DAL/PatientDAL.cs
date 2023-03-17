using CS6232_G2.Model;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the Patients table
    /// </summary>
    public class PatientDAL
    {
        public void AddPatient(Patient patient)
        {
            string insertStatement =
                "INSERT INTO Patients (userId) " +
                "VALUES (@userId) ";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@userId", patient.UserId);
                insertCommand.ExecuteReader();
            }
        }
    }
}
