using System;
using System.Text;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть прізвище співробітника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введіть ім'я співробітника:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введіть посаду співробітника (manager, developer, designer):");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть стаж працівника (у роках):");
            int experience = Convert.ToInt32(Console.ReadLine());


            Employee employee = new Employee(lastName, firstName);
            
            decimal salary = employee.CalculateSalary(position, experience);
            decimal tax = employee.CalculateTax(salary);
            
            Console.WriteLine("Прізвище: " + employee.LastName);
            Console.WriteLine("Ім'я: " + employee.FirstName);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Оклад: " + salary);
            Console.WriteLine("Податковий збір: " + tax);
        }
    }
}