using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var result = words.Where(w =>
            {
                if (w.Length != word.Length)
                {
                    return false;
                }

                var tmp = word;
                foreach (char c in w)
                {
                    var index = tmp.IndexOf(c);
                    if (index == -1)
                    {
                        return false;
                    }

                    tmp = tmp.Remove(index, 1);
                }

                return true;
            }).ToList();

            return result;
        }

        public static List<string> Anagrams_kata(string word, List<string> words)
        {
            var pattern = word.OrderBy(c => c);
            return words.Where(w => w.OrderBy(c => c).SequenceEqual(pattern)).ToList();
        }
    }
}