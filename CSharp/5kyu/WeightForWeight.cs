using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public class WeightComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Weight() == y.Weight() ? string.Compare(x, y) : x.Weight() - y.Weight();
            }
        }
        public static string OrderWeight(string strng)
        {
            var result = strng.Split(" ", StringSplitOptions.RemoveEmptyEntries).OrderBy(a => a, new WeightComparer());

            return String.Join(" ", result);
        }

        public static int Weight(this string w) => w.ToCharArray().Sum(i => int.Parse(i.ToString()));

        public static string OrderWeight_Kata_1(string s)
        {
            return String.Join(" ", s.Split(" ")
                .OrderBy(c => c.ToCharArray().Select(a => (int)char.GetNumericValue(a)).Sum())
                .ThenBy(n => n));
        }
    }
}