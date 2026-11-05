using System;
using System.Text;
using ProjectWork1.models;
using ProjectWork1.services;
using ProjectWork1.utils;

namespace ProjectWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numbers = NumberGenerator.GenNumbers(30);
            ServiceLinq service = new ServiceLinq(numbers);

            PrintHelper.PrintNumbers("Весь масив цілих чисел:",
                service.GetAll());

            PrintHelper.PrintNumbers("Парні числа:",
                service.GetEven());

            PrintHelper.PrintNumbers("Непарні числа:",
                service.GetOdd());

            PrintHelper.PrintNumbers("Числа від 20 до 70:",
                service.GetRange(20, 70));

            PrintHelper.PrintNumbers("Числа, кратні семи (за зростанням):",
                service.GetMultiplesOfSeven());

            PrintHelper.PrintNumbers("Числа, кратні восьми (за спаданням):",
                service.GetMultiplesOfEight());

            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();

            static void PrintNumbers(List<int> numbers)
            {
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
