using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in compareTriplets(new List<int>() { 17, 28, 30 }, new List<int>() { 99, 16, 8 }))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> listToReturn = new List<int>();

            int alice = 0;
            int bob = 0;

            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] == b[i])
                {
                    continue;
                }

                if (a[i] < b[i])
                {
                    bob++;
                }
                else
                {
                    alice++;
                }
            }

            listToReturn.Add(alice);
            listToReturn.Add(bob);
            return listToReturn;
        }
    }
}
