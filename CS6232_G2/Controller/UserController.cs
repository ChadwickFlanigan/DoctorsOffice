﻿using CS6232_G2.DAL;
using CS6232_G2.Model;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the UserDAL
    /// </summary>
    public class UserController
    {
        private UserDAL _userDBDAL;

        public UserController()
        {
            _userDBDAL= new UserDAL();
        }

        public void Add(User user)
        {
            _userDBDAL.AddUser(user);
        }
    }
}