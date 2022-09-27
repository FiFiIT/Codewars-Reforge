using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public class SnakesLadders
        {
            private Dictionary<int, int> board = new Dictionary<int, int> {
                { 2, 38 },
                { 7 , 14},
                { 8, 31 },
                { 15, 26},
                { 16, 6},
                {21, 42},
                {28, 84},
                {36,44},
                {46, 25},
                {49, 11},
                {51,67},
                {62,19},
                {64,60},
                {71, 91},
                {74,53},
                {78,98},
                {87,94},
                {89, 68},
                {92,88},
                {95, 75},
                {99,80}
            };
            private int[] player;
            private bool gameOver;
            private int playCount;

            public SnakesLadders()
            {
                player = new int[] { 0, 0 };
                gameOver = false;
                playCount = 0;
            }
            public string play(int die1, int die2)
            {
                if (gameOver)
                    return "Game Over!";

                int current = playCount % 2;

                player[current] += die1 + die2;

                player[current] = player[current] > 100 ? 100 - (player[current] - 100) : player[current];

                if (board.ContainsKey(player[current]))
                    player[current] = board[player[current]];

                if (player[current] == 100)
                {
                    gameOver = true;
                    return $"Player {current + 1} Wins!";
                }

                var result = $"Player {current + 1} is on square {player[current]}";
                if (die1 != die2)
                    playCount++;

                return result;
            }
        }
    }
}