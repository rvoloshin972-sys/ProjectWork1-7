using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork1.models
{
    public class NumberGenerator
    {
        public static List<int> GenNumbers(int count)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(1, 101));
            }
            return numbers;
        }
    }
}
