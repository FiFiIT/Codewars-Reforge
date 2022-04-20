using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static class MorseCode
        {
            static Dictionary<string, string> MORSE_CODE = new Dictionary<string, string>()
        {
            {".-", "A"},
            {"-...", "B"},
            {"-.-.", "C"},
            {"-..", "D"},
            {".", "E"},
            {"..-.", "F"},
            {"--.", "G"},
            {"....", "H"},
            {"..", "I"},
            {".---", "J"},
            {"-.-", "K"},
            {".-..", "L"},
            {"--", "M"},
            {"-.", "N"},
            {"---", "O"},
            {".--.", "P"},
            {"--.-", "Q"},
            {".-.", "R"},
            {"...", "S"},
            {"-", "T"},
            {"..-", "U"},
            {"...-", "V"},
            {".--", "W"},
            {"-..-", "X"},
            {"-.--", "Y"},
            {"--..", "Z"},
            {"-----", "0"},
            {".----", "1"},
            {"..---", "2"},
            {"...--", "3"},
            {"....-", "4"},
            {".....", "5"},
            {"-....", "6"},
            {"--...", "7"},
            {"---..", "8"},
            {"----.", "9"},
            {"...---...", "SOS"},
            {".-.-.-", "."},
            {"..--..", "?"},
            {"-..-.", "/"},
            {"-....-", "-"},
            {"-.--.", "("},
            {"-.--.-", ")"},
            {"-.-.--", "!"},
            {"--..--", ","}
        };

            public static string Get(string word)
            {
                return MORSE_CODE[word];
            }
        }

        public static string Decode(string morseCode)
        {
            var result = new List<string>();
            foreach (var word in morseCode.Trim().Split("   "))
            {
                var w = string.Join("", word.Split(" ").Where(x => !string.IsNullOrEmpty(x)).Select(MorseCode.Get));

                result.Add(w);
            }
            return string.Join(" ", result);
        }

        public static string Decode_Kata(string morseCode)
        {
            var words = morseCode.Split(new[] { "   " }, StringSplitOptions.None);
            var translatedWords = words.Select(word => word.Split(' ')).Select(letters => string.Join("", letters.Select(MorseCode.Get))).ToList();

            return string.Join(" ", translatedWords);
        }
    }
}