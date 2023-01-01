using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static Regex _regexPhone = new Regex(@"\/?\+([\d-]+);? ?");
        public static Regex _regexName = new Regex(@"<(.+)>");
        public static Regex _regexClean = new Regex("[$:;/,!?*]");

        public static string Phone(string strng, string num)
        {
            string record;

            try
            {
                record = strng.Split('\n').Where(x => x.Contains("+" + num)).SingleOrDefault();
            }
            catch (InvalidOperationException)
            {
                return $"Error => Too many people: {num}";
            }

            if (record == null) return $"Error => Not found: {num}";

            var matchPhone = _regexPhone.Match(record);
            var matchName = _regexName.Match(record);

            var address = record.Replace(matchPhone.Value, String.Empty)
                                .Replace(matchName.Value, String.Empty);

            address = _regexClean.Replace(address, string.Empty)
                                 .Replace("_", " ")
                                 .Replace("  ", " ")
                                 .Trim();

            return $"Phone => {matchPhone.Groups[1].Value}, Name => {matchName.Groups[1].Value}, Address => {address}";
        }
    }
}
