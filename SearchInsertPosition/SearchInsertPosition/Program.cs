using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Given a sorted array and a target value, return the index if the target is found. 
            //If not, return the index where it would be if it were inserted in order.
            //You may assume no duplicates in the array.

            //Example 1:
            //Input: [1, 3, 5, 6], 5
            //Output: 2

            //Example 2:
            //Input: [1, 3, 5, 6], 2
            //Output: 1


            Program program = new Program();
            Console.WriteLine(program.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
            Console.ReadLine();
        }

        public int SearchInsert(int[] nums, int target)
        {
            int possibleItemIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }

            //Item not found till now
            int tmp = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 == nums.Length)
                {
                    break;
                }

                //Sorting
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        tmp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tmp;
                    }
                }
            }

            bool assigned = false; 
            for (int i = 0; i < nums.Length; i++)
            {
                if (target < nums[i])
                {
                    possibleItemIndex = i;
                    assigned = true;
                    break;
                }
            }

            if (!assigned)
            {
                possibleItemIndex = nums.Length;
            }
            return possibleItemIndex;
        }
    }
}