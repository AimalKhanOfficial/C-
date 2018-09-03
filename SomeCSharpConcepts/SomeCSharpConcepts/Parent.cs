using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCSharpConcepts
{
    public class Parent
    {

        public virtual String name { get; set; }

        static Parent()
        {
            Console.WriteLine("In the Parents's static constructor");
        }

        public Parent(String name)
        {
            Console.WriteLine("In the parents's constructor");
            this.name = name;
        }

        public virtual void SayMyName()
        {
            Console.WriteLine("Hey guys!");
        }
    }
}
