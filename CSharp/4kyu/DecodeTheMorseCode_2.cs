using System.Linq;
using System;
using CSharp._6Kyu;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CSharp._4Kyu
{
    // public static class Kata_Sollutions_1
    // {
    //     public static string DecodeBits(string bits)
    //     {
    //         var cleanedBits = bits.Trim('0');
    //         var rate = GetRate();
    //         return cleanedBits
    //         .Replace(GetDelimiter(7, "0"), "   ")
    //         .Replace(GetDelimiter(3, "0"), " ")
    //         .Replace(GetDelimiter(3, "1"), "-")
    //         .Replace(GetDelimiter(1, "1"), ".")
    //         .Replace(GetDelimiter(1, "0"), "");

    //         string GetDelimiter(int len, string c) => Enumerable.Range(0, len * rate).Aggregate("", (acc, _) => acc + c);
    //         int GetRate() => GetLengths("0").Union(GetLengths("1")).Min();
    //         IEnumerable<int> GetLengths(string del) => cleanedBits.Split(del, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Length);
    //     }

    //     public static string DecodeMorse(string morseCode)
    //     {
    //         return morseCode
    //         .Split("   ")
    //         .Aggregate("", (res, word) => $"{res}{ConvertWord(word)} ")
    //         .Trim();

    //         string ConvertWord(string word) => word.Split(' ').Aggregate("", (wordRes, c) => wordRes + MorseCode.Get(c));
    //     }
    // }

    // public static class Kata_Sollutions_2
    // {
    //     public class MorseCodeDecoder
    //     {
    //         public static string DecodeMorse(string morseCode)
    //         {
    //             return Regex.Replace(morseCode, @"(?:[\.-]+)|(?:\s+)", MatchReplace);
    //         }

    //         public static string MatchReplace(Match m)
    //         {
    //             switch (m.Value)
    //             {
    //                 case " ": return "";
    //                 case "   ": return " ";
    //                 default: return Kata6.MorseCode.Get(m.Value);
    //             }

    //         }

    //         public static string DecodeBits(string bits)
    //         {
    //             var tokens = Regex.Matches(bits.Trim('0'), @"(0+|1+)").OfType<Match>().Select(i => i.Value).ToList();
    //             var basis = tokens.Select(i => i.Length).Min();
    //             var elts = new Dictionary<string, string>{
    //                 {new string('1', basis), "."},
    //                 {new string('0', basis), ""},
    //                 {new string('1', basis*3), "-"},
    //                 {new string('0', basis*3), " "},
    //                 {new string('0', basis*7), "   "}
    //             };

    //             return string.Join("", tokens.Select(i => elts[i]));

    //         }
    //     }
    // }

    public static partial class Kata4
    {
        public static string DecodeBits(string bits)
        {
            var words = new List<string>();
            var result = new List<string>();

            bits = bits.Trim(new char[] { '0' });

            var temp = Regex.Split(bits, @"[0]+");
            var dot = 0;
            if (temp != null && temp.Length > 0)
            {
                dot = temp.Min(b => b.Length);
            }

            var arr = Regex.Split(bits, @"[1]+").Where(a => !String.IsNullOrEmpty(a)).ToArray();
            var signalPause = 0;
            if (arr != null && arr.Length > 0)
            {
                signalPause = arr.Min(b => b.Length);
            }

            dot = signalPause < dot && signalPause > 0 ? signalPause : dot;
            signalPause = dot;

            var dash = dot * 3;

            var letterPause = signalPause * 3;

            var wordPause = signalPause * 7;

            bits = Regex.Replace(bits, @"[0]{" + wordPause + ",}", "   ");
            bits = Regex.Replace(bits, @"[0]{" + letterPause + ",}", " ");

            foreach (var word in bits.Split("   "))
            {
                foreach (var letter in word.Split(" "))
                {
                    var signals = Regex.Split(letter, @"[0]+");
                    var signalLetter = String.Join("", signals.Select(s => s.Length == dash ? "-" : "."));
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