using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        private static V SafeGetValue<K, V>(this Dictionary<K, V> dict, K key, V value = default(V))
            => dict.ContainsKey(key) ? dict[key] : value;

        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            var result = new Dictionary<string, int>();
            var factor = new Stack<int>();
            factor.Push(1);
            factor.Push(1);
            //leksem podstawowa jednostka leksykalna na jaką dzielony jest tekst kodu źródłowego
            var lexems = Regex.Matches(formula, @"(?<e>[A-Z][a-z]*)|(?<n>\d+)|(?<l>[\[({])|(?<r>[\])}])");

            foreach (var lexem in lexems.Cast<Match>().Reverse())
            {
                if (lexem.Groups["n"].Success)
                {
                    factor.Push(factor.Pop() * int.Parse(lexem.Value));
                }

                if (lexem.Groups["l"].Success)
                {
                    factor.Pop();
                    factor.Pop();
                    factor.Push(factor.Peek());
                }

                if (lexem.Groups["r"].Success)
                {
                    factor.Push(factor.Peek());
                }

                if (lexem.Groups["e"].Success)
                {
                    result[lexem.Value] = factor.Pop() + result.SafeGetValue(lexem.Value);
                    factor.Push(factor.Peek());
                }
            }

            return result;
        }
    }
}