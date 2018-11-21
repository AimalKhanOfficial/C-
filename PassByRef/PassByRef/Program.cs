using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
    internal class Program
    {
        
        enum MyColors
        {
            red = 112,
            yellow
        }

        struct MyStruct
        {
            public string FirstName;
            public string LastName;
            public void ShowFirstName()
            {
                Console.WriteLine(this.FirstName);
            }
        }

        private static void Main(string[] args)
        {

            //Types of Collections - 2: Generic and Normal
            //Normal Ones
            ArrayList list = new ArrayList();
            Hashtable hash = new Hashtable();
            hash.Add(11, 11);
            hash.Add(12, 12);
            hash.Add(13, 13);
            hash.Add(14, 14);

            foreach (var has in hash.Values)
            {
                Console.WriteLine(has);
            }

            //Generic Ones
            List<int> listG = new List<int>();
            Dictionary<int, int> dictG = new Dictionary<int, int>();


            //Reflections
            Type t = typeof (Person);
            Console.WriteLine(t.Assembly);

            Person aimal = new Person {FirstName = "Aimal"};
            AnotherClass a = new AnotherClass();
            aimal.MyEvent += a.HeyaRecieved;
            aimal.ShowFirstName();

            MyStruct s;
            s.FirstName = "Aimal Khan";
            s.LastName = "Khan";
            s.ShowFirstName();

            Console.WriteLine(MyColors.red);
            Console.WriteLine(MyColors.yellow);


            var value = "String";

            dynamic value2 = "Syring";

            Console.ReadLine();
        }

        public static void doThis(Person p)
        {
            p.FirstName = "Khan";
            Console.WriteLine("Changed to: {0}", p.FirstName);
        }
    }
}