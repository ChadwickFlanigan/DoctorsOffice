using System.Data.SqlClient;
using CS6232_G2.Model;

namespace CS6232_G2.DAL
{
    internal class UserDAL
    {
        /// <summary>
        /// The DAL for interacting with the Users table
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
    }
}
