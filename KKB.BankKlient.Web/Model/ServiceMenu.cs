using KKB.BankKlient.BLL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKB.BankKlient.BLL.User.Account;
using System.Threading;

namespace KKB.BankKlient.Web.Model
{
    public class ServiceMenu
    {

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в KKB!\n");

            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Вход");

            Console.Write(": ");
            int menu = Int32.Parse(Console.ReadLine());

            if(menu == 1)
            {
                RegisterMenu();
            }
            else if (menu == 2)
            {

            }
        }

        public static void AuthorizeUserMenu(User user)
        {
            Console.WriteLine("Приветствуем Вас, {0} {1}",
                user.FirstName, user.LastName);

            Console.WriteLine("1. Вывод баланса на экран");
            Console.WriteLine("2. Пополнение счёта");
            Console.WriteLine("3. Снять деньги со счёта");
            Console.WriteLine("4. Выход");

            Console.Write(": ");
            int menu = Int32.Parse(Console.ReadLine());
        }

        public static void RegisterMenu()
        {
            Console.Clear();
            Console.WriteLine("Форма регистрации пользователя\n");

            User user = new User();

            Console.Write("FirstName: ");
            user.FirstName = Console.ReadLine();

            Console.Write("LastName: ");
            user.LastName = Console.ReadLine();

            Console.Write("Login: ");
            user.Login = Console.ReadLine();

            Console.Write("Password: ");
            user.Password = Console.ReadLine();

            ServiceUser service = new ServiceUser();
            string message = "";
            if (service.RegisterUser(user, out message))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(3000);
                MainMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            
        }

    }
}
