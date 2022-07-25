using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string DoneOrNot(int[][] board)
        {
            return IsDone(board) ? "Finished!" : "Try again!";
        }

        private static bool IsDone(int[][] board)
        {
            var result = Enumerable.Range(0, 9)
                .SelectMany(i =>
                {
                    var rowsChek = board[i].Sum();
                    var colsCheck = board.Sum(b => b[i]);
                    var blockCheck = board.Skip(3 * (i / 3)).Take(3).SelectMany(r => r.Skip(3 * (i % 3)).Take(3)).Sum();

                    return new[] { rowsChek, colsCheck, blockCheck };
                });

            return result.Any(i => i != 45);
        }

        private static void Print2dArray(int[][] board)
        {
            foreach (var row in board)
            {
                System.Console.WriteLine(String.Join(", ", row));
            }
        }

        public static int[][] Transmute(int[][] board)
        {
            var newBoard = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                newBoard[i] = new int[9];
            }

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    newBoard[c][r] = board[r][c];
                }
            }

            // Print2dArray(newBoard);
            return newBoard;
        }

        public static bool ValidateBlocks(int[][] board)
        {
            var blocks = new string[9];
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    blocks[c / 3 + (r / 3) * 3] += board[r][c];
                }
            }

            return true;
        }

        private static bool Validate(int[][] board, bool transmute = true)
        {
            var blocks = new string[9];

            for (int r = 0; r < 9; r++)
            {
                if (board[r].Distinct().Count() != 9 || board[r].Max() > 9 || board[r].Min() < 1)
                {
                    System.Console.WriteLine(String.Join(", ", board[r]));
                    return false;
                }
                for (int c = 0; c < 9; c++)
                {
                    blocks[c / 3 + (r / 3) * 3] += board[r][c];
                }
            }

            if (blocks.Any(b => b.Distinct().Count() != 9)) return false;

            if (transmute)
                return Validate(Transmute(board), false);

            return true;
        }
    }
}