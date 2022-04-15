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
            Console.ReadKey();
            Console.WriteLine();
            DoIt("Kill them all!");

            //Task tasker = Task.Factory.StartNew(TaskDoIt);
            Task tasker = Task.Factory.StartNew(() =>
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
            }); 
            Task tasker2 = Task.Factory.StartNew(() =>
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
            });
            Console.ReadKey();
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
