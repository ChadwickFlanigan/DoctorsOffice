using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232_G2.DAL
{
    public class AppointmentDAL
    {
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            string selectStatement = "Select DoctorId, DoctorName From Doctors";

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor
                            {
                                DoctorId = Convert.ToInt32(reader["DoctorId"]),
                                DoctorName = reader["DoctorName"].ToString()
                            };

                            doctors.Add(doctor);
                        }
                    }
                }
            }

            return doctors;
        }
    }
}
