using CS6232_G2.DAL;
using CS6232_G2.Model;
using System.Collections.Generic;

namespace CS6232_G2.Controller
{
    /// <summary>
    /// The controller for the TestDAL
    /// </summary>
    public class TestController
    {
        private TestDAL _testDAL;

        /// <summary>
        /// The constructor for the TestController class
        /// </summary>
        public TestController()
        {
            _testDAL = new TestDAL();
        }

        /// <summary>
        /// Returns all tests for the database
        /// </summary>
        /// <returns></returns>
        public List<Test> GetAllTests()
        {
            return _testDAL.GetAllTests();
        }
    }
}
