using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMvcApplication.Helpers;

namespace SimpleMvcApplication.Tests.Helpers
{
    [TestClass]
    public class NumHelperTests
    {
        private readonly NumHelper _helper = new NumHelper();

        /// <summary>
        /// Test method - Factorial
        /// Factorial method returns results then equals product of all positive integers less than or equal to given number.
        /// Input parameter positive number 5.
        /// Expected result 120.
        /// Positive test.
        /// </summary>
        [TestMethod]
        public void GetFactorialOfPositiveNumberCheckResultPositiveTest()
        {
            const int number = 5;
            const long expectedResult = 120;

            long actualResult = _helper.Factorial(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
