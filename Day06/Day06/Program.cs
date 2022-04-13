using System;

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
        }

        private static void Print(int[] nums)
        {
            foreach (var item in nums)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        private static void Swap(int[] nums, int index1, int index2)
        {
            (nums[index1], nums[index2]) = (nums[index2], nums[index1]);
        }
    }
}
