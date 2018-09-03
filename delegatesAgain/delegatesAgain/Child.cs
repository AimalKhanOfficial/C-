using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesAgain
{
    public class Child : abs
    {
        public override void absMethod()
        {
            Console.WriteLine("abs method");
        }
    }
}
