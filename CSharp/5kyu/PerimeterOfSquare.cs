using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        private static double GoldenRatio = (1 + Math.Sqrt(5)) / 2;
        public static BigInteger perimeter(BigInteger n)
        {
            n += 1;

            BigInteger a = 1, b = 1, c = a + b;
            BigInteger sum = a + b;

            for (BigInteger i = 2; i < n; i++)
            {
                a = b;
                b = c;
                c = a + b;
                sum += b;
            }

            return 4 * sum;
        }

        private static BigInteger Fibonacci(BigInteger n)
        {
            var result = (Math.Pow(GoldenRatio, (double)n) - Math.Pow((1 - GoldenRatio), (double)n)) / Math.Sqrt(5);
            return new BigInteger(result);
        }
    }
}