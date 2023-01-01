using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static Func<int, int, int> mod = (n, m) => ((n % m) + m) % m;
        public static char moveChar(char c, int n)
        {
            char moved = c;
            if (!IsApha(c)) return c;
            moved = (char)(mod(char.ToLower(c) - 97, 26) + 97);

            return c > 96 ? moved : char.ToUpper(moved);
        }
        public static List<string> movingShift(string s, int shift, int direction = 1)
        {
            var result = new List<string>();
            var cipher = s.ToCharArray().Select(c => moveChar(c, direction * shift++));

            var split = (int)Math.Ceiling((double)s.Length / 5);
            for (int i = 0; i < 5; i++)
            {
                var line = new String(cipher.Skip(i * split).Take(split).ToArray());
                result.Add(line);
            }

            return result;
        }

        public static string demovingShift(List<string> s, int shift)
        {
            var str = String.Join("", s);
            var result = movingShift(str, shift, -1);

            return String.Join("", result);
        }
    }
}
