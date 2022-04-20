﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Console.WriteLine($"Person ({name})");
            Name = name;
            Age = age;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I am hungry. Eating {food}. nom. nom.");
        }
    }
}
