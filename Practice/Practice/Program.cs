using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    struct someStruct
    {
        public String FirstName;

        public void someMethod()
        {
            Console.WriteLine("Hey");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            someStruct x;
            x.FirstName = "Khan";
            x.someMethod();
            Console.ReadLine();
        }
    }
}
