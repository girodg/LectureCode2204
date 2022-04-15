using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;//Language Integrated Queries. database kind-of queries. SQL
using System.Threading;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PressAnyKey("Press any key to continue...");

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
            PrintMenu(menu);


            string itemToRemove = "Filet";
            bool wasRemoved = menu.Remove(itemToRemove);
            if (wasRemoved)
                Console.WriteLine($"{itemToRemove} was dropped from the menu.");
            else
                Console.WriteLine($"{itemToRemove} was not on the menu.");

            itemToRemove = "Chicken Nuggets";
            wasRemoved = menu.Remove(itemToRemove);
            if (wasRemoved)
                Console.WriteLine($"{itemToRemove} was dropped from the menu.");
            else
                Console.WriteLine($"{itemToRemove} was not on the menu.");
            PressAnyKey("Press any key to continue...");
            PrintMenu(menu);

            string menuItem = "Fishwich";
            if (menu.ContainsKey(menuItem))
            {
                //update the value
                menu[menuItem] += 5;
                float price = menu[menuItem];//will throw an exception if key is not found
                Console.WriteLine($"{menuItem} now costs {price,7:C2}. Thanks Putin.");
            }
            else
                Console.WriteLine($"{menuItem} is not on the menu.");

            if (menu.TryGetValue(menuItem, out float menuPrice))
                Console.WriteLine($"{menuItem} costs {menuPrice,7:C2}");
            else
                Console.WriteLine($"{menuItem} is not on the menu.");

            Console.WriteLine();

            PressAnyKey("Press any key to continue...");
            Challenges();
        }

        private static void PrintMenu(Dictionary<string, float> menu)
        {
            Console.Clear();
            Console.WriteLine("-------Welcome to the Burger Barn--------");
            foreach (var menuItem in menu)
            {
                float price = menuItem.Value;
                Console.WriteLine($"{price,10:C2} {menuItem.Key}");
            }
        }

        static void Challenges()
        {
            Random randy = new Random();//calling the constructor method
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
            CurveStudent(pg2);
            DropStudent(pg2);

        }

        private static void DropStudent(Dictionary<string, double> course)
        {
            do
            {
                Console.Write("Name of the student to drop: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) break;

                bool wasRemoved = course.Remove(name);
                if (wasRemoved)
                {
                    PrintGrades(course);
                    Console.WriteLine($"{name} was dropped from the course.");
                }
                else
                    Console.WriteLine($"{name} was not in the course."); 
            } while (true);
        }

        private static void CurveStudent(Dictionary<string, double> course)
        {
            do
            {
                Console.Write("Name of the student to curve: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) break;

                if(course.TryGetValue(name, out double grade))
                {
                    grade = (grade < 95) ? grade + 5 : 100;
                    course[name] = grade;
                    PrintGrades(course);
                    Console.WriteLine($"{name} was curved.");
                }
                else
                    Console.WriteLine($"{name} was not in the course.");
            } while (true);
        }

        static void PrintGrades(Dictionary<string, double> course)
        {
            Console.Clear();
            Console.WriteLine("-----------GRADES------------");
            var courseInfo = course.OrderByDescending(kvp => kvp.Value);
            foreach (var student in courseInfo)
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
