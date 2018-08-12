using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProjectWithMultipleConcepts
{
    public class Person : Parent
    {
        public readonly string Name = "Aimal Khan";
        public string Address { get; set; }


        public Person()
        {
            Console.WriteLine("Child Normal");
        }

        static Person()
        {
            Console.WriteLine("Child Static");
        }

        public Person(string name) : base(name)
        {
            this.Name = name;
        }

        public int PassByValue(int number)
        {
            number = 2;
            return number;
        }

        //Ref keyword specifies that we want want to see the change reflected in the actual passed reference type var
        public int PassByRef(ref int number)
        {
            number = 3;
            return number;
        }

        //Out keyword specifies that the provided param is uninitialized and needs to be initialized before use
        public int PassByOut(out int number)
        {
            number = 4;
            return number;
        }
    }
}