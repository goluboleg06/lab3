using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.T3
{
    public class LoginPasswordStrategy : IAuthStrategy
    {
        public bool Authenticate()
        {
            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();
            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine();

            string correctLogin = "user";
            string correctPassword = "password";

            return login == correctLogin && password == correctPassword;
        }
    }

}