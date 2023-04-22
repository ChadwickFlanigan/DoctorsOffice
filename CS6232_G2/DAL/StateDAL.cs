using CS6232_G2.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the State Table
    /// </summary>
    public class StateDAL
    {
        /// <summary>
        /// Returns all the states in the database
        /// </summary>
        /// <returns></returns>
        public List<State> GetAllStates()
        {
            List<State> states = new List<State>();

            string selectStatement = "select stateCode, stateName " +
                                     "from States";

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
                                StateCode = reader["stateCode"].ToString(),
                                StateName = reader["stateName"].ToString()
                            };
                            states.Add(state);
                        }
                    }
                }
            }
            return states;
        }

        /// <summary>
        /// Returns all the state codes in the database
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllStateCodes()
        {
            List<string> states = new List<string>();

            string selectStatement = "select stateCode, stateName " +
                                     "from States";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string state = reader["stateCode"].ToString();
                            states.Add(state);
                        }
                    }
                }
            }
            return states;
        }
    }
}
