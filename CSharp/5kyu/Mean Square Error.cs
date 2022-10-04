using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            return firstArray.Zip(secondArray, (x, y) => Math.Pow(x - y, 2)).Average();
        }
    }
}