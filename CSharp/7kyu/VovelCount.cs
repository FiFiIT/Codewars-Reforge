using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static int GetCount(string sentence)
        {
            return sentence.Count(w => "aeiou".Contains(w));
        }

        public static int GetCount2(string sentence)
        {
            return Regex.Matches(sentence, @"[aeiou]").Count();
        }
    }
}