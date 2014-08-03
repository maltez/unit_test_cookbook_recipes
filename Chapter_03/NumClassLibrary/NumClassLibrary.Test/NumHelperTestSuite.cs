using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumClassLibrary.Test
{
    [TestClass]
    public class NumHelperTestSuite
    {
        private NumHelper _helperUnderTheTest;

        [TestInitialize]
        public void TestSetup()
        {
            _helperUnderTheTest = new NumHelper();
        }

        [TestMethod]
        public void GetFactorialOfPositiveNumber_CheckResult_PositiveTest()
        {
            const int inputNumber = 5;
            const long expectedResult = 120;

            long actualResult = _helperUnderTheTest.Factorial(inputNumber);

            Assert.AreEqual(expectedResult, actualResult, string.Format("Invalid result of Factorial method execution. Expected {0}. Actual {1} ", expectedResult, actualResult));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFactorialOfNegativeNumber_RiseInvalidArgumentException_NegativeTest()
        {
            const int inputNumber = -2;

            _helperUnderTheTest.Factorial(inputNumber);

            Assert.Fail("Invalid argument exception was not appear.");
        }

        [TestMethod]
        public void GetFactorialOfZero_ReturnsOne_PositiveTest()
        {
            const int inputNumber = 0;
            const long expectedResult = 1;

            long actualResult = _helperUnderTheTest.Factorial(inputNumber);

            Assert.AreEqual(expectedResult, actualResult, string.Format("Invalid result of Factorial method execution. Expected {0}. Actual {1} ", expectedResult, actualResult));
        }

        [TestMethod]
        public void GetFactorialOfOne_ReturnsOne_PositiveTest()
        {
            const int inputNumber = 1;
            const long expectedResult = 1;

            long actualResult = _helperUnderTheTest.Factorial(inputNumber);

            Assert.AreEqual(expectedResult, actualResult, string.Format("Invalid result of Factorial method execution. Expected {0}. Actual {1} ", expectedResult, actualResult));
        }
    }
}
