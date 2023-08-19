using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class BMWService : SendInformation
    {
        public int KM => 2500;

        public int FuelPerKM => 7;
        int FuelConsume()
        {
            return KM * FuelPerKM;
        }
  // So this class doesnt match with SendMail and doesnt cover SendInformation all functions. To solve this problem we can make an interface to seperate those informations methods
        public override string SendMail()
        {
            throw new NotImplementedException();
        }

        public override string SendSMS()
        {
            return "SMS:Your consumed" + FuelConsume().ToString();
        }
    }
}
