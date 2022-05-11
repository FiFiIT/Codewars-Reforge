using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static bool ValidParentheses(string input)
        {
            int counter = 0;
            foreach (var i in input)
            {
                if (i == '(') counter++;
                if (i == ')') counter--;

                if (counter < 0) return false;
            }

            return counter == 0;
        }
    }
}