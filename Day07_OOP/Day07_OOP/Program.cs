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

            Inventory backpack = new Inventory(3, new List<string>());
            try
            {
                backpack.AddItem("Book");
                backpack.AddItem("long sword");
                backpack.AddItem("round shield");
                backpack.AddItem("potion of invisibility");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
