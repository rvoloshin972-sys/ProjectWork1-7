using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork1.services
{
    public class ServiceLinq
    {
        public List<int> Numbers { get; set; }
        public ServiceLinq(List<int> numbers)
        {
            Numbers = numbers;
        }
        public List<int> GetAll()
        {
            var result = (from n in Numbers
                          select n).ToList();

            return result;
        }
        public List<int> GetEven()
        {
            var result = (from n in Numbers
                          where n % 2 == 0
                          select n).ToList();

            return result;
        }
        public List<int> GetOdd()
        {
            var result = (from n in Numbers
                          where n % 2 != 0
                          select n).ToList();

            return result;
        }
        public List<int> GetRange(int min, int max)
        {
            var result = (from n in Numbers
                          where n >= min && n <= max
                          select n).ToList();

            return result;
        }
        public List<int> GetMultiplesOfSeven()
        {
            var result = (from n in Numbers
                          where n % 7 == 0
                          orderby n 
                          select n).ToList();

            return result;
        }
        public List<int> GetMultiplesOfEight()
        {
            var result = (from n in Numbers
                          where n % 8 == 0
                          orderby n descending
                          select n).ToList();

            return result;
        }
    }
}
