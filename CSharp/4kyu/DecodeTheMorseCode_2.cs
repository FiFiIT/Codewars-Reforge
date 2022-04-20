using System.Linq;
using System;
using CSharp._6Kyu;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CSharp._4Kyu
{
    public static partial class Kata4
    {
        public static string DecodeBits(string bits)
        {
            var space = @"[0]{7,}";
            var pause = @"[0]{3,}";
            var signal = @"[0]{1,2}";

            var words = new List<string>();
            var result = new List<string>();

            bits = bits.Trim(new char[] { '0' });
            bits = Regex.Replace(bits, space, "   ");
            bits = Regex.Replace(bits, pause, " ");

            foreach (var word in bits.Split("   "))
            {
                foreach (var letter in word.Split(" "))
                {
                    var signals = Regex.Split(letter, signal);
                    var signalLetter = String.Join("", signals.Select(s => s.Length < 3 ? "." : "-"));
                    words.Add(signalLetter);
                }
                result.Add(String.Join(" ", words));
                words.Clear();
            }

            return String.Join("   ", result);
        }

        public static string DecodeMorse(string morseCode)
        {
            return Kata6.Decode(morseCode);
        }
    }
}