using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork1.utils
{
    public class PrintHelper
    {
        public static void PrintNumbers(string title, List<int> numbers)
        {
            Console.WriteLine("\n" + title);
            numbers.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();
        }
    }
}
