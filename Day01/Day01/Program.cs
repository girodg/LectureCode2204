using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            PrintMessage();
            string msg = GetMessage();
            int[] nums;// = new int[5];
            int n1 = 15;
            int n2 = 2;
            int sum = Add(n1, n2);
            PrintMessage(msg);

            Factor(ref n1, 3);//in the method, n1 has a new name (number)
            Factor(ref n2, 2);//in the method, n2 has a new name (number)
            Console.WriteLine(n1);
        }

        static void Factor(ref int number, int factor)
        {
            number *= factor; 
        }

        static int Add(int num1, int num2)//Pass By Value (think Copy)
        {
            num1 += 10;
            return num1 + num2;
        }

        static void PrintMessage(string messageToPrint)
        {
            Console.WriteLine(messageToPrint);
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
