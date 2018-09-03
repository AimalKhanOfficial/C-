using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofactDI.Models
{
    public interface IPerson
    {
        List<Person> GetAllPerson();
        Person GetPersonViaName(string name);
    }
}
