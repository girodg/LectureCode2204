using Day07CL;
using Day07CL.Banking;
using System;
using System.Collections.Generic;

namespace Day07_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acctNumber;
            BankAccount bank = new BankAccount(123456789, 987654321, 10000, BankAccountType.Savings);
            //bank.TypeOfAccount = (BankAccountType)20;// BankAccountType.Checking;//will call the set
            Console.WriteLine(bank.TypeOfAccount);//will call the get
            //bank._balance = double.MinValue;

            Inventory backpack = new Inventory(3, new List<FantasyWeapon>());
            //try
            //{
            //    backpack.AddItem("Book");
            //    backpack.AddItem("long sword");
            //    backpack.AddItem("round shield");
            //    backpack.AddItem("potion of invisibility");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 500, 100000);
            int damage = sting.DoDamage();
            Console.WriteLine($"We swing sting and do {damage} to the rat.");

            backpack.AddItem(sting);
            backpack.AddItem(new FantasyWeapon(WeaponRarity.Common, 1, 10, 100));
            backpack.AddItem(new BowWeapon(10, 15, WeaponRarity.Common, 5, 50, 200));
            backpack.PrintInventory();

            Superhero bats = new Superhero("Batman", Superpower.Money, "Bruce Wayne", 35);
            Person alfred = new Person("Alfred Pennyworth", 85);

            long dVal = 5;
            int iVal = (int)dVal;//explicit cast
            dVal = iVal;//implicit cast

            //UPCASTING
            //from a DERIVED variable to a BASE variable
            Person bruce = bats;//did this create a new object??

            //DOWNCASTING
            //from a BASE variable to a DERIVED variable
            //THIS IS NOT SAFE!
            //3 ways to make this safe

            //1. Explicit cast + try-catch
            try
            {
                Superhero hero = (Superhero)alfred;
            }
            catch (Exception)
            {
            }

            //2. use the 'as' keyword + check for null
            //   will assign NULL to the variable if it cannot downcast
            Superhero hero2 = alfred as Superhero;
            if(hero2 != null) { }

            //3. use pattern matching
            if (alfred is Superhero hero3) { }

            List<Person> characters = new List<Person>();
            characters.Add(alfred);
            characters.Add(bats);
            characters.Add(new Superhero("Superman", Superpower.Fly, "Clark Kent", 25));
            characters.Add(new Superhero("Flash", Superpower.Speed, "Barry Allen", 25));
        }
        static void Characters(List<Person> people)
        {

        }
    }
}
