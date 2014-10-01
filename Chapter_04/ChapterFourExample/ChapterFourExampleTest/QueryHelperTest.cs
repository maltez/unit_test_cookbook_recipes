using System.Collections.Generic;
using ChapterFourExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChapterFourExampleTest
{
    [TestClass]
    public class QueryHelperTest
    {

        private QueryHelper _helper;

        [TestInitialize]
        public void Initalize()
        {
            _helper = new QueryHelper();
        }

        [TestMethod]
        public void CheckQuery_InputZero_ExpectedHamburger_Positive_Test()
        {
            const string expectedResult = "Hamburger";
            string actualResult = _helper.GetDishById(0);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckQuery_InputBigNumber_ExpectedNull_Positive_Test()
        {
            string actualResult = _helper.GetDishById(100);

            Assert.IsNull(actualResult);
        }

        [TestMethod]
        public void GetAllDishes_InvokeMethod_GetAllDishes_Positive_Test()
        {
            var expectedResult = new List<string>
            {
                "Hamburger",
                "BigMac",
                "MacFlury",
                "ChickenMacNagets",
                "Shake",
                "IceCream"
            };

            List<string> actualResult = _helper.GetAllDishes();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
