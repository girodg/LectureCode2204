using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static Inventory Clone(this Inventory inventory)
        {
            Inventory inv = new Inventory(inventory.Capacity, inventory.Items.ToList());
            return inv;
        }

        public static List<BowWeapon> Bows(this Inventory inventory)
        {
            return inventory.Items.OfType<BowWeapon>().ToList();//Linq
            //List<BowWeapon> bows = new List<BowWeapon>();
            //foreach (FantasyWeapon item in inventory.Items)
            //{
            //    if (item is BowWeapon) bows.Add(item as BowWeapon);
            //}
            //return bows;
        }
    }
}
