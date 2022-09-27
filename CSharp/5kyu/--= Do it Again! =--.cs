using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace CSharp._5kyuRepeat
{
    public static class Repeat
    {
        public static string Rot13(string input)
        {
            var rot = input.ToCharArray().Select(c => Cypher(c));

            return new String(rot.ToArray());
        }
        public static char Cypher(char c)
        {
            if (char.IsLetter(c))
                return c >= 'm' ? (char)(c - 13) : (char)(c + 13);
            else
                return c;
        }
    }
}