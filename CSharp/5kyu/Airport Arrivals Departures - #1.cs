using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        private static string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ?!@#&()|<>.:=-+*/0123456789";
        public static string[] FlapDisplay(String[] lines, int[][] rotors)
        {
            return lines.Select((c, r) => Roll(c, rotors[r])).ToArray();
        }

        public static string Roll(string str, int[] v)
        {
            var len = str.Length;
            var result = str.ToList();

            for (int i = 0; i < len; i++)
            {
                result = result.Select((c, p) => p < i ? c : ABC[(ABC.IndexOf(c) + v[i]) % ABC.Length]).ToList();
            }

            return String.Join("", result);
        }
    }
}