using System.Text;
using System.Collections.Generic;

namespace ProjectWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] cities = CityGenerator.GenCities();
            LinqCityService service = new LinqCityService(cities);

            Console.WriteLine("Весь масив міст:");
            PrintCities(service.GetAll());

            Console.WriteLine("\nМіста з довжиною назви 5:");
            PrintCities(service.GetByLength(5));

            Console.WriteLine("\nМіста, назви яких починаються з A:");
            PrintCities(service.GetStartsWithA());

            Console.WriteLine("\nМіста, назви яких закінчуються на M:");
            PrintCities(service.GetEndsWithM());

            Console.WriteLine("\nМіста, які починаються з N і закінчуються на K:");
            PrintCities(service.GetStartsWithNAndEndsWithK());

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
            static void PrintCities(List<string> cities)
            {
                foreach (string city in cities)
                {
                    Console.WriteLine(city);
                }
            }
        }
    }
}
