namespace CS6232_G2.Model
{
    /// <summary>
    /// Login model represents the Login fields and other properties required to determine the user
    /// </summary>
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int NurseId { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public int AdministratorId { get; set; }
    }
}
