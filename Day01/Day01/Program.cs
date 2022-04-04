using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            string msg = GetMessage();
            int[] nums;// = new int[5];
            int n1 = 15;
            int n2 = 2;
            int sum = Add(n1, n2);
        }

        static int Add(int num1, int num2)//Pass By Value (think Copy)
        {
            num1 += 10;
            return num1 + num2;
        }

        static void PrintMessage()
        {
            Console.WriteLine("Welcome to Gotham.");
        }//ctrl+k,d to fix formatting

        static string GetMessage()
        {
            Console.Write("What is your secret identity? ");
            return Console.ReadLine();
        }
    }

}
