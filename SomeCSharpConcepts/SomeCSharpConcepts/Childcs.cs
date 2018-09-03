using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCSharpConcepts
{
    public class Childcs : Parent, IDisposable
    {
        public const int hey = 10;

        public override void SayMyName()
        {
            Console.WriteLine("Aimal");
        }

        static Childcs()
        {
            Console.WriteLine("In the Child's static constructor");
        }

        public void Hey()
        {
            for (uint i = 0; i < UInt32.MaxValue; i++)
            {
                Console.WriteLine("hey aimal");
            }
        }
        

        public Childcs(string name) : base(name)
        {
            Console.WriteLine("In the child's constructor");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        public void changeValue(out int number)
        {
            number = 10;
        }

        public void Dispose()
        {
            Console.WriteLine("Time to dispose");
        }
    }
}
