using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the Tests table
    /// </summary>
    public class TestDAL
    {
        /// <summary>
        /// Returns all tests from the database
        /// </summary>
        /// <returns></returns>
        public List<Test> GetAllTests()
        {
            List<Test> tests = new List<Test>();

            string selectStatement = "select testCode, testName " +
                                     "from Tests";

            using (SqlConnection connection = DoctorsOfficeConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test
                            {
                                TestCode = Convert.ToInt32(reader["testCode"]),
                                TestName = reader["testName"].ToString()
                            };
                            tests.Add(test);
                        }
                    }
                }
            }
            return tests;
        }
    }
}
