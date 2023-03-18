using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_G2.Controller
{
    public class SearchController
    {
        private SearchDAL _searchDAL;
        public SearchController()
        {
            _searchDAL= new SearchDAL();
        }
        public List<Appointment> GetPatientByFirstAndLastName(string fname, string lname)
        {
            if (fname == string.Empty || lname == string.Empty)
            {
                throw new ArgumentException("Please enter the patient first name and last name");
            }
            return _searchDAL.GetPatientListByFirstAndLastName(fname, lname);
        }
    }
}
