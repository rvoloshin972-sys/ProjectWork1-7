using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork2
{
    public class LinqCityService
    {
        private string[] Cities { get; set; }
        public LinqCityService(string[] cities)
        {
            Cities = cities;
        }
        public List<string> GetAll()
        {
            var result =
                (from city in Cities
                 orderby city
                 select city).ToList();
            return result;
        }
        public List<string> GetByLength(int length)
        {
            var result =
                (from city in Cities
                 where city.Length == length
                 orderby city
                 select city).ToList();
            return result;
        }
        public List<string> GetStartsWithA()
        {
            var result =
                (from city in Cities
                 where city.StartsWith("A")
                 orderby city
                 select city).ToList();
            return result;
        }
        public List<string> GetEndsWithM()
        {
            var result =
                (from city in Cities
                 where city.EndsWith("m")
                 orderby city
                 select city).ToList();
            return result;
        }
        public List<string> GetStartsWithNAndEndsWithK()
        {
            var result =
                (from city in Cities
                 where city.StartsWith("N") && city.EndsWith("k")
                 orderby city
                 select city).ToList();
            return result;
        }
    }
}
