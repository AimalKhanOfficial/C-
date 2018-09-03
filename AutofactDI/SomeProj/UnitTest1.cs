using System;
using System.Collections.Generic;
using AutofactDI.Controllers;
using AutofactDI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssert;
using Moq;

namespace SomeProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IPerson> someMock = new Mock<IPerson>();
            someMock.Setup(a => a.GetAllPerson()).Returns(new List<Person>() {new Person() {FirstName = "xx", LastName = "yy"} });
            var controller = new HomeController(someMock.Object);
            controller.Index();
            controller.ShouldNotBeNull();
        }
    }
}
