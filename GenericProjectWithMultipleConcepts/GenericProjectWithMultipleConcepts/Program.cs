using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProjectWithMultipleConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aimal = new Person();
            Console.WriteLine(aimal.Name);


            InitParent parent = new InitChildOne();
            parent.SayName();

            //Method Hidden because of NEW keyword
            parent = new InitChildTwo();
            parent.SayName();

            Console.ReadLine();
        }
    }
}
