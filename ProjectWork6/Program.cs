using System;
using System.Text;

namespace ProjectWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ArrayData data = ArrayGenerator.GenerateArrays();
            ServiceArray service = new ServiceArray(data);

            Console.WriteLine("ПЕРШИЙ МАСИВ:");
            service.PrintArray(data.FirstArray);

            Console.WriteLine("\nДРУГИЙ МАСИВ:");
            service.PrintArray(data.SecondArray);

            Console.WriteLine("\nРІЗНИЦЯ ДВОХ МАСИВІВ:");
            service.PrintArray(service.GetDifference());

            Console.WriteLine("\nПЕРЕТИН ДВОХ МАСИВІВ:");
            service.PrintArray(service.GetIntersection());

            Console.WriteLine("\nОБ'ЄДНАННЯ ДВОХ МАСИВІВ:");
            service.PrintArray(service.GetUnion());

            Console.WriteLine("\nПЕРШИЙ МАСИВ БЕЗ ПОВТОРЕНЬ:");
            service.PrintArray(service.GetUniqueFirstArray());

            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}
