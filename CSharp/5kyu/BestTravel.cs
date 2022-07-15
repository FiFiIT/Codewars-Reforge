using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            if (ls.Count() < k)
            {
                return null;
            }

            int n = ls.Count() - 1;
            int[] data = new int[k];
            var combo = new List<int>();
            combinationUtil(ls.ToArray(), data, 0, n, 0, k, combo);

            // Console.WriteLine(String.Join(", ", combo));
            // Console.WriteLine($"{k} -> {t}: " + String.Join(", ", ls));
            return combo.Where(s => s <= t).Max();
        }

        private static void combinationUtil(int[] arr, int[] data, int start, int end, int index, int r, List<int> combo)
        {
            if (index == r)
            {
                // System.Console.WriteLine(String.Join(" ", data));
                combo.Add(data.Sum());
                return;
            }

            for (int i = start; i <= end; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1, end, index + 1, r, combo);
            }
        }
    }

    public class Travel
    {
        public int Distance { get; set; }
        public List<int> Towns { get; set; }
        public int Visit { get; set; }

    }
}