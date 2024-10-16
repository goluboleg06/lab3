using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.T3
{
    public class AuthContext
    {
        private readonly IAuthStrategy _authStrategy;

        public AuthContext(IAuthStrategy authStrategy)
        {
            _authStrategy = authStrategy;
        }

        public void AuthenticateUser()
        {
            if (_authStrategy.Authenticate())
            {
                Console.WriteLine("Вітаємо!");
            }
            else
            {
                Console.WriteLine("Авторизація не вдалася.");
            }
        }
    }

}
