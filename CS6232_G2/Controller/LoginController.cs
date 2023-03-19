using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// Login controller to communicate with the login dal
    /// </summary>
    public class LoginController
    {
        private LoginDAL _loginDBDAL;

        /// <summary>
        /// Constructor to instantiate a new controller
        /// </summary>
        public LoginController()
        {
            _loginDBDAL = new LoginDAL();
        }

        /// <summary>
        /// Checks the login fields are valid
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Login CheckIfLoginIsValid(Login login)
        {
            return _loginDBDAL.CheckIfUserIsValid(login);
        }
    }
}
