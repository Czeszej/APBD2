using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    internal interface IContainer
    {
        public void RemoveCargo(int cargoMass) { }
        public void AddCargo(int cargoMass) { }
       
    }
}
