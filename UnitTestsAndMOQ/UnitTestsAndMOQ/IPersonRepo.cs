using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsAndMOQ
{
    public interface IPersonRepo
    {
        List<Person> GetAllPerson();
    }
}
