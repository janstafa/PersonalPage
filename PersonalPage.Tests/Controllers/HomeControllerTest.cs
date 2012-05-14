﻿using System;
using System.Web.Mvc;
using NUnit.Framework;
using PersonalPage.Controllers;

namespace PersonalPage.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test, Category("IntegrationTest")]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }

        [Test, Category("UnitTest")]
        public void Contact()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
