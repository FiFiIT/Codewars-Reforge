using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static long[] Gap(int g, long m, long n)
        {
            long p = 0;
            for (; m <= n; m++)
            {
                if (IsPrime(m))
                {
                    if (m - p == g) return new long[] { p, m };
                    p = m;
                }
            }
            return null;
        }

        public static bool IsPrime(long number)
        {
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}