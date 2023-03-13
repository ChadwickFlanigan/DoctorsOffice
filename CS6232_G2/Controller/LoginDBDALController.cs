using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    public class LoginDBDALController
    {
        private LoginDBDAL _loginDBDAL;

        public LoginDBDALController()
        {
            _loginDBDAL = new LoginDBDAL();
        }

        public bool CheckIfLoginIsValid(Login login)
        {
            return _loginDBDAL.CheckIfUserIsValid(login);
        }
    }
}
