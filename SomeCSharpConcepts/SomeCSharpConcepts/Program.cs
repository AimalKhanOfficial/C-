using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace SomeCSharpConcepts
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Childcs c = new Childcs("Aimak");
            
            //Console.WriteLine(Childcs.hey);


            var someValue = new
            {
                firstName = "Aimal",
                lastName = "Khan"
            };

            Console.WriteLine(someValue.firstName);


//            Parent p = new Childcs("Aimal");
//            p.ModernNameShow();
//            Childcs c = new Childcs("Khan");
//            c.ModernNameShow();
//            
//            int x = 2;
//            Console.WriteLine("Before: {0}", x);
//            c.changeValue(out x);
//            Console.WriteLine("After: {0}", x);
//
//            Dictionary<int, string> dict = new Dictionary<int, string>();
//            dict.Add(1, "Aimal");
//
//            foreach (KeyValuePair<int, string> key in dict)
//            {
//                Console.WriteLine(key.Value);
//            }

            //Console.WriteLine(isJumbledNumberSecon(123));
//            object[] arr = new object[] {1, "Aimal"};
//
//
//            Type t = typeof (object);
//            Console.WriteLine(t.FullName);
//            Console.WriteLine(t.Assembly);
//            Console.WriteLine(t.IsEnum);
//            Console.WriteLine(t.DeclaringType);
//
//            foreach (var x in arr)
//            {
//                Console.WriteLine(x);
//            }

            

            Console.ReadLine();
        }

        public static bool isJumbledNumber(int number)
        {
            char[] arr = number.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 == arr.Length)
                {
                    break;
                }

                if (i == 0)
                {
                    if (arr[i] + 1 != arr[i + 1] && arr[i] - 1 != arr[i + 1])
                    {
                        return false;
                    }
                }
                else if (i == arr.Length - 1)
                {
                    if (arr[i] + 1 != arr[i - 1] && arr[i] - 1 != arr[i - 1])
                    {
                        return false;
                    }
                }
                else
                {
                    if (arr[i] + 1 != arr[i - 1] && arr[i] - 1 != arr[i - 1])
                    {
                        return false;
                    }

                    if (arr[i] + 1 != arr[i + 1] && arr[i] - 1 != arr[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool isJumbledNumberSecon(int number)
        {
            while (number%10 != 0)
            {
                int digit1 = number%10;
                int digit2 = (number/10)%10;
                if (Math.Abs(digit2 - digit1) > 1 && digit2 != 0) return false;
                number /= 10;
            }
            return true;
        }
    }
}