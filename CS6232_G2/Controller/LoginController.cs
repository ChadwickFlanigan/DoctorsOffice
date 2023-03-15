using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    public class LoginController
    {
        private LoginDAL _loginDBDAL;

        public LoginController()
        {
            _loginDBDAL = new LoginDAL();
        }

        public Login CheckIfLoginIsValid(Login login)
        {
            return _loginDBDAL.CheckIfUserIsValid(login);
        }
    }
}
