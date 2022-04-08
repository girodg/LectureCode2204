using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PressAnyKey("Press any key to continue...");

            Console.WriteLine("-------Welcome to the Burger Barn--------");
            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //{ key, value }
                { "Cheesy Burger", 12.99F },
                { "Sweet Potato Fries", 3.99F },
                { "Cheese Curds", 4.99F },
                //{ "Cheese Curds", 5.99F }//throw an exception: key is already in the dictionary

            };
            //Add(key,value)
            menu.Add("Fountain Drinks", 2.99F);
            menu.Add("Fishwich", 8.99F);
            try
            {
                menu.Add("Fishwich", 8.99F);//throw an exception: key is already in the dictionary

            }
            catch (ArgumentNullException)
            {
            }
            catch (Exception)
            {
                Console.WriteLine("That item is already on the menu");
            }
            //[ key ] = value
            menu["Filet"] = 19.99F;
            menu["Filet"] = 29.99F;//will simply overwrite the value

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            foreach (var menuItem in menu)
            {
                float price = menuItem.Value;
                Console.WriteLine($"{price,10:C2} {menuItem.Key}");
            }

            PressAnyKey("Press any key to continue...");
            Challenges();
        }

        static void Challenges()
        {
            Random randy = new Random();
            Dictionary<string, double> pg2 = new Dictionary<string, double>()
            {
                {"Joseph", randy.NextDouble()*100},
                {"Michael", randy.NextDouble()*100},
                {"Paul", randy.NextDouble()*100},
                {"Jim", randy.NextDouble()*100}
            };
            pg2.Add("Japhet", randy.NextDouble() * 100);
            pg2.Add("Jairo", randy.NextDouble() * 100);
            pg2.Add("Moon", randy.NextDouble() * 100);
            pg2.Add("Zane", randy.NextDouble() * 100);

            pg2["Mason"] = randy.NextDouble() * 100;
            pg2["Jordan"] = randy.NextDouble() * 100;
            pg2["Brandon"] = randy.NextDouble() * 100;
            pg2["Joshua"] = randy.NextDouble() * 100;
            pg2["Arianna"] = randy.NextDouble() * 100;
            pg2["Armando"] = randy.NextDouble() * 100;
            pg2["Maurico"] = randy.NextDouble() * 100;
            pg2["Meggy"] = randy.NextDouble() * 100;
            pg2["Morgen"] = randy.NextDouble() * 100;
            pg2["Oscar"] = randy.NextDouble() * 100;

            PrintGrades(pg2);
        }

        static void PrintGrades(Dictionary<string, double> course)
        {
            Console.Clear();
            Console.WriteLine("-----------GRADES------------");
            foreach (var student in course)
            {
                double grade = student.Value;
                Console.Write(student.Key);
                Console.CursorLeft = 15;

                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow:
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                                           ConsoleColor.Green;
                Console.WriteLine($"{grade,7:N2}");
                Console.ResetColor();
            }
        }

        static void PressAnyKey(string prompt)
        {
            Console.WriteLine(prompt);
            Console.ReadKey();
        }
    }
}
