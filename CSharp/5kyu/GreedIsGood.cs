using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {

        public static int Score(int[] dice)
        {
            int[] tripleValue = { 0, 1000, 200, 300, 400, 500, 600 };
            int[] singleValue = { 0, 100, 0, 0, 0, 50, 0 };

            int value = 0;
            for (int diceSide = 1; diceSide <= 6; diceSide++)
            {
                int countRolls = dice.Where(r => r == diceSide).Count();
                value += tripleValue[diceSide] * (countRolls / 3) + singleValue[diceSide] * (countRolls % 3);
            }
            return value;
        }

        public static int Score_Kata_1(int[] dice)
        {
            return dice
                .GroupBy(d => d)
                .Select(g => Points(g.Key, g.Count()))
                .Sum();
        }
        private static int Points(int die, int count)
        {
            switch (die)
            {
                case 1:
                    return 1000 * (count / 3) + (count % 3) * 100;
                case 5:
                    return 500 * (count / 3) + (count % 3) * 50;
                default:
                    return die * 100 * (count / 3);
            }
        }
    }
}