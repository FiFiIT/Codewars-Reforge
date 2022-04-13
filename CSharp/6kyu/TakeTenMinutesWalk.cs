using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static bool IsValidWalk(string[] walk)
        {
            return walk.Length == 10 && walk.Count(w => w == "n") == walk.Count(w => w == "s") && walk.Count(w => w == "e") == walk.Count(w => w == "w");
        }

        public static bool IsValidWalk_kata(string[] walk)
        {
            int dx = 0;
            int dy = 0;
            int d = walk.Length;

            foreach (var w in walk)
            {
                switch (w)
                {
                    case "n":
                        dy++;
                        break;
                    case "s":
                        dy--;
                        break;
                    case "e":
                        dx++;
                        break;
                    case "w":
                        dx--;
                        break;
                }
            }

            return d == 10 && dx == 0 && dy == 0;
        }
    }
}