using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    public class LoginDBDAL
    {
        /// <summary>
        /// Checks the database to see if the given login information is valid
        /// </summary>
        /// <returns></returns>
        public bool CheckIfUserIsValid(Login login)
        {
            int success = 0;
            string selectStatement = "Select username, password " +
                                     "From Login " +
                                     "WHERE username = @username AND password = @password";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", login.username);
                    selectCommand.Parameters.AddWithValue("@password", login.password);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        Login newLogin = new Login();
                        while (reader.Read())
                        {
                            newLogin.username = reader["username"].ToString();
                            newLogin.password = reader["password"].ToString();
                            success++;
                        }
                    }
                }
            }

            return success > 0;
        }
    }
}
