using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsAndMOQ
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository personRepo = new PersonRepository(new DBHandler());
            foreach (var VARIABLE in personRepo.GetAllPerson())
            {
                Console.WriteLine(VARIABLE.FirstName);   
            }
            Console.ReadLine();
        }
    }
}
