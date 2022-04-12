using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int FindOutlier(int[] integers)
        {
            var odd = integers.Where(i => i % 2 != 0).ToList();
            var even = integers.Where(i => i % 2 == 0).ToList();

            return odd.Count() == 1 ? odd.First() : even.First();
        }
    }
}