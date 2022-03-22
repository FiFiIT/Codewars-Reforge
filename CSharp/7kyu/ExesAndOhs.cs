using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static bool XO(string input)
        {
            input = input.ToUpper();
            return input.Count(l => l == 'O') == input.Count(l => l == 'X');
        }
    }
}