using System.Diagnostics;
using MSTest.ProjectUnderTheTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest.UnitTest
{
    [TestClass]
    public class FirstTestSuite
    {
        [TestMethod]
        public void SumTwoPositiveNumbersTest()
        {
            // Arrange
            Trace.WriteLine("Test start");
            const int firstNumber = 1;
            const int secondNumber = 3;
            var testClass = new ClassForTest();

            // Act
            int result = testClass.SumOfTwoNumbers(firstNumber, secondNumber);
            
            //Assert
            Assert.AreEqual(4, result);
            Trace.WriteLine("Test finished");
        }
    }
}
