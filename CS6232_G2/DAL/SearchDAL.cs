using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232_G2.DAL
{

    public class SearchDAL
    {

        public List<Appointment> GetPatientListByFirstAndLastName(string firstName, string lastName)
        {
            List<Appointment> patientsdetails = new List<Appointment>();


            string selectStatement = "SELECT doctorId,patientId,appointmentTime ,reasonsForVisit, firstName, lastName " +
                "FROM Appointments a inner join users u on u.userId = a.appointmentId " +
                "Where firstName = @firstName And lastName =@lastName";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@firstName", firstName);
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment patients = new Appointment();
                            {
                                patients.DoctorId = Convert.ToInt32(reader["doctorId"]);
                                patients.AppointmentTime = Convert.ToDateTime(reader["appointmentTime"]);
                                patients.PatientId = Convert.ToInt32(reader["patientId"]);
                                patients.Reason = reader["reasonsForVisit"].ToString();

                                patientsdetails.Add(patients);
                            };

                        }
                    }
                }
            }

            return patientsdetails;
        }

        public List<Appointment> GetPatientsByDOB(DateTime dob)
        {
            List<Appointment> patientsdetails = new List<Appointment>();
            string selectStatement = "SELECT doctorId,patientId,appointmentTime ,reasonsForVisit, dob " +
               "FROM Appointments a inner join users u on u.userId = a.appointmentId " +
               "Where dob = @dob ";
            using (SqlConnection connection = G2ProjectConnectionString.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@dob", dob);
                    

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment patients = new Appointment();
                            {
                                patients.DoctorId = Convert.ToInt32(reader["doctorId"]);
                                patients.AppointmentTime = Convert.ToDateTime(reader["appointmentTime"]);
                                patients.PatientId = Convert.ToInt32(reader["patientId"]);
                                patients.Reason = reader["reasonsForVisit"].ToString();

                                patientsdetails.Add(patients);
                            };

                        }
                    }
                }
            }
            return patientsdetails;
        }
    }
}
