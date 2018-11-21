using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsAndMOQ
{
    public class DBHandler : IPersonRepo
    {
        private List<Person> _persons = new List<Person>();

        public DBHandler()
        {
            _persons.Add(new Person() { FirstName = "Aimal", LastName = "Khan" });
            _persons.Add(new Person() { FirstName = "Asfandyar", LastName = "Khan" });
            _persons.Add(new Person() { FirstName = "Ayesha", LastName = "Khan" });
        }

        public List<Person> GetAllPerson()
        {
            return _persons;
        }
    }
}
