using System;
using System.Text;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть ім'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            string lastName = Console.ReadLine();
            
            int age;
            while (true)
            {
                Console.Write("Введіть вік: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age >= 1 && age <= 120)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Будь ласка, введіть правильний вік!");
                    }
                    Console.WriteLine("Будь ласка, введіть число!");
                }
            }

            User new_user = new User(login, firstName, lastName, age);
            
            Console.WriteLine("Інформація про користувача: ");
            Console.WriteLine("Логін: " + new_user.Login);
            Console.WriteLine("Ім'я: " + new_user.FirstName);
            Console.WriteLine("Прізвище: " + new_user.LastName);
            Console.WriteLine("Вік: " + new_user.Age);
            Console.WriteLine("Дата заповнення анкети: " + new_user.RegistrationDate);
            
        }
    }
}