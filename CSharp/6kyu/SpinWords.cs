using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static string SpinWords_fifi(string sentence)
        {
            return String.Join(" ", sentence.Split(" ").Select(s =>
            {
                if (s.Length >= 5)
                {
                    return String.Concat(s.Select((c, i) => new KeyValuePair<int, char>(i, c))
                                .OrderByDescending(x => x.Key)
                                .Select(x => x.Value));
                }

                return s;
            }));
        }
        public static string SpinWords(string sentence)
        {
            return String.Join(" ", sentence.Split(" ").Select(s => s.Length >= 5 ? new String(s.Reverse().ToArray()) : s));
        }
    }
}