using System;

namespace CS6232_G2.Model
{
    /// <summary>
    /// Class representation of a patient visit in the database
    /// </summary>
    public class PatientVisit
    {
        public int PatientVisitID { get; set; }
        public DateTime VisitDateAndTime { get; set; }
        public DateTime AppointmentTime { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public decimal Temperature { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }
        public string InitialDiagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
        public int NurseID { get; set; }
        public int AppointmentID { get; set; }
    }
}
