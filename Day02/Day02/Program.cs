using System;
using System.Collections.Generic;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayChallenge();

            List<bool> flags = new List<bool>(10);// { true, true, false };

            PrintInfo(flags);
            flags.Add(true);
            PrintInfo(flags);
            flags.Add(false);
            PrintInfo(flags);
            flags.Add(true);
            flags.Add(true);
            flags.Add(true);
            PrintInfo(flags);//count: 5 Capacity: 10
            flags.Add(true);
            flags.Add(true);
            flags.Add(true);
            flags.Add(true);
            PrintInfo(flags);//count: 9 Capacity: 10
            flags.Add(true);
            flags.Add(true);
            PrintInfo(flags);//count: 12 Capacity: 20
            //flags.TrimExcess();//reclaim the unused memory

            for (int i = 0; i < flags.Count; i++)
            {
                Console.WriteLine(flags[i]);
            }
        }

        private static void PrintInfo(List<bool> flags)
        {
            //Count: # of items ADDED to the list
            //Capacity: size of the internal array (or, .Length)
            Console.WriteLine($"Count: {flags.Count}\tCapacity: {flags.Capacity}");
        }

        static void ArrayChallenge()
        {
            Random randy = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = randy.Next();

            foreach (var number in nums)
                Console.WriteLine(number);
        }

        static void ListChallenge()
        {
            Random rando = new Random();
            List<double> grades = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(rando.NextDouble()*100);
            }
        }
    }
}
