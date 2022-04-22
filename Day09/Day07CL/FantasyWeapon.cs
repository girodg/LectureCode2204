using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; set; }
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int Cost { get; set; }

        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Cost = cost;
        }

        //public int DoDamage()
        //{
        //    Random randy = new Random();
        //    return (int)(MaxDamage * randy.NextDouble());
        //}

        public int DoDamage(int enchantment = 0)
        {
            Random randy = new Random();
            return (int)((MaxDamage + enchantment) * randy.NextDouble());
        }

        public virtual void Display()
        {
            Console.WriteLine($"I have a level {Level} {Rarity} weapon that can do {MaxDamage} damage. It costs {Cost}.");

        }
    }
}
