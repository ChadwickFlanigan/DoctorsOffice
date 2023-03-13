using CS6232_G2.Model;
using System;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The class for interacting with the login table of the database
    /// </summary>
    public class LoginDAL
    {
        /// <summary>
        /// Returns the login information associated with the given username and password
        /// </summary>
        /// <returns></returns>
        public Login CheckIfUserIsValid(Login login)
        {
            string selectStatement = "select n.nurseId, n.userId, n.active, a.administratorId, a.personId " +
                "From Logins l left join Nurses n on l.username = n.username " +
                "left join Administrators a on l.username = a.username " +
                "where l.username = @username and [password] = @password";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", login.Username);
                    selectCommand.Parameters.AddWithValue("@password", login.Password);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["nurseId"] != null)
                            {
                                login.NurseId = Convert.ToInt32(reader["nurseId"]);
                                login.UserId = Convert.ToInt32(reader["userId"]);
                                login.Active = Convert.ToBoolean(reader["active"]);
                            }
                            else if (reader["administratorId"] != null)
                            {
                                login.AdministratorId = Convert.ToInt32(reader["administratorId"]);
                                login.UserId = Convert.ToInt32(reader["personId"]);
                            }
                        }
                    }
                }
            }

            return login;
        }
    }
}
