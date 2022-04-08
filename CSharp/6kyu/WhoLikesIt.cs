using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static string Likes(string[] names)
        {
            switch (names.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return names[0] + " likes this";
                case 2:
                    return names[0] + " and " + names[1] + " like this";
                case 3:
                    return names[0] + ", " + names[1] + " and " + names[2] + " like this";
                default:
                    return names[0] + ", " + names[1] + " and " + (names.Length - 2) + " others like this";

            }
        }
    }
}