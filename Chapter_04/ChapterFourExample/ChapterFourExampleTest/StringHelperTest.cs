using System;
using System.Collections.Generic;
using ChapterFourExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChapterFourExampleTest
{
    [TestClass]
    public class StringHelperTest
    {
        private StringHelper _helper;

        [TestInitialize]
        public void Initalize()
        {
            _helper = new StringHelper();
        }

        [TestMethod]
        public void JoinList_InputListOfInts_GetStringSeparateCommasAndSpaces_Positive_Test()
        {
            var listOfNumbers = new List<int> {1, 2, 3};
            const string expectedResult = "1, 2, 3";

            string actualResult = _helper.JoinList(listOfNumbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AreEqualIgnoreCase_InputTwoEqualStrings_GetTrue_Positive_Test()
        {
            const string firstString = "Hello";
            const string secondString = "HELLO";

            bool actualResult = _helper.AreEqualIgnoreCase(firstString, secondString);

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void AreEqualIgnoreCase_InputTwoDifferentStrings_GetFalse_Negative_Test()
        {
            const string firstString = "Hello";
            const string secondString = "HELLO";

            bool actualResult = _helper.AreEqualIgnoreCase(firstString, secondString);

            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void GenerateSignature_InputValidFirstAndSecondName_GetSignature_Positive_Test()
        {
            const string firstName = "Nick";
            const string secondName = "Lototskiy";
            const string expectedResult = "Sincerely yours";

            string actualResult = _helper.GenerateSignature(firstName, secondName);

            StringAssert.StartsWith(actualResult, expectedResult);
        }
    }
}
