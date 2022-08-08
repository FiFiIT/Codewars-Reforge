using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static List<object> JosephusPermutation_Kata_1(List<object> items, int k)
        {
            var result = new List<object>();
            int pos = 0;
            while (items.Count > 0)
            {
                pos = (pos + k - 1) % items.Count;
                result.Add(items[pos]);
                items.RemoveAt(pos);
            }
            return result;
        }
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            if (items == null || !items.Any()) return new List<object>();

            var result = new List<object>();

            var len = items.Count;
            int idx = (k - 1) % items.Count();
            for (int i = 1; i < len; i++)
            {
                result.Add(items[idx]);
                items.RemoveAt(idx);
                idx = (idx - 1 + k) % items.Count();
            }
            result.Add(items[0]);

            return result;
        }
    }
}