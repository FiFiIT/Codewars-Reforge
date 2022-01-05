using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static bool Isogram(string word)
        {
            if (word.Length <= 1) return true;

            word = word.ToLower();
            var dict = new Dictionary<char, int>();

            foreach (char w in word)
            {
                dict[w] = word.Count(c => c == w);
            }

            return dict.Values.Max() == 1;
        }

        public static bool Isogram2(string word)
        {
            return word.Distinct().Count() == word.Count();
        }
    }
}