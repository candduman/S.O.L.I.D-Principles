using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegretationPrinciple
{
    internal interface IVehicle
    {

        void go();
        void stop();

        // we cannot add those method to IVehicle interface because the classes which are inhereted from IVehicle doesnt have those skills to use. So We need to create another interfaces
        //void swim();
        //void fly();

    }
}
