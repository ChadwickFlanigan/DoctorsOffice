using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the UserDAL
    /// </summary>
    public class UserController
    {
        private UserDAL _userDAL;

        /// <summary>
        /// The contructor for the UserController
        /// </summary>
        public UserController()
        {
            _userDAL= new UserDAL();
        }

        /// <summary>
        /// Adds a new user to the database
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            _userDAL.AddUser(user);
        }

        /// <summary>
        /// Gets the details for the user with the given id
        /// </summary>
        /// <param name="id"></param>
        public User GetUserById(int id)
        {
            return _userDAL.GetUserDetailsByID(id);
        }

        /// <summary>
        /// Gets the details for the user with the given id
        /// </summary>
        /// <param name="id"></param>
        public Patient GetUserFullNameById(int id)
        {
            return _userDAL.GetUserFullNameById(id);
        }

        /// <summary>
        /// Returns the details of a given nurse login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User GetUserNurseByLogin(Login login)
        {
            return _userDAL.GetUserNurseByLogin(login);
        }

        /// <summary>
        /// Returns the details of a given administrator login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User GetUserAdminByLogin(Login login)
        {
            return _userDAL.GetUserAdminByLogin(login);
        }
    }
}
