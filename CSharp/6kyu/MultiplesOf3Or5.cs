using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int Solution_fifi(int value)
        {
            int sum = 0;

            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
        public static int Solution(int value)
        {
            return Enumerable.Range(0, value).Where(v => v % 3 == 0 || v % 5 == 0).Sum();
        }

    }
}