using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class TestClass
    {
        static void Main(string[] args)
        {
            SendInformation();
            Console.WriteLine("*****");
            SendSms();
            Console.WriteLine("*****");
            SendMail();
            Console.ReadLine();
        }
        #region Wrong usage 
        // This is an unprincipled use because the SendInformation method does two different operations.
        public static void SendInformation()
        {
            SendMail mail = new SendMail();
            Console.WriteLine(mail.send());
            SendSms sms = new SendSms();
            Console.WriteLine(sms.send());
        }
        #endregion

        #region Right usage
        public static void SendSms()
        {
            SendSms sms = new SendSms();
            Console.WriteLine(sms.send());
        }
        public static void SendMail()
        {
            SendMail mail = new SendMail();
            Console.WriteLine(mail.send());
        }

        #endregion
    }

}
