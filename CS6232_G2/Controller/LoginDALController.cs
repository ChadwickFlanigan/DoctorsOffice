using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    public class LoginDALController
    {
        private LoginDAL _loginDBDAL;

        public LoginDALController()
        {
            _loginDBDAL = new LoginDAL();
        }

        public bool CheckIfLoginIsValid(Login login)
        {
            return _loginDBDAL.CheckIfUserIsValid(login);
        }
    }
}
