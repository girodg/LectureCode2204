using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public abstract class Human
    {
        protected float _height;
        public int Age { get; set; }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public abstract void Eat(string food);
    }
}
