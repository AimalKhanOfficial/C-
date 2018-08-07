using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Aimal";

            Program main = new Program();
            Console.WriteLine(person.DisplayName(main.ActualDisplayImplementation));
            Console.ReadLine();
        }

        public string ActualDisplayImplementation(Person person)
        {
            return person.Name;
        }
    }
}
