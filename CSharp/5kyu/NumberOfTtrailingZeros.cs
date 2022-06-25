using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int TrailingZeros_kata_1(int n)
        {
            int fives = 0;
            for (int i = 5; i <= n; i *= 5)
            {
                fives += n / i;
            }

            return fives;
        }

        public static int TrailingZeros(int n)
        {
            return Enumerable.Range(1, (int)Math.Log(n, 5)).Sum(i => (int)(n / Math.Pow(5, i)));
        }
    }
}