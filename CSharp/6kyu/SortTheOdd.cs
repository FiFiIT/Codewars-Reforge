using System.Linq;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int[] SortArray(int[] array)
        {
            var odds = array.Where(x => x % 2 != 0).OrderBy(i => i).ToArray();
            int i = 0;

            return array.Select(a => a % 2 == 0 ? a : odds[i++]).ToArray();
        }

        public static int[] SortArray_kata_1(int[] array)
        {
            var odds = new Queue<int>(array.Where(x => x % 2 == 1).OrderBy(x => x));

            return array.Select(a => a % 2 == 1 ? odds.Dequeue() : a).ToArray();
        }
    }
}