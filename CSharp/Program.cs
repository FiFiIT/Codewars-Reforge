using System;
using System.Collections.Generic;
using CSharp._5kyu;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMe();
        }

        static void RunMe()
        {
            var input = new List<int[][]>();
            input.Add(new int[][]
                {
                new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
                });
            input.Add(new int[][]
                {
                new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
                new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
                new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
                new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
                });
            input.Add(new int[][]
            {
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                new int[] {2, 3, 1, 5, 6, 4, 8, 9, 7},
                new int[] {3, 1, 2, 6, 4, 5, 9, 7, 8},
                new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
                new int[] {5, 6, 4, 8, 9, 7, 2, 3, 1},
                new int[] {6, 4, 5, 9, 7, 8, 3, 1, 2},
                new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
                new int[] {8, 9, 7, 2, 3, 1, 5, 6, 4},
                new int[] {9, 7, 8, 3, 1, 2, 6, 4, 5},
            });

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<string>();
            foreach (var item in input)
            {
                result.Add(Kata5.DoneOrNot(item));
            }

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("RunTime: " + milliseconds);
        }
        static IEnumerable<int> GetFromFile(string path)
        {
            List<int> result = new List<int>();

            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                foreach (var x in line.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                {
                    result.Add(int.Parse(x));
                }
            }

            return result;
        }
    }
}
