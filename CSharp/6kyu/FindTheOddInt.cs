using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int find_it_fifi(int[] seq)
        {
            return seq.FirstOrDefault(s => seq.Count(a => a == s) % 2 != 0);
        }

        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
    }
}