using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Aimal";
            Console.WriteLine("Name: {0}", name);
            doThis(ref name);
            Console.WriteLine("Name: {0}", name);
            Console.ReadLine();
        }

        public static void doThis(ref string someString)
        {
            someString = "Khan";
            Console.WriteLine("Changed to: {0}", someString);
        }

    }
}
