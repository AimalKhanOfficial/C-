using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Aimal aimal = new Aimal();
            
            Asfand asfand = new Asfand();
            aimal.Call += asfand.RecieveCall;

            //This works
            //aimal.CallAsfand();

            Console.WriteLine(aimal.CallSomeFunction(aimal.ActualFunctionImplementation));

            Console.WriteLine("Operation Done.");
            Console.ReadLine();
        }
    }
}
