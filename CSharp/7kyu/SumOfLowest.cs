using System;
using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int min_1 = numbers.Min();
            int index = Array.IndexOf(numbers, min_1);
            int min_2 = numbers.Where((v, i) => i != index).Min();

            return min_1 + min_2;
        }

        public static int sumTwoSmallestNumbers_2(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }
    }
}