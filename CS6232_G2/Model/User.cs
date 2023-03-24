using System;

namespace CS6232_G2.Model
{
    /// <summary>
    /// The model class for the user table
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Zipcode { get; set; }
    }
}
