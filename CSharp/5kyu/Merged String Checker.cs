using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            Console.WriteLine("target: " + s);
            Console.WriteLine("part 1: " + part1);
            Console.WriteLine("part 2: " + part2);
            Console.WriteLine(new String('-', 30));

            bool empty1 = part1.Length == 0,
                empty2 = part2.Length == 0,
                works1 = false,
                works2 = false;

            if (s.Length == 0)
            {
                if (part1.Length == 0 && part2.Length == 0) return true;

                return false;
            }
            else
            {
                if (!empty1 && s[0] == part1[0]) works1 = isMerge(s.Substring(1), part1.Substring(1), part2);
                if (!empty2 && s[0] == part2[0]) works2 = isMerge(s.Substring(1), part1, part2.Substring(1));

                return works1 || works2;
            }
        }
    }
}