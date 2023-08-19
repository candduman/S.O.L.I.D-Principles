using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    abstract class Car
    {
        public Car()
        {
                
        }
        public int FuelConsume()
        {
            return KM * FuelPerKM;
        }

        public abstract int FuelPerKM { get; }
        public abstract string Name { get; }
        public abstract int KM { get; }
        
        public string Go() 
        {
            return "Vehicle Going...";
        }
        public string Stop()
        {
            return "Vehicle Stopped.";
        }
    }
}
