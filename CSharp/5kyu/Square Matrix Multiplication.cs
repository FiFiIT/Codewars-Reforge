using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int[,] MatrixMultiplication(int[,] a, int[,] b)
        {
            int size = a.GetLength(0);
            var matrix = new int[size, size];
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    for (int x = 0; x < size; x++)
                    {
                        if (x == 0)
                            Console.Write($"{a[r, x]} * {b[x, c]}");
                        else
                            Console.Write($" + {a[r, x]} * {b[x, c]}");

                        matrix[r, c] += a[r, x] * b[x, c];
                    }
                    Console.WriteLine($" = {matrix[r, c]}");
                }
            }

            return matrix;
        }
    }
}
