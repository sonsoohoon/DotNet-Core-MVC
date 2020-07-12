using System;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Moq;
using MvcMovie.Controllers;
using MvcMovie.Services;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ApiControllerTest1()
        {
            var contoller = new ApiController();
            string result = contoller.GetPath(1,"shson");
            Console.WriteLine(result);
            Assert.AreEqual("value is 1 shson", result);
        }

        [TestMethod]
        public void HomeControllerTest1()
        {
            var mock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mock.Object);
            var result = controller.Index() as ViewResult;
            //index() 액션은 ViewResult를 반환한다.
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.IsTrue(string.IsNullOrEmpty(result.ViewName) || result.ViewName == "Index");
        }
    }
}
