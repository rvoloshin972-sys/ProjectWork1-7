using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork5
{
    public class ServiceNumber
    {
        public int[] Numbers { get; set; }
        public ServiceNumber(int[] numbers) 
        {
            Numbers = numbers;
        }
        public int[] SortAscending()
        {
            var result =
                from number in Numbers
                let sum = CalculateSum(number)
                orderby sum ascending
                select number;
            return result.ToArray();
        }
        public int[] SortDescending()
        {
            var result =
                from number in Numbers
                let sum = CalculateSum(number)
                orderby sum descending
                select number;
            return result.ToArray();
        }
        private int CalculateSum(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        public void PrintNumbers(int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
