using APBD2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    internal class ContainerL : Container, IHazardNotifier
    {

        bool doesStoreDangerousCargo {  get; set; }

        public ContainerL(int cargoMass, int hight, int curbWeight, int depth, APBD2.Type type, int maxCapacity, Boolean doesStoreDangerousCargo) : base(cargoMass, hight, curbWeight, depth, type, maxCapacity)
        {
        }
        public void NotifyHazard() {
            Console.WriteLine($"Uwaga. Niebezpieczeństwo przy kontenerze: {showContainerId()}");
            
        }
        public void AddCargo(int cargoMass) {
            if (this.doesStoreDangerousCargo)
            {
                this.maxCapacity = this.maxCapacity / 2;
            }
            else
                this.maxCapacity = this.maxCapacity * 0.9;

            if (this.cargoMass > this.maxCapacity || this.maxCapacity < cargoMass ) {
                Console.WriteLine("Próba wykonania niebezpiecznej operacji");
            }

            if (this.maxCapacity >= cargoMass) {
                maxCapacity -= cargoMass;

            }

        }

        public void RemoveCargo(int mass)
        {
            this.cargoMass -= cargoMass;
        }

        public void ShowInfo() { 
            base.ShowInfo();
            Console.WriteLine("Czy jest niebezpieczny ładunek " + this.doesStoreDangerousCargo);
        }
    }

    

}
