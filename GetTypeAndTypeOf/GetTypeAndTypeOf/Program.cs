using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTypeAndTypeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic primitive numerical signed variable
            int age = 23;

            //Get Type method
            Console.WriteLine(age.GetType());

            //Type of operator
            Console.WriteLine(typeof(int));

            Console.ReadLine();
        }
    }
}
