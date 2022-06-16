using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string FirstNonRepeatingLetter_kata_1(string s)
        {
            return s.GroupBy(char.ToLower)
                .Where(g => g.Count() == 1)
                .Select(x => x.First().ToString())
                .DefaultIfEmpty("")
                .First();
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            var s_lower = s.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                if (s_lower.Count(x => x == s_lower[i]) == 1)
                {
                    return s[i].ToString();
                }
            }

            return "";
        }
    }
}