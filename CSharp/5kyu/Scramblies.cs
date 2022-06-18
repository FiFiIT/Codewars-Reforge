using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static bool Scramble_kata_1(string str1, string str2)
        {
            return str2.All(c => str1.Count(x => x == c) >= str2.Count(y => y == c));
        }
        public static bool Scramble_kata_2(string str1, string str2)
        {
            var possible = str1.ToList();

            foreach (var c in str2)
            {
                if (!possible.Remove(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}