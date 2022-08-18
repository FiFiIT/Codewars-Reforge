using System.Linq;
namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int IsSolved(int[,] board)
        {
            //Two dimensional array
            int d1 = 1, d2 = 1;
            bool empty = false;

            for (int i = 0; i < 3; i++)
            {
                d1 *= board[i, i];
                d2 *= board[2 - i, i];

                int row = 1, col = 1;
                for (int j = 0; j < 3; j++)
                {
                    row *= board[i, j];
                    col *= board[j, i];
                }

                if (row == 1 || col == 1) return 1;
                if (row == 8 || col == 8) return 2;
                if (row == 0 || col == 0) empty = true;
            }

            if (d1 == 1 || d2 == 1) return 1;
            if (d1 == 8 || d2 == 8) return 2;
            if (empty) return -1;

            return 0;
        }

        public static int IsSolved_kata_2(int[,] b)
        {
            var c012 = new int[] { 0, 1, 2 };
            var s = string.Join(",", c012.Select(x => string.Join("", c012.Select(y => b[x, y])))) + ","
                 + string.Join(",", c012.Select(x => string.Join("", c012.Select(y => b[y, x])))) + ","
                 + string.Join("", c012.Select(x => b[x, x])) + ","
                 + string.Join("", c012.Select(x => b[2 - x, x]));
            return s.Contains("111") ? 1 : s.Contains("222") ? 2 : !s.Contains("0") ? 0 : -1;
        }

        public static int IsSolved_kata_3(int[,] board)
        {
            var winLines = new int[][] {
                new []{0,1,2},
                new []{3,4,5},
                new []{6,7,8},
                new []{0,3,6},
                new []{1,4,7},
                new []{2,5,8},
                new []{0,4,8},
                new []{2,4,6}
            };

            var flattenedBoard = board.Cast<int>().ToArray();
            bool draw = true;

            foreach (var line in winLines)
            {
                if (line.All(x => flattenedBoard[x] == 1)) return 1;
                if (line.All(x => flattenedBoard[x] == 2)) return 2;

                draw = !flattenedBoard.Contains(0);
            }

            return draw ? 0 : -1;
        }
    }
}