using CS6232_G2.Model;
using System;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the Users table
    /// </summary>
    public class UserDAL
    {
        /// <summary>
        /// Adds a new user to the database
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            string insertStatement =
                "INSERT INTO Users (lastName, firstName, dob, ssn, gender, streetNumber, city, state, country, phone, zipcode) " +
                "VALUES (@lastName, @firstName, @dob, @ssn, @gender, @streetNumber, @city, @state, @country, @phone, @zipcode) ";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@lastName", user.LastName);
                insertCommand.Parameters.AddWithValue("@firstName", user.FirstName);
                insertCommand.Parameters.AddWithValue("@dob", user.DOB);
                insertCommand.Parameters.AddWithValue("@ssn", user.SSN);
                insertCommand.Parameters.AddWithValue("@gender", user.Gender);
                insertCommand.Parameters.AddWithValue("@streetNumber", user.StreetNumber);
                insertCommand.Parameters.AddWithValue("@city", user.City);
                insertCommand.Parameters.AddWithValue("@state", user.State);
                insertCommand.Parameters.AddWithValue("@country", user.Country);
                insertCommand.Parameters.AddWithValue("@phone", user.Phone);
                insertCommand.Parameters.AddWithValue("@zipcode", user.Zipcode);
                insertCommand.ExecuteReader();
            }
        }

        /// <summary>
        /// Returns the user details for the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Patient GetUserFullNameById(int id)
        {
            Patient user = new Patient();
            string selectStatement =
                        "SELECT p.PatientId, lastName, firstName " +
                        "FROM users u left join Patients p on u.userId = p.userId " +
                        "WHERE u.userId = @userID";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userId", id);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.PatientId = Convert.ToInt32(reader["patientId"]);
                            user.LastName = reader["lastName"].ToString();
                            user.FirstName = reader["firstName"].ToString();
                        }
                    }
                }
            }

            return user;
        }

        /// <summary>
        /// Returns the user details for the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserDetailsByID(int id)
        {
            User user = new User();
            string selectStatement =
                        "SELECT userId, lastName, firstName, dob, ssn, gender, streetNumber, city, state, country, phone, zipcode " +
                        "FROM Users " +
                        "WHERE userId = @userID";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userId", id);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.UserId = int.Parse(reader["userId"].ToString());
                            user.LastName = reader["lastName"].ToString();
                            user.FirstName = reader["firstName"].ToString();
                            user.DOB = (DateTime)reader["dob"];
                            user.SSN = reader["ssn"].ToString();
                            user.Gender = reader["gender"].ToString();
                            user.StreetNumber = reader["streetNumber"].ToString();
                            user.City = reader["city"].ToString();
                            user.State = reader["state"].ToString();
                            user.Country = reader["country"].ToString();
                            user.Phone = reader["phone"].ToString();
                            user.Zipcode = reader["zipcode"].ToString();
                        }
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Returns the user details for a nurse based on a login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User GetUserNurseByLogin(Login login)
        {
            User user = new User();
            string selectStatement =
                        "SELECT u.userId as IdOfUser, lastName, firstName, dob, ssn, gender, streetNumber, city, state, country, phone, zipcode " +
                        "FROM Users u " +
                        "JOIN Nurses n on n.userId = u.userId " +
                        "WHERE n.userId = @userID";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userId", login.UserId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.UserId = int.Parse(reader["IdOfUser"].ToString());
                            user.LastName = reader["lastName"].ToString();
                            user.FirstName = reader["firstName"].ToString();
                            user.DOB = (DateTime)reader["dob"];
                            user.SSN = reader["ssn"].ToString();
                            user.Gender = reader["gender"].ToString();
                            user.StreetNumber = reader["streetNumber"].ToString();
                            user.City = reader["city"].ToString();
                            user.State = reader["state"].ToString();
                            user.Country = reader["country"].ToString();
                            user.Phone = reader["phone"].ToString();
                            user.Zipcode = reader["zipcode"].ToString();
                        }
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Returns the user details for an administrator based on a login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User GetUserAdminByLogin(Login login)
        {
            User user = new User();
            string selectStatement =
                        "SELECT u.userId as IdOfUser, lastName, firstName, dob, ssn, gender, streetNumber, city, state, country, phone, zipcode " +
                        "FROM Users u " +
                        "JOIN Administrators a on a.personId = u.userId " +
                        "WHERE a.personId = @userID";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userId", login.UserId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.UserId = int.Parse(reader["IdOfUser"].ToString());
                            user.LastName = reader["lastName"].ToString();
                            user.FirstName = reader["firstName"].ToString();
                            user.DOB = (DateTime)reader["dob"];
                            user.SSN = reader["ssn"].ToString();
                            user.Gender = reader["gender"].ToString();
                            user.StreetNumber = reader["streetNumber"].ToString();
                            user.City = reader["city"].ToString();
                            user.State = reader["state"].ToString();
                            user.Country = reader["country"].ToString();
                            user.Phone = reader["phone"].ToString();
                            user.Zipcode = reader["zipcode"].ToString();
                        }
                    }
                }
            }
            return user;
        }
    }
}
