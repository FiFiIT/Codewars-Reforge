using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace CSharp._5kyuRepeat
{
    public static class Repeat
    {
        public static string Decomp(int n)
        {
            var r = Enumerable.Range(2, n - 1)
                .Select(x => x.Factors())
                .SelectMany(x => x)
                .GroupBy(x => x)
                .Select(g => g.Count() > 1 ? $"{g.Key}^{g.Count()}" : $"{g.Key}");

            return String.Join(" * ", r);
        }

        public static IEnumerable<int> Factors(this int x)
        {
            int d = 2;
            while (x != 1)
            {
                if (x % d == 0)
                {
                    x /= d;
                    yield return d;
                }
                else
                {
                    d++;
                }
            }
        }
    }
}