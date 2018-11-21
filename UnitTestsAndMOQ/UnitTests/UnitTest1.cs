using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestsAndMOQ;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPersons_ValidScenario_MustReturnElements()
        {
            //Arrange
            List<Person> persons = new List<Person>();
            persons.Add(new Person() {FirstName = "Aimal", LastName = "Khan"});
            persons.Add(new Person() { FirstName = "Asfand", LastName = "Khan" });
            persons.Add(new Person() { FirstName = "Ayesha", LastName = "Khan" });

            var xMock = new Mock<IPersonRepo>();
            xMock.Setup(x => x.GetAllPerson()).Returns(persons);

            //Act 
            PersonRepository p = new PersonRepository(xMock.Object);
            var result = p.GetAllPerson();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
