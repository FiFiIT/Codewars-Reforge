using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static string DuplicateEncode(string word)
        {
            return String.Join("", word.ToLower().Select(w => word.Count(x => x == w) == 1 ? "(" : ")"));
        }
    }
}