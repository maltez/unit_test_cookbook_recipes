using ChapterFourExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChapterFourExampleTest
{
    [TestClass]
    public class FactorialTest
    {
        private Factorial _factorial;
        private static TestContext _testContext;

        [ClassInitialize]
        public static void AssemblyInitalize(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestInitialize]
        public void Initalize()
        {
            _factorial = new Factorial();
        }

        [TestMethod]
        public void CheckFactorial_Positive_Test()
        {
            const int  expectedResult = 2;
            int actualResult = _factorial.GetFactorial(2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void CleanUp()
        {
            _factorial.Dispose();
        }
    }
}
