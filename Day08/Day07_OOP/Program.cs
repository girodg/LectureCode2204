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

            Superhero bats = new Superhero("Batman", Superpower.Money, "Bruce Wayne", 35);
            Person alfred = new Person("Alfred Pennyworth", 85);
        }
    }
}
