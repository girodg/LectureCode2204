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
