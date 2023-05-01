﻿using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// Gets the connection string
    /// </summary>
    public class DoctorsOfficeConnectionString
    {
        /// <summary>
        /// returns the connection string of the tech support DB
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=CS6232-G2;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}