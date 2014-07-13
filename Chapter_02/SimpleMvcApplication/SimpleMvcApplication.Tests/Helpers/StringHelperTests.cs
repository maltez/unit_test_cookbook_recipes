using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMvcApplication.Helpers;

namespace SimpleMvcApplication.Tests.Helpers
{
    /// <summary>
    /// Summary description for StringHelperTests
    /// </summary>
    [TestClass]
    public class StringHelperTests
    {
        private readonly StringHelper _helper = new StringHelper();

        [TestMethod]
        public void ConcatTwoStringsInputTwoStringsCheckResultPositiveTest()
        {
            const string firstString = "Hello";
            const string secondString = "World!";
            const string expectedResult = "Hello World!";

            string actualResult = _helper.ConcatTwoStrings(firstString, secondString);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
