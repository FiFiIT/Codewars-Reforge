using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        # region fifi
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
            var result = combo.Where(s => s <= t);
            return result.Any() ? result.Max() : null;
        }

        private static void combinationUtil(int[] arr, int[] data, int start, int end, int index, int r, List<int> combo)
        {
            if (index == r)
            {
                // System.Console.WriteLine(String.Join(" ", data));
                combo.Add(data.Sum());
                return;
            }

            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1, end, index + 1, r, combo);
            }
        }
        # endregion

        # region KATA 1
        public static int? chooseBestSum_Kata_1(int t, int k, List<int> ls)
        {
            return Best(t, k, ls, 0, 0);
        }

        public static int? Best(int t, int k, List<int> ls, int Start, int Sum)
        {
            if (k == 0)
                return (Sum <= t) ? (int?)Sum : null;

            if (Start >= ls.Count)
                return null;

            int? S1 = Best(t, k - 1, ls, Start + 1, Sum + ls[Start]);
            int? S2 = Best(t, k, ls, Start + 1, Sum + 0);

            if (S1 == null && S2 == null)
                return null;
            if (S1 == null)
                return S2;
            if (S2 == null)
                return S1;
            return (int?)Math.Max(S1.Value, S2.Value);
        }
        #endregion

        #region KATA 2
        public static int? chooseBestSum_Kata_2(int t, int k, List<int> ls) =>
            ls.Combinations(k)
                .Select(c => (int?)c.Sum())
                .Where(sum => sum <= t)
                .DefaultIfEmpty()
                .Max();

        // Inspired by http://stackoverflow.com/questions/127704/algorithm-to-return-all-combinations-of-k-elements-from-n
        public static IEnumerable<IEnumerable<int>> Combinations(this IEnumerable<int> ls, int k) =>
          k == 0 ? new[] { new int[0] } :
            ls.SelectMany((e, i) =>
              ls.Skip(i + 1)
                .Combinations(k - 1)
                .Select(c => (new[] { e }).Concat(c)));
        #endregion
    }

    public class Travel
    {
        public int Distance { get; set; }
        public List<int> Towns { get; set; }
        public int Visit { get; set; }

    }
}