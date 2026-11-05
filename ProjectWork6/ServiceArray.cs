using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork6
{
    public class ServiceArray
    {
        private ArrayData data;
        public ServiceArray(ArrayData data)
        {
            this.data = data;
        }
        public int[] GetDifference()
        {
            var result =
                from number in data.FirstArray.Except(data.SecondArray)
                select number;
            return result.ToArray();
        }
        public int[] GetIntersection()
        {
            var result =
                from number in data.FirstArray.Intersect(data.SecondArray)
                select number;
            return result.ToArray();
        }
        public int[] GetUnion()
        {
            var result =
                from number in data.FirstArray.Union(data.SecondArray)
                select number;
            return result.ToArray();
        }
        public int[] GetUniqueFirstArray()
        {
            var result =
                from number in data.FirstArray.Distinct()
                select number;
            return result.ToArray();
        }
        public void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
