using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofactDI.Models
{
    public class PersonRepository : IPerson
    {
        private List<Person> _persons = new List<Person>();

        public PersonRepository()
        {
            _persons.Add(new Person() { FirstName = "Aimal", LastName = "Khan" });
            _persons.Add(new Person() { FirstName = "Asfandyar", LastName = "Khan" });
            _persons.Add(new Person() { FirstName = "Ayesha", LastName = "Khan" });
        }
        
        public List<Person> GetAllPerson()
        {
            return _persons;
        }

        public Person GetPersonViaName(string name)
        {
            return _persons.Find(a => a.FirstName.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}