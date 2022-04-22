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
    }
}
