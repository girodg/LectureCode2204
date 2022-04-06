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

            string otherMsg = string.Empty;
            TimeStamp(ref msg);
            PrintMessage(msg);

            Curve(94, 5, out int newGrade);
            Console.WriteLine(newGrade);

            MyFavoriteNumber(out int myFave);
            PrintMessage($"Your favorite number is {myFave}. weird.");

            PostFix(msg, 5);
            PostFix(msg);
        }

        static void PostFix(string msg, int num = 1)
        {
            Console.WriteLine($"{msg} #{num}");
        }

        static void MyFavoriteNumber(out int fave)
        {
            Console.Write("Please enter your favorite number: ");
            string numStr = Console.ReadLine();
            try
            {
                fave = int.Parse(numStr);
            }
            catch (Exception)
            {
                fave = 0;
                Console.WriteLine("That was not a number.");
            }
            //OR
            bool isGood = int.TryParse(numStr, out fave);
            if (isGood)
                Console.WriteLine("Thank you.");
            else
                Console.WriteLine("NO! Not a number.");
        }

        static void Curve(int grade, int curve, out int curvedGrade)
        {
            //ternary operator
            curvedGrade = (grade < 95) ? grade + curve : 100;
            ////OR
            //if (grade < 95)
            //    curvedGrade = grade + curve;
            //else
            //    curvedGrade = 100;
        }

        static void TimeStamp(ref string msg)
        {
            //$ - interpolated string
            msg = $"{DateTime.Now}: {msg}";
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

        static void PrintMessage(string messageToPrint = "Welcome to Gotham.")
        {
            Console.WriteLine(messageToPrint);
        }

        //static void PrintMessage()
        //{
        //    Console.WriteLine("Welcome to Gotham.");
        //}//ctrl+k,d to fix formatting

        static string GetMessage()
        {
            Console.Write("What is your secret identity? ");
            return Console.ReadLine();
        }
    }

}
