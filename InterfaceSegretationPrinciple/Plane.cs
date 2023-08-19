
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegretationPrinciple
{
    internal class Plane : IVehicle,IFlyable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void go()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
    }
    internal interface IFlyable
    {
        void Fly();
    }
}
