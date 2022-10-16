using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static double going(int n)
        {
            double running = 1.0, term = 1.0;
            for (int i = n; i > 0; i--)
            {
                term *= i / n;
                running += term;
            }

            return System.Math.Truncate(running * 1000000) / 1000000;
        }
        public static double going_kata1(int n)
        {
            var result = 0d;
            var factor = 1d;
            while (n > 0 && factor > 0.0000001)
            {
                result += factor;
                factor /= n;
                n--;
            }

            return Math.Round(result, 6);
        }
    }
}