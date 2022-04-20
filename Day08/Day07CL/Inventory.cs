using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        private int _capacity = 0;//size of our backpack
        private List<FantasyWeapon> _items = new List<FantasyWeapon>();//initializing the list

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if(value > 0)
                    _capacity = value;
            }
        }
        public List<FantasyWeapon> Items
        {
            get { return _items; }
            private set { _items = value; }
        }
        public int Count
        {
            get { return _items.Count; }
        }


        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            Capacity = capacity;
            Items = new List<FantasyWeapon>(items);
        }

        public void AddItem(FantasyWeapon item)
        {
            if (Count < Capacity)
                _items.Add(item);
            else
                throw new Exception("The backpack is full, fool!");
        }
    }
}
