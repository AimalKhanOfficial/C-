using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesAgain
{
    public class Class1
    {
        public delegate String HeyName(String xx);

        public void DoSomething(HeyName c)
        {
            c("HeyBoi");
        }
    }
}
