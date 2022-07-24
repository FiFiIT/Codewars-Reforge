using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static long FindS(long a, long b)
        {
            long s = a * b + a + b;
            long l = 1;
            long r = (s / 2) + 1;

            while (l <= r)
            {
                long mid = (l + r) / 2;
                long sum = mid * (mid + 1) / 2;

                if (sum == s)
                {
                    return mid;
                }
                else if (sum > s)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }

            }

            return -1;
        }
        public static List<long[]> removNb_kata_1(long n)
        {
            var result = new List<long[]>();
            long sumOfSeq = n % 2 == 0 ? (n + 1) * (n / 2) : n * ((n + 1) / 2);
            long b;
            for (long a = n / 2; a <= n; a++)
            {
                b = (sumOfSeq - a) / (a + 1);
                if ((b * a + b + a) == sumOfSeq)
                {
                    result.Add(new long[] { a, b });
                }
            }
            return result;
        }
        public static List<long[]> removNb(long n)
        {
            var total = SumOfNaturalNumbers(n);

            var result = new List<long[]>();
            for (long a = 1; a < n; a++)
            {
                long r = (total - a) / (a + 1);
                if (r < n)
                {
                    if (r * a == total - (r + a))
                    {
                        result.Add(new long[] { a, (long)r });
                        System.Console.WriteLine($"{a}, {r}");
                    }

                }
            }

            return result;
        }

        // Sum of Natural Numbers 1 to 100
        // The natural numbers from 1 to 100 can be written as 1, 2, 3, 4,5…….100 is an arithmetic progression (A.P). 
        // The sum of all natural numbers 1 to 100 can be calculated using the formula, S= n/2[2a + (n − 1) × d], 
        // where n is the total number of natural numbers from 1 to 100, d is the difference between the two consecutive terms, 
        // and a is the first term. There are a total of 100 natural numbers, so n = 100.
        // Thus, a = 1, d = 1 and n = 100
        // Let's calculate the sum of the natural numbers 1 to 100

        // The sum of an A.P,
        // S = n/2[2a + (n − 1) × d]
        // S = 100/2[2 + (100 – 1) × 1]
        // S = 50 [2 + 99]
        public static long SumOfNaturalNumbers(long n)
        {
            return n * (n + 1) / 2;
        }
    }
}