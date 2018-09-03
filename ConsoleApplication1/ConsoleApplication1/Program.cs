using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        bool isConverted = false;
        char[] arr;
        int myPointer = -1;
        private string finalString = "";

        public static void Main(String[] args)
        {
            Program myProgRef = new Program();
            string reversed = myProgRef.ReverseString("abc");
            Console.ReadLine();
        }

        public String ReverseString(String myString)
        {
            if (myPointer == 0)
            {
                return "";
            }

            if (!isConverted)
            {
                arr = myString.ToCharArray();
                isConverted = true;
                myPointer = arr.Length;
            }

            myPointer--;
            finalString += arr[myPointer] + "";
            ReverseString(arr[myPointer] + "");

            return finalString;
        }
    }
}
