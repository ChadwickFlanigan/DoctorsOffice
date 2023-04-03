namespace CS6232_G2.Model
{
    /// <summary>
    /// Class representation of a nurse in the database
    /// </summary>
    public class Nurse : User
    {
        public int NurseId { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; }
    }
}
