using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsAndMOQ
{
    public class PersonRepository 
    {
        IPersonRepo db;

        public PersonRepository(IPersonRepo dbPersonRepo)
        {
            this.db = dbPersonRepo;
        }

        public List<Person> GetAllPerson()
        {
            List<Person> persons = db.GetAllPerson();
            return persons;
        }
    }
}
