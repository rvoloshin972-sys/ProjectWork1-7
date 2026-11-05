using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork6
{
    public static class ArrayGenerator
    {
        public static ArrayData GenerateArrays()
        {
            int[] firstArray = { 1, 2, 3, 4, 5, 3, 2 };
            int[] secondArray = { 4, 5, 6, 7, 5 };
            return new ArrayData(firstArray, secondArray);
        }
    }
}
