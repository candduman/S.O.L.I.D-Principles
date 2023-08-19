using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    internal class BMW : Car
    {
        public override string Name => "BMW";

        public override int KM => 5000;

        public override int FuelPerKM =>2;
    }
}
