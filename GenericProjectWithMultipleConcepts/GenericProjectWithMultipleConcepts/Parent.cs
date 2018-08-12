using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProjectWithMultipleConcepts
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Normal");
        }

        static Parent()
        {
            Console.WriteLine("Parent Static");
        }

        public Parent(string name)
        {
            Console.WriteLine("Parent Constructor {0}", name);
        }
    }
}
