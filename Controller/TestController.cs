using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    class TestController
    {
        /// <summary>
        /// Interacts between the DAL and View
        /// </summary>
        public TestController() { }

        /// <summary>
        /// Gets a test with a testID
        /// </summary>
        /// <param name="testID">testID</param>
        /// <returns>Test</returns>
        public static Test GetTestWithID(int testID)
        {
            return TestDAL.GetTestWithID(testID);
        }

        /// <summary>
        /// Gets a list of tests
        /// </summary>
        /// <returns>Test list</returns>
        public static List<Test> GetTest()
        {
            return TestDAL.GetTest();
        }

        /// <summary>
        /// Creates a test item in the DB
        /// </summary>
        /// <param name="test">The test</param>
        /// <returns>true if successful</returns>
        public static bool CreateTest(Test test)
        {
            return TestDAL.CreateTest(test);
        }

        /// <summary>
        /// Updates a test
        /// </summary>
        /// <param name="oldTest">the old test</param>
        /// <param name="newTest">the new test</param>
        /// <returns>true if successful</returns>
        public static bool UpdateTest(Test oldTest, Test newTest)
        {
            return TestDAL.UpdateTest(oldTest, newTest);
        }
    }
}
