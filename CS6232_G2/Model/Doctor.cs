namespace CS6232_G2.Model
{
    /// <summary>
    /// Class representation of a doctor in the database
    /// </summary>
    public class Doctor : User
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
    }
}
