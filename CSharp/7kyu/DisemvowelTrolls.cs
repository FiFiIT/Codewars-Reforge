using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string DisemvowelTrolls(string text)
        {
            return string.Join("", text.Where(c => "aeiou".IndexOf(c, System.StringComparison.CurrentCultureIgnoreCase) == -1));
        }
    }
}