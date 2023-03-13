using System;

namespace CS6232_G2.Model
{
    /// <summary>
    /// Defines what an new appointment looks like
    /// </summary>
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string Reason { get; set; }
    }
}
