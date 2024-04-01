using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    internal class Container
    {
        public int mass { get; set; }
        public int high { get; set; }
        public int curbWeight { get; set; }
        public int depth { get; set; }

        Type type { get; set; }
        public int maxCapacity { get; set; }
        public int number { get; set; }
        public Container(int mass, int high, int curbWeight, int depth, Type type, int maxCapacity, int number)
        {
            this.mass = mass;
            this.high = high;
            this.curbWeight = curbWeight;
            this.depth = depth;
            this.type = type;
            this.maxCapacity = maxCapacity;
            this.number = number;
        }

        override public string ToString()
        {
            return $"KON-{this.type}" + "-" + this.number;
        }
    }


}
