using System.Linq;
using System.Globalization;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string ToJadenCase(string phrase)
        {
            return string.Join(" ", phrase.Split(" ").Select(w => w[0].ToString().ToUpper() + w.Substring(1)));
        }

        public static string ToJadenCase_2(string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }
    }
}