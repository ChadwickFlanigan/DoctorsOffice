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
            return _searchDAL.GetPatientListByFirstAndLastName(fname, lname);
        }
        public List<Appointment> GetPatientsByDOB(DateTime dob)
        {
            if (dob == DateTime.MinValue || dob == null)
            {
                throw new ArgumentNullException("Date of birth cannot be null");
            }
            return _searchDAL.GetPatientsByDOB(dob); ;
        }
    }
}
