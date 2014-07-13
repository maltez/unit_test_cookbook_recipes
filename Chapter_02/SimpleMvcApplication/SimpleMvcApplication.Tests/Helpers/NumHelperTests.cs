using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMvcApplication.Helpers;

namespace SimpleMvcApplication.Tests.Helpers
{
    [TestClass]
    public class NumHelperTests
    {
        private readonly NumHelper _helper = new NumHelper();

        [TestMethod]
        public void GetFactorialOfPositiveNumberCheckResultPositiveTest()
        {
            const int number = 5;
            const int expectedResult = 120;

            int actualResult = _helper.Factorial(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
