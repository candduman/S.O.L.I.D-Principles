using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class ToyotaService : SendInformation
    {
        public int KM => 1000;

        public int FuelPerKM => 3;
        int FuelConsume()
        {
            return KM * FuelPerKM;
        }

        public override string SendMail()
        {
            return "Mail:Your consumed" +FuelConsume().ToString();
        }

        public override string SendSMS()
        {
            return "SMS:Your consumed" + FuelConsume().ToString();
        }
    }
}
