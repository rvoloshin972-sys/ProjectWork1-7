using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork5
{
    public class NumberInfo
    {
        public int Number { get; set; }
        public int SumDigits { get; set; }
        public NumberInfo(int number) 
        {
            Number = number;
            SumDigits = CalculateSum(number);
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
        public override string ToString()
        {
            return $"Число: {Number}, сума цифр: {SumDigits}";
        }
    }
}
