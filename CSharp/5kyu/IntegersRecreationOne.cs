using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string listSquared(long m, long n)
        {
            var result = new List<string>();

            for (long i = m; i <= n; i++)
            {
                var div = FindDivisors(i);
                var sumOfSquares = div.Select(x => x * x).Sum();

                if (Math.Sqrt(sumOfSquares) % 1 == 0)
                {
                    result.Add($"[{i}, {sumOfSquares}]");
                }
            }

            return "[" + String.Join(", ", result) + "]";
        }

        private static IEnumerable<long> FindDivisors(long n)
        {
            var divisors = new List<long>();
            for (long i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (n / i == i)
                    {
                        divisors.Add(i);
                    }
                    else
                    {
                        divisors.AddRange(new long[] { i, n / i });
                    }
                }
            }

            return divisors;
        }

        private static long SumDivisors(long number)
        {
            long sum = 0;

            for (long i = 0; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (number / i == i)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += i + (number / i);
                    }
                }
            }

            return sum;
        }

        public static string listSquared_kata_1(long m, long n)
        {
            var result = new List<string>();
            long sum = 0;

            for (long number = m; number <= n; number++)
            {
                sum = FindDivisors(number).Select(x => x * x).Sum();

                if (Math.Sqrt(sum) % 1 == 0)
                {
                    result.Add(string.Format("[{0}, {1}]", number, sum));
                }
            }

            return string.Format("[{0}]", String.Join(", ", result));
        }
    }
}