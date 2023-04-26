using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

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
                                test.Normal = Convert.ToBoolean(reader["normal"]);
                            }
                            else
                            {
                                test.Normal = false;
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
        /// <param name="labTests"> a LabTest object representing a Test ordered for a patient</param>
        public void OrderLabTest(List<LabTest> labTests)
        {
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (LabTest test in labTests)
                    {
                        SqlCommand insertUserCommand = new SqlCommand("INSERT INTO LabTest(testCode, patientVisitID) " +
                        "VALUES " +
                        "(@testCode, @patientVisitID);", connection, transaction);
                        insertUserCommand.Parameters.AddWithValue("@testCode", test.TestCode);
                        insertUserCommand.Parameters.AddWithValue("@patientVisitID", test.PatientVisitId);

                        insertUserCommand.ExecuteNonQuery();
                    }
                    transaction.Commit();
                } catch (Exception)
                {
                    transaction.Rollback();
                    throw;
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
                                test.Normal = Convert.ToBoolean(reader["normal"]);
                            }
                            else
                            {
                                test.Normal = false;
                            }

                            tests.Add(test);
                        }
                    }
                }
            }
            return tests;
        }

        /// <summary>
        /// method returning true if a test has been ordered, otherwise false
        /// </summary>
        /// <param name="test"></param>
        /// <returns>true or false depending on if test has been ordered</returns>
        public Boolean HasTestBeenOrdered(LabTest test)
        {
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand("SELECT testCode FROM LabTest WHERE testCode = @testCode " +
                    "AND patientVisitID = @patientVisitID;",
                connection);
                selectCommand.Parameters.AddWithValue("@testCode", test.TestCode);
                selectCommand.Parameters.AddWithValue("@patientVisitID", test.PatientVisitId);
                if (selectCommand.ExecuteScalar() != null)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// method calling on a stored procedure to get the statistics of performed lab tests in a given date range
        /// </summary>
        /// <param name="startDate">the starting date</param>
        /// <param name="endDate">the ending date</param>
        /// <returns></returns>
        public List<LabTestStatistic> GetLabTestStatistics(DateTime startDate, DateTime endDate)
        {
            List<LabTestStatistic> testStatistics = new List<LabTestStatistic>();

            string procedureCall = "getMostPerformedTestsDuringDates @startDate, @endDate";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(procedureCall, connection))
                {
                    selectCommand.Parameters.AddWithValue("@startDate", startDate.ToShortDateString());
                    selectCommand.Parameters.AddWithValue("@endDate", endDate.ToShortDateString());

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTestStatistic testStat = new LabTestStatistic
                            {
                                TestCode = Convert.ToInt32(reader["testCode"]),
                                TestName = Convert.ToString(reader["TestName"]),
                                QualifiedTestQuantity = Convert.ToInt32(reader["TotalQualifiedTests"]),
                                TotalTestQuantity = Convert.ToInt32(reader["TotalTests"]),
                                QualifiedPercentage = Convert.ToDouble(reader["PercentageQualifiedTests"]),
                                TotalNormal = Convert.ToInt32(reader["NormalResults"]),
                                TotalAbnormal = Convert.ToInt32(reader["TotalAbnormal"]),
                                PercentageEighteenToTwentyNine = Convert.ToDouble(reader["Percentage1829"]),
                                PercentageThirtyToThirtyNine = Convert.ToDouble(reader["Percentage3039"]),
                                PercentageOtherYears = Convert.ToDouble(reader["PercentageOtherYears"])
                            };

                            testStatistics.Add(testStat);
                        }
                    }
                }
            }
            return testStatistics;
        }
    }
}
