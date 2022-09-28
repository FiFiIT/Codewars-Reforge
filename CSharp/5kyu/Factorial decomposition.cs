using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string Decomp(int n)
        {
            var r = Enumerable.Range(2, n - 1)
                .Select(x => x.Multipliers())
                .SelectMany(x => x)
                .GroupBy(x => x)
                .Select(g => g.Count() > 1 ? $"{g.Key}^{g.Count()}" : g.Key.ToString());

            return String.Join(" * ", r);
        }

        public static IEnumerable<int> Multipliers(this int number)
        {
            var divider = 2;
            while (number != 1)
            {
                if (number % divider == 0)
                {
                    number /= divider;
                    yield return divider;
                }
                if (number % divider != 0) divider++;
            }
        }
    }
}
