using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}