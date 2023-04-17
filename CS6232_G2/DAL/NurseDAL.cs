using CS6232_G2.Model;
using System.Collections.Generic;
using System;
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
