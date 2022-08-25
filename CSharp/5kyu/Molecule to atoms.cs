using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            var result = new Dictionary<string, int>();

            var pattern = @"[\(\[\{]\w+\d?[\)\]\}]\d?";
            var match = Regex.Match(formula, pattern);
            while (match.Success)
            {
                Test(match.Groups[0].Value, result);
                formula = Regex.Replace(formula, pattern, "");

                match = Regex.Match(formula, pattern);
            }

            if (formula.Length > 0)
            {
                Test(formula, result);
            }

            return result;
        }

        private static void Test(string formula, Dictionary<string, int> result)
        {
            var pattern2 = @"([A-Z][a-z]?)(\d?)";
            var match2 = Regex.Match(formula, pattern2);
            var elements = new List<string>();

            while (match2.Success)
            {
                var element = match2.Groups[1].Value;
                var atom = String.IsNullOrEmpty(match2.Groups[2].Value) ? 1 : int.Parse(match2.Groups[2].Value);

                if (result.ContainsKey(element))
                {
                    result[element] += atom;
                }
                else
                {
                    result.Add(element, atom);
                }

                elements.Add(element);
                match2 = match2.NextMatch();
            }

            int value;
            var patternForMultiply = @"\w+\d?[\)\]\}](\d)";
            var multiply = Regex.Match(formula, patternForMultiply);
            if (multiply.Success)
            {
                value = int.Parse(multiply.Groups[1].Value);
                foreach (var element in elements)
                {
                    result[element] *= value;
                }
            }
        }
    }
}