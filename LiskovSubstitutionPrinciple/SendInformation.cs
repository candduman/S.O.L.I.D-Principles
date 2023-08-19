using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    abstract class SendInformation
    {
        public abstract string SendSMS();
        public abstract string SendMail();
    }
}
