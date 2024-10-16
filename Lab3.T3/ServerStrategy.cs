using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.T3
{
    public class ServerStrategy : IAuthStrategy
    {
        public bool Authenticate()
        {
            Console.WriteLine("Виберіть сервіс для авторизації: Google, Facebook чи Дія. ");
            string service = Console.ReadLine();
            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            return true;

        }
    }
}