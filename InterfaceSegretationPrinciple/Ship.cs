using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegretationPrinciple
{
    internal class Ship : IVehicle,ISwimmable
    {
        public void go()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }

        void ISwimmable.Swim()
        {
            throw new NotImplementedException();
        }
    }
    internal interface ISwimmable
    {
        void Swim();
    }
}
