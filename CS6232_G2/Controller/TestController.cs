using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_G2.Controller
{
    internal class TestController
    {
        private TestDAL _testDAL = new TestDAL();

        /// <summary>
        /// Returns all tests from the database
        /// </summary>
        /// <returns></returns>
        public List<Test> GetAllTests()
        {
            return this._testDAL.GetAllTests();
        }
    }
}
