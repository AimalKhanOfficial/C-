using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCSharpConcepts
{
    static class ExtendedMethod
    {
        public static void ModernNameShow(this Parent child)
        {
            Console.WriteLine("Hey, look at me, i'm an extended method!");
        }
    }
}
