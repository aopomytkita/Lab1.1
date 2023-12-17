using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress some_adress = new Adress();
            some_adress.Index = "111";
            some_adress.Country = "Ukraine";
            some_adress.Apartment = "1";
            some_adress.City = "Kyiv";
            some_adress.House = "1";
            some_adress.Street = "Khreshchatyk";
            
            Console.WriteLine("Index: " + some_adress.Index);
            Console.WriteLine("Country: " + some_adress.Country);
            Console.WriteLine("Apartment: " + some_adress.Apartment);
            Console.WriteLine("City: " + some_adress.City);
            Console.WriteLine("House: " + some_adress.House);
            Console.WriteLine("Street: " + some_adress.Street);
            
        }
    }
}