using CS6232_G2.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the LabTests table
    /// </summary>
    public class LabTestDAL
    {
        /// <summary>
        /// Returns all tests from the database
        /// </summary>
        /// <returns></returns>
        public List<LabTest> GetLabTestByVistIdAndTestCode(int patientVisitId, int testCode)
        {
            List<LabTest> tests = new List<LabTest>();

            string selectStatement = "select testDateTime, result, normal " +
                                     "from LabTest" +
                                     "where testCode = @testCode and patientVisitID = @patientVisitId";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@testCode", testCode);
                    selectCommand.Parameters.AddWithValue("@patientVisitId", patientVisitId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTest test = new LabTest
                            {
                                //TestCode = Convert.ToInt32(reader["testCode"]),
                                //TestName = reader["testName"].ToString()
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
