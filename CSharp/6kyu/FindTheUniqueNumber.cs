using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            // we know we will have array at leas of 3 lenght so take most often int from it
            int num = numbers.Take(3).GroupBy(x => x).Single(i => i.Count() > 1).Key;

            foreach (var number in numbers)
            {
                if (number != num)
                {
                    return number;
                }
            }

            return 0;
        }
        public static int GetUnique_kata(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Single(a => a.Count() == 1).Key;
        }
    }
}