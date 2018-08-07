using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    public class Person
    {
        public String Name { get; set; }

        public string DisplayName(DisplayNameDelegate display)
        {
            return display(this);
        }
    }

    public delegate string DisplayNameDelegate(Person person);
}
