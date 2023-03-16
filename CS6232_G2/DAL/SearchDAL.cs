using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_G2.DAL
{

    public class SearchDAL
    {
        private List<User> _user;

        public List<User> GetPatientListByFirstAndLastName(string fname, string lname)
        {
            return _user;
        }
    }
}
