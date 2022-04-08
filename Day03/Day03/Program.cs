using System;
using System.Collections.Generic;

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

            foreach (var menuItem in menu)
            {
                float price = menuItem.Value;
                Console.WriteLine($"{price,10:C2} {menuItem.Key}");
            }
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

            foreach (KeyValuePair<string,double> student in pg2)
            {
                string name = student.Key;
                double grade = student.Value;

            }

        }

        static void PressAnyKey(string prompt)
        {
            Console.WriteLine(prompt);
            Console.ReadKey();
        }
    }
}
