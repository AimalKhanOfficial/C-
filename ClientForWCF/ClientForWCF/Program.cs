using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientForWCF.WCFExampleService;

namespace ClientForWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceRef = new Service1Client();
            Console.WriteLine(serviceRef.GetData(99));
            serviceRef.GetDataUsingDataContract(new CompositeType()
            {
                BoolValue = false 
            }); 
            Console.ReadLine();
        }
    }
}
