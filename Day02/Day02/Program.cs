using System;
using System.Collections.Generic;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            ArrayChallenge();

            #endregion

            #region Lists

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
            #endregion

            #region Challenges
            Console.WriteLine("Press any key for list challenge...");
            Console.ReadKey();
            ListChallenge();
            #endregion

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
            PrintGrades(grades);
        }

        static void PrintGrades(List<double> grades)
        {
            Console.Clear();
            string header = "---------------GRADES-------------";
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2 - 5;
            Console.SetCursorPosition(x - header.Length/2, y);
            Console.WriteLine(header);
            foreach (var grade in grades)
            {
                //Console.SetCursorPosition(x - header.Length / 2, Console.CursorTop);
                Console.CursorLeft = x - 3;

                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if(grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else  Console.ForegroundColor = ConsoleColor.Green;

                // ,6 means right-aligned 6 spaces
                // :N2 means number with 2 decimal places
                Console.WriteLine($"{grade,7:N3}");
                Console.ResetColor();
            }
        }
    }
}
