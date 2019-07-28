using System;
using System.Web.Mvc;
using GameMngmt.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameMngmt.Tests.Controllers
{
    [TestClass]
    public class GameControllerTest
    {
        [TestMethod]
        public void TestDetailView()
        {
            var controller = new GameController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }
    }
}
