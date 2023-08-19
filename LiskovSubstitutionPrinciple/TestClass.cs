using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class TestClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SendInformation(new BMWService()));
            Console.ReadLine();
        }
        public static string SendInformation(SendInformation information)
        {
            return information.SendMail();
        }
        
    }
}
