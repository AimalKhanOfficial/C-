using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class SomeClass
    {
        public string[] names = new string[10];

        public string this[int valu]
        {
            get { return this.names[valu]; }
            set { this.names[valu] = value; }
        }
    }
}
