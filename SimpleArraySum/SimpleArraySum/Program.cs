using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(simpleArraySum(new int[] { 1, 2, 3, 4, 10, 11 }));
            Console.ReadLine();
        }

        static int simpleArraySum(int[] ar)
        {
            /*
             * Write your code here.
             */
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum = sum + ar[i];
            }

            return sum;
        }
    }
}
