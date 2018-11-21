using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyToAndCloneArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;

            int[] newArr = new int[10];
            arr.CopyTo(newArr, 2);

            foreach (var x in newArr)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
