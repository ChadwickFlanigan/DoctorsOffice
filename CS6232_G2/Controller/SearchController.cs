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
        public List<User> GetPatientByFirstAndLastName(string fname, string lname)
        {
            return _searchDAL.GetPatientListByFirstAndLastName(fname, lname);
        }
    }
}
