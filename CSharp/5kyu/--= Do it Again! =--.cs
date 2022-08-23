using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string Rot131(string input)
        {
            var result = input.ToCharArray().Select(c =>
            {
                if (c.IsApha())
                {
                    int dir = char.ToLower(c) > 110 ? -13 : 13;
                    c = (char)(c + dir);
                }

                return c;
            });


            return String.Concat(result);
        }
    }
}