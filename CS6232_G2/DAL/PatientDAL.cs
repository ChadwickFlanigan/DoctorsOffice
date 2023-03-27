using CS6232_G2.Model;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    /// <summary>
    /// The DAL for interacting with the Patients table
    /// </summary>
    public class PatientDAL
    {
        private static Patient patientToEdit;

        /// <summary>
        /// Returns the patient to be edited
        /// </summary>
        /// <returns></returns>
        public Patient GetPatientToEdit()
        {
            return patientToEdit;
        }

        /// <summary>
        /// sets the patient to be edited
        /// </summary>
        /// <returns></returns>
        public void SetPatientToEdit(Patient patient)
        {
            patientToEdit = patient;
        }

        /// <summary>
        /// Adds a new patient to the database
        /// </summary>
        /// <param name="user"></param>
        public void AddPatient(User user)
        {
            string insertStatement =
                "BEGIN TRANSACTION " +
                "DECLARE @LastId int; " +
                "INSERT INTO Users (lastName, firstName, dob, ssn, gender, streetNumber, city, state, country, phone, zipcode) " +
                "VALUES (@lastName, @firstName, @dob, @ssn, @gender, @streetNumber, @city, @state, @country, @phone, @zipcode); " +
                "SELECT @LastId = scope_identity(); " +
                "INSERT INTO Patients (UserId) " +
                "Values (@LastId); " +
                "COMMIT";
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
        /// Updates a user data in the database relating to the patient
        /// </summary>
        /// <param name="user"></param>
        public bool UpdatePatient(User user, User oldUser)
        {
            string insertStatement =
                "UPDATE Users SET " +
                "lastName = @lastName, " +
                "firstName = @firstName, " +
                "dob = @dob, " +
                "ssn = @ssn, " +
                "gender = @gender, " +
                "streetNumber = @streetNumber, " +
                "city = @city, " +
                "state = @state, " +
                "country = @country, " +
                "phone = @phone, " +
                "zipcode = @zipcode " +
                "WHERE userId = @oldUserId " +
                "AND lastName = @oldLastName " +
                "AND firstName = @oldFirstName " +
                "AND dob = @oldDob " +
                "AND ssn = @oldSsn " +
                "AND gender = @oldGender " +
                "AND streetNumber = @oldStreetNumber " +
                "AND city = @oldCity " +
                "AND state = @oldState " +
                "AND country = @oldCountry " +
                "AND phone = @oldPhone " +
                "AND zipcode = @oldZipcode ";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@lastName", user.LastName);
                insertCommand.Parameters.AddWithValue("@firstName", user.FirstName);
                insertCommand.Parameters.AddWithValue("@dob", user.DOB.ToShortDateString());
                insertCommand.Parameters.AddWithValue("@ssn", user.SSN);
                insertCommand.Parameters.AddWithValue("@gender", user.Gender);
                insertCommand.Parameters.AddWithValue("@streetNumber", user.StreetNumber);
                insertCommand.Parameters.AddWithValue("@city", user.City);
                insertCommand.Parameters.AddWithValue("@state", user.State);
                insertCommand.Parameters.AddWithValue("@country", user.Country);
                insertCommand.Parameters.AddWithValue("@phone", user.Phone);
                insertCommand.Parameters.AddWithValue("@zipcode", user.Zipcode);

                insertCommand.Parameters.AddWithValue("@oldUserId", oldUser.UserId);
                insertCommand.Parameters.AddWithValue("@oldLastName", oldUser.LastName);
                insertCommand.Parameters.AddWithValue("@oldFirstName", oldUser.FirstName);
                insertCommand.Parameters.AddWithValue("@oldDob", oldUser.DOB.ToShortDateString());
                insertCommand.Parameters.AddWithValue("@oldSsn", oldUser.SSN);
                insertCommand.Parameters.AddWithValue("@oldGender", oldUser.Gender);
                insertCommand.Parameters.AddWithValue("@oldStreetNumber", oldUser.StreetNumber);
                insertCommand.Parameters.AddWithValue("@oldCity", oldUser.City);
                insertCommand.Parameters.AddWithValue("@oldState", oldUser.State);
                insertCommand.Parameters.AddWithValue("@oldCountry", oldUser.Country);
                insertCommand.Parameters.AddWithValue("@oldPhone", oldUser.Phone);
                insertCommand.Parameters.AddWithValue("@oldZipcode", oldUser.Zipcode);

                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Returns the Patient associated with the given patientId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Patient GetPatientByPatientId(int id)
        {
            Patient patient = new Patient();
            string selectStatement =
                        "SELECT userId " +
                        "FROM Patients p " +
                        "WHERE patientId = @patientId";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientId", id);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patient.UserId = int.Parse(reader["userId"].ToString());
                        }
                    }
                }
            }
            return patient;
        }
    }
}
