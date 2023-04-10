using CS6232_G2.DAL;
using CS6232_G2.Model;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the StateDAL
    /// </summary>
    public class StateController
    {
        private StateDAL _stateDAL;

        /// <summary>
        /// The constructor for the StateController class
        /// </summary>
        public StateController()
        {
            _stateDAL = new StateDAL();
        }

        /// <summary>
        /// Returns all states for the database
        /// </summary>
        /// <returns></returns>
        public List<State> GetAllStates()
        {
            return _stateDAL.GetAllStates();
        }
    }
}
