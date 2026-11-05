using System;

namespace ProjectWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] numbers = NumberGenerator.GenerateNumbers();
            ServiceNumber service = new ServiceNumber(numbers);

            Console.WriteLine("ПОЧАТКОВИЙ МАСИВ:");
            service.PrintNumbers(numbers);

            Console.WriteLine("\nСОРТУВАННЯ ЗА ЗРОСТАННЯМ СУМИ ЦИФР:");
            int[] ascending = service.SortAscending();
            service.PrintNumbers(ascending);

            Console.WriteLine("\nСОРТУВАННЯ ЗА ЗМЕНШЕННЯМ СУМИ ЦИФР:");
            int[] descending = service.SortDescending();
            service.PrintNumbers(descending);

            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}
