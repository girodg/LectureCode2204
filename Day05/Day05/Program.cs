using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Day05
{
    internal class Program
    {
        static Dictionary<int, ulong> _fibs = new Dictionary<int, ulong>();

        static void Main(string[] args)
        {
            _fibs.Add(0, 0);
            _fibs[1] = 1;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 145; i++)
            {
                sw.Restart();
                ulong fibResult = Fibonacci2(i);
                sw.Stop();
                long ms = sw.ElapsedMilliseconds;
                Console.Write($"Fib({i}) = {fibResult}");
                Console.CursorLeft = 40;
                Console.WriteLine($"{ms} ms");

            }
            long result = Factorial(5);//5!
            Console.WriteLine($"5! = {result}");
            Console.ReadKey();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            while (j < 100)
            {
                Console.WriteLine(j++);
            }
            int k = 0;
            Console.WriteLine("-----------RECURSION---------");
            Recursion(k);

            Bats(0);
            Console.WriteLine("Batman!");

        }

        static void Recursion(int k)
        {
            if (k < 100)//exit condition. Do you have your exit buddy?
            {
                Console.WriteLine(k);
                Recursion(k + 1);
                Console.WriteLine(k);
            }
        }

        static void Bats(int k)
        {
            if (k < 100)
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(++k);
            }
        }

        static ulong Fibonacci2(int N)
        {
            if (_fibs.TryGetValue(N, out ulong result))
                return result;

            result = Fibonacci2(N - 1) + Fibonacci2(N - 2);
            _fibs[N] = result;
            return result;
        }

        static long Fibonacci(int N)
        {
            if (N == 1) return 1;
            if (N <= 0) return 0;

            long result = Fibonacci(N - 1) + Fibonacci(N - 2);
            return result;
        }

        static long Factorial(int N)
        {
            if (N <= 1)
                return 1;

            long result = N * Factorial(N - 1);
            return result;
        }
    }
}
