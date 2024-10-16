using Lab3.T3;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Виберіть спосіб авторизації:");
        Console.WriteLine("1. Логін і пароль");
        Console.WriteLine("2. Код із СМС");
        Console.WriteLine("3. Зовнішній сервер (Гугл, Фейсбук чи Дія)");

        string choice = Console.ReadLine();
        AuthContext context;

        switch (choice)
        {
            case "1":
                context = new AuthContext(new LoginPasswordStrategy());
                break;
            case "2":
                context = new AuthContext(new SmsCodeStrategy());
                break;
            case "3":
                context = new AuthContext(new ServerStrategy());
                break;
            default:
                Console.WriteLine("Неправильний вибір");
                return;
        }

        context.AuthenticateUser();
    }
}
