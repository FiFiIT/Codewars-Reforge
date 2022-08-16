using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string convertFrac_kata_1(long[,] lst)
        {
            int c = lst.GetLength(0);
            long l = 1;
            for (var i = 0; i < c; i++) l = LCM(lst[i, 1], l);

            return String.Empty;
        }

        // Last Common Multiple
        private static long LCM(long a, long b)
        {
            var g = GCD(a, b);
            return a * b / g;
        }

        // Greatest Common Divisor
        private static long GCD(long a, long b)
        {
            if (b == 0) return a;

            var m = a % b;
            return GCD(b, m);
        }

        public static string convertFrac(long[,] lst)
        {
            var result = new List<string>();
            long m = 0;
            for (int i = 0; i < lst.GetLength(0); i++)
            {
                m = lst[i, 1] > m ? lst[i, 1] : m;
            }

            var not_found = true;
            while (not_found)
            {
                not_found = false;
                for (int i = 0; i < lst.GetLength(0); i++)
                {
                    if (m % lst[i, 1] != 0)
                    {
                        not_found = true;
                        m++;
                        continue;
                    }
                }
            }

            for (int i = 0; i < lst.GetLength(0); i++)
            {
                result.Add($"({m / lst[i, 1] * lst[i, 0]},{m})");
            }

            return String.Join("", result);
        }
    }
}