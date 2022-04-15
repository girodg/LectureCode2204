using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 13, 7, 3, 42 };
            Print(nums);
            Swap(nums, 1, 2);
            Print(nums);

            string s1 = "Batman", s2 = "Aquaman";
            //returns...
            // -1 : less than
            //  0 : equal
            //  1 : greater than
            int compResult = s1.CompareTo(s2);
            if (compResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if (compResult == -1) Console.WriteLine($"{s1} LESS THAN {s2}");
            else if (compResult == 1) Console.WriteLine($"{s1} GREATER THAN {s2}");

            Split(nums.ToList());

            List<int> numbers = nums.ToList();
            int search = 7;
            int foundIndex = LinearSearch(numbers, search);
            if (foundIndex >= 0)
                Console.WriteLine($"{search} was found at index {foundIndex}");
            else
                Console.WriteLine($"{search} was not found");
            search = 100; 
            foundIndex = LinearSearch(numbers, search);
            if (foundIndex >= 0)
                Console.WriteLine($"{search} was found at index {foundIndex}");
            else
                Console.WriteLine($"{search} was not found");
        }

        static void Split(List<int> nums)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int mid = nums.Count / 2;
            for (int i = 0; i < nums.Count; i++)
            {
                if (i < mid)
                    left.Add(nums[i]);
                else
                    right.Add(nums[i]);
            }

            Console.WriteLine("----------LEFT-----------");
            foreach (var item in left)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------RIGHT-----------");
            foreach (var item in right)
            {
                Console.WriteLine(item);
            }


        }

        static int LinearSearch(List<int> numbers, int searchNumber)
        {
            int index = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private static void Print(int[] nums)
        {
            foreach (var item in nums)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        private static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;

            //(nums[index1], nums[index2]) = (nums[index2], nums[index1]);
        }
    }
}
