
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    internal class Container : IContainer
    {
        public double cargoMass { get; set; }
        public int hight { get; set; }
        public int curbWeight { get; set; }
        public int depth { get; set; }

        Type type { get; set; }
        public double maxCapacity { get; set; }
        public static int number { get; set; }

        public int idNumber { get; set; }
        
        public Container(int cargoMass, int hight, int curbWeight, int depth, Type type, int maxCapacity)
        {
            this.cargoMass = cargoMass;
            this.hight = hight;
            this.curbWeight = curbWeight;
            this.depth = depth;
            this.type = type;
            this.maxCapacity = maxCapacity;
            number++;
            this.idNumber = number;
           
        }

         public string showContainerId()
        {
            return $"KON-{this.type}" + "-" + this.idNumber;
        }

   

        public void RemoveCargo(int cargoMass) {
            this.cargoMass -= cargoMass;
        }
        public void AddCargo(int cargoMass) {
            if (cargoMass > this.maxCapacity) {
                throw new OverfillException("Przekroczono pojemność kontenera");
            }
            this.cargoMass += cargoMass;
        }


        public void ShowInfo() {
            Console.WriteLine("Masa ładunku: " + this.cargoMass + " Wysokość: " + this.hight + " Masa własna: " + this.curbWeight + " Głębokośc: " + this.depth + " Typ: "
                + this.type + " Max ładowność: " + this.maxCapacity);
        }
    }


}
