using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string DomainName_Kata_1(string url)
        {
            return url.Split("//").Last().Split("www.").Last().Split(".").First();
        }
        public static string DomainName(string url)
        {
            return Regex.Match(url, @"(?:http(?:s)?:\/\/)?(?:w{3}\.)?[^\.]+").Value;
        }
    }
}