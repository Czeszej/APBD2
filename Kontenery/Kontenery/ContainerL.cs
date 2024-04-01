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

        public ContainerL(int cargoMass, int hight, int curbWeight, int depth, APBD2.Type type, int maxCapacity) : base(cargoMass, hight, curbWeight, depth, type, maxCapacity)
        {
        }
        public void NotifyHazard() {
            Console.WriteLine($"Uwaga. Niebezpieczeństwo przy kontenerze: {showContainerId()}");
            
        }
        public void AddCargo() {
            if (this.doesStoreDangerousCargo)
            {
                this.maxCapacity = this.maxCapacity / 2;
            }
            else
                this.maxCapacity = this.maxCapacity * 0.9;

            if (this.cargoMass > this.maxCapacity) {
                Console.WriteLine("Próba wykonania niebezpiecznej operacji");
            }

        }
    }

    

}
