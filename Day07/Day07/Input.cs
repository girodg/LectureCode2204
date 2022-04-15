using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public static class Input
    {

        public static int ReadInteger(string prompt, int min, int max)
        {
            do
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int number) && number >= min && number <= max)
                    return number;
                Console.WriteLine($"Error. The number must be >= {min} and <= {max}");
            } while (true);
        }

        public static void ReadString(string prompt, ref string value)
        {
            do
            {
                Console.WriteLine(prompt);
                value = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(value))
                    return;
                Console.WriteLine("Error! please enter something.");
            } while (true);
        }

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            foreach (var item in options)
                Console.WriteLine(item);
            selection = ReadInteger(prompt, 1, options.Length);
        }
    }
}
