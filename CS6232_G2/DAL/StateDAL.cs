using CS6232_G2.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the State Table
    /// </summary>
    public class StateDAL
    {
        public List<State> GetAllStates()
        {
            List<State> states = new List<State>();

            string selectStatement = "select testCode, testName " +
                                     "from Tests";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            State state = new State
                            {
                                StateCode = Convert.ToInt32(reader["testCode"]),
                                StateName = reader["testName"].ToString()
                            };
                            states.Add(state);
                        }
                    }
                }
            }
            return states;
        }
    }
}
