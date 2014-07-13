using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMvcApplication.Controllers;

namespace SimpleMvcApplication.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        private HomeController _controller;

        [TestInitialize]
        public void TestSetup()
        {
            _controller = new HomeController();
        }

        [TestMethod]
        public void IndexNotNullResponseTest()
        {
            var result = _controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index()
        {
            var result = _controller.Index() as ViewResult;
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            var result = _controller.About() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AboutResultResponseValue()
        {
            var result = _controller.About() as ViewResult;
            Assert.AreEqual("Your app description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            var result = _controller.Contact() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ContactResultResponseValue()
        {
            var result = _controller.Contact() as ViewResult;
            Assert.AreEqual("Your contact page.", result.ViewBag.Message);
        }
    }
}
