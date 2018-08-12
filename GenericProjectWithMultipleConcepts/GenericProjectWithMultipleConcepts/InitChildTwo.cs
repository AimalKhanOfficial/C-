using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProjectWithMultipleConcepts
{
    public class InitChildTwo : InitParent
    {

        //Using the new keyword will hide the implementation of method "SayName" of parent class
        public void SayName()
        {
            Console.WriteLine("Init Child Two");
        }
    }
}
