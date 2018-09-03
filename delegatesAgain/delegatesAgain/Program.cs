using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesAgain
{
    class Program
    {
        public delegate void DisplayMyName(string name);

        static void Main(string[] args)
        {
            //dm("Aimal");

            Class1 class1 = new Class1();
            //class1.DoSomething(ShowName);


//            Publisher publisher = new Publisher();
//            Subscriber subscriber = new Subscriber();
//            publisher.myEvent += subscriber.asd;
//
//            publisher.DoSomething();
              
              abs a = new Child();
              a.nonabsmethod();
            a.absMethod();

            Console.ReadLine();
        }

        public static String ShowName(string name)
        {
            return name;
        }
    }
}
