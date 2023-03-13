using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    public class LoginController
    {
        private LoginDBDAL _loginDBDAL;

        public LoginController()
        {
            _loginDBDAL = new LoginDBDAL();
        }

        public bool CheckIfLoginIsValid(Login login)
        {
            return _loginDBDAL.CheckIfUserIsValid(login);
        }
    }
}
