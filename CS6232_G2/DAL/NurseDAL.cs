using CS6232_G2.Model;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the Nurses table
    /// </summary>
    public class NurseDAL
    {
        public Nurse GetNurseByLogin(Login login)
        {
            Nurse nurse = new Nurse();
            string selectStatement =
                        "SELECT nurseId, userId, active " +
                        "FROM Nurses n " +
                        "JOIN Logins l on l.username = n.username " +
                        "WHERE n.username = @username";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", login.Username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nurse.NurseId = int.Parse(reader["nurseId"].ToString());
                            nurse.UserId = int.Parse(reader["userId"].ToString());
                            nurse.Username = login.Username;
                        }
                    }
                }
            }
            return nurse;
        }
    }
}
