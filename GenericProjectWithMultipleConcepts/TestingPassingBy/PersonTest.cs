using System;
using GenericProjectWithMultipleConcepts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingPassingBy
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PassByValue()
        {
            //Subject
            int number = 0;

            Person person = new Person();
            int result = person.PassByValue(number);
            Assert.AreEqual(number, 0, "Passed!");
        }

        [TestMethod]
        public void PassByRef()
        {
            //Subject
            int number = 0;

            Person person = new Person();
            int result = person.PassByRef(ref number);
            Assert.AreEqual(number, result, "Passed!");
        }
    }
}
