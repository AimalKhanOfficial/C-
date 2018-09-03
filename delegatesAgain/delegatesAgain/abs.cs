using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesAgain
{
    public abstract class abs
    {
        public void nonabsmethod()
        {
            Console.WriteLine("Hey i'm a non abstract method!");
        }

        public abs()
        {
            
        }

        public abstract void absMethod();
    }
}
