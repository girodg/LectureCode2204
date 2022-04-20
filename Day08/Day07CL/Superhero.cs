using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public enum Superpower
    {
        Fly, Swim, Speed, Money
    }
    public class Superhero : Person
    {
        public string Persona { get; set; }
        public Superpower Power { get; set; }

        public Superhero(string persona, Superpower power, string name, int age) : base(name, age)
        {
            Console.WriteLine($"\tSuperhero ({persona})");
            Persona = persona;
            Power = power;

            _height = 1.4F;
        }
    }
}
