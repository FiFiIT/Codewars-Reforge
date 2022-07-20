using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string DoneOrNot(int[][] board)
        {
            if (Validate(board))
            {
                return "Finished!";
            }


            return "Try again!";
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

        private static bool Validate(int[][] board, bool transmute = true)
        {
            for (int r = 0; r < 9; r++)
            {
                if (board[r].Distinct().Count() != 9 || board[r].Max() > 9 || board[r].Min() < 1)
                {
                    System.Console.WriteLine(String.Join(", ", board[r]));
                    return false;
                }
            }

            if (transmute)
                return Validate(Transmute(board), false);

            return true;
        }
    }
}