using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string factors(int lst)
        {
            var result = new Dictionary<int, int>();

            for (int i = 2; i <= lst; i++)
            {
                int counter = 0;
                while (lst % i == 0)
                {
                    counter++;
                    result[i] = counter;
                    lst = lst / i;
                }
            }


            return string.Join("", result.Select(p => string.Format(p.Value > 1 ? "({0}**{1})" : "({0})", p.Key, p.Value)));
        }
    }
}