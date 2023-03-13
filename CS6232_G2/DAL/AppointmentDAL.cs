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

        public bool SaveAppointment(Appointment appointment)
        {
            string query = string.Empty;

            if (appointment.AppointmentId <= 0)
            {
                query = "Insert into Appointments(patientId, doctorId, appointmentTime, reasonForVisit)" +
                "Values(@patientId, @doctorId, @appointmentTime, @reason";
            }
            else
            {
                query = "Update Appointments " +
                    "Set doctorId = @doctorId, appointmentTime = @appointmentTime, reasonForVisit = @reasonForVisit " +
                    "Where appointmentId = @appointmentId and doctorId = @doctorId";
            }

            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@patientId", appointment.PatientId);
                    saveCommand.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
                    saveCommand.Parameters.AddWithValue("@appointmentTime", appointment.AppointmentTime);
                    saveCommand.Parameters.AddWithValue("@reason", appointment.Reason);

                    if (appointment.AppointmentId > 0)
                    {
                        saveCommand.Parameters.AddWithValue("@appointmentId", appointment.AppointmentId);
                    }

                    return saveCommand.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}