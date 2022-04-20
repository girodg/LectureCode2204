using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class WeaponFactory
    {
        public static FantasyWeapon CreateWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            return new FantasyWeapon(rarity, level, maxDamage, cost);
        }
    }
}
