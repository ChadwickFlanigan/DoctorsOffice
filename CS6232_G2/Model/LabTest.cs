using System;

namespace CS6232_G2.Model
{
    /// <summary>
    /// Lab Test represents a lab test being requested and recorded in the database
    /// </summary>
    public class LabTest
    {
        public int TestCode { get; set; }
        public int PatientVisitId { get; set; }
        public DateTime TestDateTime { get; set; }
        public string Result { get; set; }
        public bool? Normal { get; set; }
    }
}
