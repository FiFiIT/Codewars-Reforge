using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string Longest(string s1, string s2)
        {
            return string.Join("", (s1 + s2).Distinct().OrderBy(a => a));
        }
        public static string Longest_2(string s1, string s2)
        {
            return string.Concat(s1.Union(s2).Distinct().OrderBy(a => a));
        }
    }
}