using CS6232_G2.Model;
using System;
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

            string selectStatement = "select testCode, patientVisitID, testDateTime, result, normal " +
                                     "from LabTest " +
                                     "where testCode = @testCode and patientVisitID = @patientVisitId;";

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
                                TestCode = Convert.ToInt32(reader["testCode"]),
                                PatientVisitId = Convert.ToInt32(reader["patientVisitID"]),
                            };



                            if (reader["testDateTime"] != DBNull.Value)
                            {
                                test.TestDateTime = Convert.ToDateTime(reader["testDateTime"]);
                            }
                            if (reader["result"] != DBNull.Value)
                            {
                                test.Result = reader["result"].ToString();
                            }
                            if (reader["normal"] != DBNull.Value)
                            {
                                test.Normal = reader["normal"].ToString() == "1" ? true : false;
                            }
                            tests.Add(test);
                        }
                    }
                }
            }
            return tests;
        }

        /// <summary>
        /// method to insert a labtest into the datebase.
        /// </summary>
        /// <param name="labTest"> a LabTest object representing a Test ordered for a patient</param>
        public void OrderLabTest(LabTest labTest)
        {
            string insertString = "INSERT INTO LabTest(testCode, patientVisitID) " +
                                     "VALUES " +
                                     "(@testCode, @patientVisitID);";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertStatement = new SqlCommand(insertString, connection))
                {
                    insertStatement.Parameters.AddWithValue("@testCode", labTest.TestCode);
                    insertStatement.Parameters.AddWithValue("@patientVisitID", labTest.PatientVisitId);

                    insertStatement.ExecuteNonQuery();

                }
            }
        }

        /// <summary>
        /// method called to update the results of a LabTest in the DB
        /// </summary>
        /// <param name="test">a LabTest object</param>
        public void UpdateLabTestResults(LabTest test)
        {
            string updateString = "UPDATE LabTest " +
                "SET testDateTime = @testDateTime, result = @result, normal = @normal " +
                "WHERE testCode = @testCode AND patientVisitID = @patientVisitID;";

            using (SqlConnection connetion = G2ProjectConnectionString.GetConnection())
            {
                connetion.Open();
                using (SqlCommand updateStatement = new SqlCommand(updateString, connetion))
                {
                    updateStatement.Parameters.AddWithValue("@testDateTime", test.TestDateTime);
                    updateStatement.Parameters.AddWithValue("@result", test.Result);
                    updateStatement.Parameters.AddWithValue("@normal", test.Normal);
                    updateStatement.Parameters.AddWithValue("@testCode", test.TestCode);
                    updateStatement.Parameters.AddWithValue("@patientVisitID", test.PatientVisitId);

                    updateStatement.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Returns all tests for an appointment
        /// </summary>
        /// <returns></returns>
        public List<LabTest> GetLabTestByVistId(int patientVisitId)
        {
            List<LabTest> tests = new List<LabTest>();

            string selectStatement = "select testCode, patientVisitID, testDateTime, result, normal " +
                                     "from LabTest " +
                                     "where patientVisitID = @patientVisitId;";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientVisitId", patientVisitId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTest test = new LabTest
                            {
                                TestCode = Convert.ToInt32(reader["testCode"]),
                                PatientVisitId = Convert.ToInt32(reader["patientVisitID"]),
                            };

                            if (reader["testDateTime"] != DBNull.Value)
                            {
                                test.TestDateTime = Convert.ToDateTime(reader["testDateTime"]);
                            }
                            if (reader["result"] != DBNull.Value)
                            {
                                test.Result = reader["result"].ToString();
                            }
                            if (reader["normal"] != DBNull.Value)
                            {
                                test.Normal = reader["normal"].ToString() == "1" ? true : false;
                            }

                            tests.Add(test);
                    }
                }
            }
        }
            return tests;
        }
}
}
