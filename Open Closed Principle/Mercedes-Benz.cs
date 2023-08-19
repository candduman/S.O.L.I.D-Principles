using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    internal class Mercedes_Benz : Car
    {
        public override string Name => "Mercedes-Benz";

        public override int KM => 2500;

        public override int FuelPerKM => 5;
    }
}
