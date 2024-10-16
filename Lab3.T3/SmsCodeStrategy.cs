using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.T3
{
    public class SmsCodeStrategy : IAuthStrategy
    {
        public bool Authenticate()
        {
            Console.WriteLine("Надсилаємо СМС...");
            Console.WriteLine("Введіть код із СМС: ");
            string code = Console.ReadLine();

            string correctCode = "1234"; //Імітуємо надходження коду

            return code == correctCode;
        }
    }
}
