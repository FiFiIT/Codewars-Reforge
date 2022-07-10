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
            var input = new List<int[]>() {
                new int[] { 1, 2, 3, 6, 4, 1, 2, 3, 2, 1 },
                new int[]{3,2,3,6,4,1,2,3,2,1,2,3},
                new int[]{3,2,3,6,4,1,2,3,2,1,2,2,2,1},
                new int[]{2,1,3,1,2,2,2,2,1},
                new int[]{2,1,3,1,2,2,2,2},
                new int[] {},
                new int[] {4, 12, 6, -3, -2, 1, 9, 6, 0, 11, 0, 17, 9, -4, 16, 15, -2, 8, 1, -3, 3, 3}
            };
            // var input_1 = new List<String>() { "aabb", "abcd", "bbaa", "dada" };
            // var input = GetFromFile("./temp/longArray1.txt");

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<Dictionary<string, List<int>>>();
            foreach (var item in input)
            {
                result.Add(Kata5.GetPeaks(item));
            }

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            //Console.WriteLine(result);
            // Console.WriteLine(String.Join(", ", result));
            foreach (var item in result)
            {
                foreach (var i in item)
                {
                    Console.Write($"{i.Key}: {String.Join(",", i.Value)}".PadRight(20));
                }
                Console.WriteLine();
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
