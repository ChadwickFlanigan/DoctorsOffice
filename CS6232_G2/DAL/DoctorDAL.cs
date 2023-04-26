using CS6232_G2.Model;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL class for the doctor table
    /// </summary>
    public class DoctorDAL
    {
        /// <summary>
        /// Returns the Doctor associated with the given doctorId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Doctor GetDoctorByDoctorId(int id)
        {
            Doctor doctor = new Doctor();
            string selectStatement =
                        "SELECT d.userId doctorUserId, firstName, lastName " +
                        "FROM doctors d join users u on d.userId = u.userId " +
                        "WHERE doctorId = @doctorId";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@doctorId", id);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctor.FirstName = reader["firstName"].ToString();
                            doctor.LastName = reader["lastName"].ToString();
                            doctor.UserId = int.Parse(reader["doctorUserId"].ToString());
                        }
                    }
                }
            }
            return doctor;
        }
    }
}
