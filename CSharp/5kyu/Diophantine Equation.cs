using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string solEquaStr(long n)
        {

            var result = new List<string>();

            foreach (var div in Divisors(n))
            {
                double x = Math.Abs(div[0] + div[1]) / 2;
                double y = Math.Abs(div[0] - x) / 2;

                if (y % 1 == 0 && x % 1 == 0)
                {
                    result.Add($"[{x}, {y}]");
                }
            }

            var str = String.Join(", ", result);
            return $"[{str}]";
        }

        public static IEnumerable<double[]> Divisors(long n)
        {
            var result = new List<double[]>();

            for (long i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    result.Add(new double[] { i, n / i });
                }
            }

            return result;
        }
    }
}