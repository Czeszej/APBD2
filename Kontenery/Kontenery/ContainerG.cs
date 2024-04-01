using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    internal class ContainerG : Container, IHazardNotifier
    {
        double pressure { get; set; }
        public ContainerG(int cargoMass, int hight, int curbWeight, int depth, Type type, int maxCapacity, double pressure) : base(cargoMass, hight, curbWeight, depth, type, maxCapacity)
        {
            this.pressure = pressure;
        }

        public void RemoveCargo(int mass)
        {
            this.cargoMass -= cargoMass;
        }
        public void RemoveAllCargo(int cargoMass)
        {
            this.cargoMass = -cargoMass * 0.95;
        }
        public void NotifyHazard() { Console.WriteLine($"Uwaga. Niebezpieczeństwo przy kontenerze: {showContainerId()}"); }

        public void AddCargo(int cargoMass)
        {
            if (this.cargoMass > this.maxCapacity || this.maxCapacity < cargoMass)
            {
                Console.WriteLine("Próba wykonania niebezpiecznej operacji");
            }

            else if (this.maxCapacity >= cargoMass)
            {
                maxCapacity -= cargoMass;

            }

        }
        public void ShowInfo() { 
            base.ShowInfo();
            Console.Write(" Cisnienie: " + this.pressure);
        }
    }
}
