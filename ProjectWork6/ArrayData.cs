using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork6
{
    public class ArrayData
    {
        public int[] FirstArray { get; set; }
        public int[] SecondArray { get; set; }
        public ArrayData(int[] firstArray, int[] secondArray)
        {
            FirstArray = firstArray;
            SecondArray = secondArray;
        }
    }
}
