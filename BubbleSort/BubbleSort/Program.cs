using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {5, 1, 4, 2, 8};
            int tmp = -1;


            //Bubble Sort
            //            for(int i = 0; i < arr.Length; i++)
            //            {
            //                for (int j = 0; j < arr.Length; j++)
            //                {
            //                    if (j + 1 == arr.Length) break;
            //                    if (arr[j] > arr[j+1])
            //                    {
            //                        tmp = arr[j];
            //                        arr[j] = arr[j + 1];
            //                        arr[j + 1] = tmp;
            //                    }
            //                }
            //            }

            //Insertion sort - 5, 1, 4, 2, 8
            for (int i = 0; i < arr.Length; i++)
            {
                int sortedArraylength = i;
                int begin = 0;

                while (begin < i)
                {
                    if (begin + 1 == arr.Length)
                        break;
                    if (arr[begin] > arr[begin + 1])
                    {
                        tmp = arr[begin];
                        arr[begin] = arr[begin + 1];
                        arr[begin + 1] = tmp;
                    }
                    begin++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.ReadLine();
        }

        // int[] arr = new int[] { 5, 1, 4, 2, 8 };
//        private static void insertionSort(int[] arr)
//        {
//            for (int i = 2; i < arr.Length; i++)
//            {
//                int key = arr[i];
//
//                while ()
//                {
//                }
//
//            }
//           
//           
//        }
    }
}
