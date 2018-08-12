using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProjectWithMultipleConcepts
{
    public class InitChildOne : InitParent
    {
        public override void SayName()
        {
            Console.WriteLine("InitChildOne");
        }
    }
}
