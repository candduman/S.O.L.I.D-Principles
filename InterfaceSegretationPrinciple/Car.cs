using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegretationPrinciple
{
    internal class Car : IVehicle
    {
        void IVehicle.go()
        {
            throw new NotImplementedException();
        }

        void IVehicle.stop()
        {
            throw new NotImplementedException();
        }
    }
}
