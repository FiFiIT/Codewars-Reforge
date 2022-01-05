using System;
using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string HighAndLow(string numbers)
        {
            return string.Join(" ", numbers.Split(" ").Select(i => int.Parse(i)).Max(), numbers.Split(" ").Select(i => int.Parse(i)).Min());
        }
    }

};