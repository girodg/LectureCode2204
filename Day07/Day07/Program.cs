using System;
using System.Threading.Tasks;

namespace Day07
{
    internal class Program
    {
        static object locker = new object();
        enum Superpower { Strength, Swimming, Money, Telepathy }
        static void Main(string[] args)
        {
            int num = 5;
            Console.ForegroundColor = (num == 5) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"{"apple",10}");
            Console.WriteLine($"{"banana",10}");

            Console.ReadKey();
            Console.WriteLine();
            DoIt("Kill them all!");

            Task aTask = Task.Factory.StartNew(ATask);
            Task bTask = Task.Factory.StartNew(BTask);
            //Task tasker = Task.Factory.StartNew(() =>
            //{
            //    Random rando = new Random();
            //    while (true)
            //    {
            //        lock (locker)
            //        {
            //            Console.SetCursorPosition(
            //            rando.Next(Console.WindowWidth / 2),
            //            rando.Next(Console.WindowHeight - 1));
            //            Console.ForegroundColor = (ConsoleColor)rando.Next(16);
            //            Console.WriteLine("A");
            //            Console.ResetColor();
            //        }
            //    }
            //}); 
            //Task tasker2 = Task.Factory.StartNew(() =>
            //{
            //    Random rando = new Random();
            //    while (true)
            //    {
            //        lock (locker)
            //        {
            //            Console.SetCursorPosition(
            //                rando.Next(Console.WindowWidth / 2, Console.WindowWidth),
            //                rando.Next(Console.WindowHeight - 1));
            //            Console.BackgroundColor = (ConsoleColor)rando.Next(16);
            //            Console.WriteLine("B");
            //            Console.ResetColor();
            //        }
            //    }
            //});
            Console.ReadKey();
        }

        static void ATask()
        {
            Random rando = new Random();
            while (true)
            {
                lock (locker)
                {
                    Console.SetCursorPosition(
                    rando.Next(Console.WindowWidth / 2),
                    rando.Next(Console.WindowHeight - 1));
                    Console.ForegroundColor = (ConsoleColor)rando.Next(16);
                    Console.WriteLine("A");
                    Console.ResetColor();
                }
            }
        }

        static void BTask()
        {
            Random rando = new Random();
            while (true)
            {
                lock (locker)
                {
                    Console.SetCursorPosition(
                        rando.Next(Console.WindowWidth / 2, Console.WindowWidth),
                        rando.Next(Console.WindowHeight - 1));
                    Console.BackgroundColor = (ConsoleColor)rando.Next(16);
                    Console.WriteLine("B");
                    Console.ResetColor();
                }
            }
        }

        static void TaskDoIt()
        {
            Random rando = new Random();
            while (true)
            {
                Console.SetCursorPosition(
                    rando.Next(Console.WindowWidth),
                    rando.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rando.Next(16);
                Console.WriteLine("Do it!");
            }
        }

        /// <summary>
        /// Do what the emperor commands.
        /// </summary>
        /// <param name="emperorsCommand">The emperor's command</param>
        static void DoIt(string emperorsCommand)
        {

            Console.WriteLine($"Done it!{emperorsCommand}");
        }

    }


}
