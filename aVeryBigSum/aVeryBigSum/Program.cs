using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {

//            Calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.
//
//            Function Description
//
//            Complete the aVeryBigSum function in the editor below.It must return the sum of all array elements.
//
//            aVeryBigSum has the following parameter(s):
//
//            ar: an array of integers .

            Console.WriteLine(aVeryBigSum(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }));
            Console.Read();

        }

        static long aVeryBigSum(long[] ar)
        {
            long bigSum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                bigSum += ar[i];
            }
            return bigSum;
        }
    }
}
