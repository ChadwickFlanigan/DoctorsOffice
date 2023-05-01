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
        /// <summary>
        /// Gets a nurse login info by username
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Nurse GetNurseByLogin(Login login)
        {
            Nurse nurse = new Nurse();
            string selectStatement =
                        "SELECT nurseId, n.userId as nurseUserId, firstName, lastName, active " +
                        "FROM Nurses n " +
                        "JOIN Logins l on l.username = n.username " +
                        "JOIN Users u on u.userId = n.userId " +
                        "WHERE n.username = @username";
            using (SqlConnection connection = DoctorsOfficeConnectionString.GetConnection())
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
                            nurse.UserId = int.Parse(reader["nurseUserId"].ToString());
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.LastName = reader["lastName"].ToString();
                            nurse.Username = login.Username;
                        }
                    }
                }
            }
            return nurse;
        }

        /// <summary>
        /// Gets a nurse login info by username
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Nurse GetNurseById(int nurseId)
        {
            Nurse nurse = new Nurse();
            string selectStatement =
                        "SELECT n.nurseId, n.userId,lastName,firstName,dob,ssn,gender,streetNumber,city,state,phone,zipcode, n.username, password, active " +
                        "FROM Nurses n " +
                        "JOIN Logins l on l.username = n.username " +
                        "JOIN Users u on u.userId = n.userId " +
                        "WHERE n.nurseId = @nurseId";
            using (SqlConnection connection = DoctorsOfficeConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@nurseId", nurseId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nurse.NurseId = int.Parse(reader["nurseId"].ToString());
                            nurse.UserId = int.Parse(reader["userId"].ToString());
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.LastName = reader["lastName"].ToString();
                            nurse.DOB = Convert.ToDateTime(reader["dob"].ToString());
                            nurse.SSN = reader["ssn"].ToString();
                            nurse.Gender = reader["gender"].ToString();
                            nurse.StreetNumber = reader["streetNumber"].ToString();
                            nurse.City = reader["city"].ToString();
                            nurse.State = reader["state"].ToString();
                            nurse.Phone = reader["phone"].ToString();
                            nurse.Zipcode = reader["zipcode"].ToString();
                            nurse.Username = reader["username"].ToString();
                            nurse.Password = reader["password"].ToString();
                            nurse.Active = Convert.ToBoolean(reader["active"].ToString());
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
                selectStatement += "Where dob = @dob And lastName = @lastName ";
            }
            else if (dob.HasValue && string.IsNullOrEmpty(lastName))
            {
                selectStatement += "Where dob = @dob ";
            }
            else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                selectStatement += "Where firstName = @firstName And lastName = @lastName And @dob is null ";
            }
            else
            {
                return null;
            }

            using (SqlConnection connection = DoctorsOfficeConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (dob.HasValue)
                    {
                        selectCommand.Parameters.AddWithValue("@dob", dob.Value.ToShortDateString());
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
                                Active = Convert.ToBoolean(reader["active"])
                            };

                            nurseDetails.Add(nurse);
                        }
                    }
                }
            }
            return nurseDetails;
        }


        /// <summary>
        /// Adds or updates a nurse to the database
        /// </summary>
        /// <param name="nurse"></param>
        public void SaveNurse(Nurse nurse)
        {
            using (SqlConnection connection = DoctorsOfficeConnectionString.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                string userScript = "INSERT INTO Users (lastName, firstName, dob, ssn, gender, streetNumber, city, state, phone, zipcode) " +
                        "VALUES (@lastName, @firstName, @dob, @ssn, @gender, @streetNumber, @city, @state, @phone, @zipcode) SELECT scope_identity() as lastUserId ";

                if (nurse.NurseId > 0)
                {
                    userScript = "Update Users Set lastname = @lastName, firstname = @firstName, dob = @dob, ssn = @ssn, gender = Gender, " +
                        "streetNumber = @streetNumber, city = @city, state = @state, phone = @phone, zipcode = @zipcode " +
                        "where userId = @userId";
                }

                SqlCommand insertUserCommand = new SqlCommand(userScript, connection, transaction);
                insertUserCommand.Parameters.AddWithValue("@lastName", nurse.LastName);
                insertUserCommand.Parameters.AddWithValue("@firstName", nurse.FirstName);
                insertUserCommand.Parameters.AddWithValue("@dob", nurse.DOB);
                insertUserCommand.Parameters.AddWithValue("@ssn", nurse.SSN);
                insertUserCommand.Parameters.AddWithValue("@gender", nurse.Gender);
                insertUserCommand.Parameters.AddWithValue("@streetNumber", nurse.StreetNumber);
                insertUserCommand.Parameters.AddWithValue("@city", nurse.City);
                insertUserCommand.Parameters.AddWithValue("@state", nurse.State);
                insertUserCommand.Parameters.AddWithValue("@phone", nurse.Phone);
                insertUserCommand.Parameters.AddWithValue("@zipcode", nurse.Zipcode);

                if (nurse.NurseId > 0)
                {
                    insertUserCommand.Parameters.AddWithValue("@userId", nurse.UserId);
                }

                try
                {
                    var userId = insertUserCommand.ExecuteScalar();
                    int lastUser = Convert.ToInt32(userId);

                    if (nurse.NurseId == 0)
                    {
                        nurse.UserId = lastUser;
                    }

                    string loginScript = "Insert into Logins(username, password) values(@username, @password)";

                    if (nurse.NurseId > 0)
                    {
                        loginScript = "Update Logins Set password = @password where username = @username";
                    }

                    SqlCommand insertLoginCommand = new SqlCommand(loginScript, connection, transaction);
                    insertLoginCommand.Parameters.AddWithValue("@username", nurse.Username);
                    insertLoginCommand.Parameters.AddWithValue("@password", nurse.Password);
                    insertLoginCommand.ExecuteNonQuery();

                    string nurseScript = "INSERT INTO Nurses (UserId, username, active) Values (@userId, @username, @active) ";

                    if (nurse.NurseId > 0)
                    {
                        nurseScript = "Update Nurses Set username = @username, active = @active where userId = @userId";
                    }

                    SqlCommand insertPatientCommand = new SqlCommand(nurseScript, connection, transaction);
                    insertPatientCommand.Parameters.AddWithValue("@userId", nurse.UserId);
                    insertPatientCommand.Parameters.AddWithValue("@username", nurse.Username);
                    insertPatientCommand.Parameters.AddWithValue("@active", nurse.Active);
                    insertPatientCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
